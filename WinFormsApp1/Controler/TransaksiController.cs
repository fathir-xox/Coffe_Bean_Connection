using FinalProjek.Database;
using FinalProjek.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace FinalProjek.Controler
{
    public class TransaksiController
    {
        private DbContext dbHelper;

        public TransaksiController()
        {
            dbHelper = new DbContext();
        }

        public int CreateTransaksi(Transaksi transaksi)
        {
            // TAMBAHAN: Validasi awal agar tidak mengirim ID 0 atau null ke database
            if (transaksi.id_user <= 0)
                throw new Exception("ID User tidak valid. Harap pastikan Anda sudah login dengan benar.");

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                    INSERT INTO transaksi (id_user, total_harga, jumlah_bayar, metode_bayar, status_transaksi) 
                    VALUES (@IdUser, @TotalHarga, @JumlahBayar, @MetodePembayaran::metode_bayar_enum, @StatusTransaksi::status_transaksi_enum) 
                    RETURNING id_transaksi";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUser", transaksi.id_user);
                        command.Parameters.AddWithValue("@TotalHarga", transaksi.total_harga);
                        command.Parameters.AddWithValue("@JumlahBayar", transaksi.jumlah_bayar);
                        command.Parameters.AddWithValue("@MetodePembayaran", transaksi.metode_bayar.ToLower());
                        command.Parameters.AddWithValue("@StatusTransaksi", transaksi.status_transaksi.ToLower());

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                // Tangkapan khusus untuk error database agar Anda tahu jika Foreign Key yang bermasalah
                if (ex.SqlState == "23503")
                    throw new Exception("Data User tidak ditemukan di database (Foreign Key Violation). Cek apakah ID User " + transaksi.id_user + " terdaftar di tabel users.");
                throw new Exception("Gagal membuat transaksi baru: " + ex.Message);
            }
        }

        public void AddDetail(DetailTransaksi detail)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string queryInsert = @"
                        INSERT INTO detailtransaksi (id_transaksi, id_produk, nama_produk, harga, qty) 
                        VALUES (@IdTransaksi, @IdProduk, @NamaProduk, @Harga, @Qty)";

                    using (NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, connection))
                    {
                        commandInsert.Parameters.AddWithValue("@IdTransaksi", detail.id_transaksi);
                        commandInsert.Parameters.AddWithValue("@IdProduk", detail.id_produk);
                        commandInsert.Parameters.AddWithValue("@NamaProduk", detail.nama_produk);
                        commandInsert.Parameters.AddWithValue("@Harga", detail.harga);
                        commandInsert.Parameters.AddWithValue("@Qty", detail.qty);
                        commandInsert.ExecuteNonQuery();
                    }

                    // Logika otomatis untuk memotong kuantitas stok produk
                    string queryUpdateStok = "UPDATE produk SET stok = stok - @Qty WHERE id_produk = @IdProduk";
                    using (NpgsqlCommand commandUpdate = new NpgsqlCommand(queryUpdateStok, connection))
                    {
                        commandUpdate.Parameters.AddWithValue("@Qty", detail.qty);
                        commandUpdate.Parameters.AddWithValue("@IdProduk", detail.id_produk);
                        commandUpdate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Gagal menyimpan rincian pesanan: " + ex.Message); }
        }

        public List<Transaksi> GetRiwayatLengkapByUser(int idUser)
        {
            List<Transaksi> list = new List<Transaksi>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                        SELECT t.id_transaksi, t.tanggal, COALESCE(SUM(dt.qty), 0) AS total_item, t.total_harga, t.metode_bayar::text
                        FROM transaksi t
                        LEFT JOIN detailtransaksi dt ON t.id_transaksi = dt.id_transaksi
                        WHERE t.id_user = @IdUser
                        GROUP BY t.id_transaksi, t.tanggal, t.total_harga, t.metode_bayar
                        ORDER BY t.tanggal DESC";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUser", idUser);
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi trx = new Transaksi
                                {
                                    id_transaksi = reader.GetInt32(0),
                                    tanggal = reader.GetDateTime(1),
                                    total_item = Convert.ToInt32(reader.GetInt64(2)),
                                    total_harga = reader.GetInt32(3),
                                    metode_bayar = reader.GetString(4)
                                };
                                list.Add(trx);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Gagal mengambil riwayat transaksi: " + ex.Message); }
            return list;
        }

        public (int jumlahTransaksi, int totalItem, int omzet) GetStatistikRiwayat(int idUser)
        {
            int jumlah = 0; int totalItem = 0; int omzet = 0;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string queryTrx = "SELECT COUNT(id_transaksi), COALESCE(SUM(total_harga), 0) FROM transaksi WHERE id_user = @IdUser";
                    using (var cmdTrx = new NpgsqlCommand(queryTrx, connection))
                    {
                        cmdTrx.Parameters.AddWithValue("@IdUser", idUser);
                        using (var reader = cmdTrx.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                jumlah = Convert.ToInt32(reader.GetInt64(0));
                                omzet = Convert.ToInt32(reader.GetDecimal(1));
                            }
                        }
                    }

                    string queryItem = @"
                        SELECT COALESCE(SUM(dt.qty), 0) 
                        FROM detailtransaksi dt 
                        JOIN transaksi t ON dt.id_transaksi = t.id_transaksi 
                        WHERE t.id_user = @IdUser";
                    using (var cmdItem = new NpgsqlCommand(queryItem, connection))
                    {
                        cmdItem.Parameters.AddWithValue("@IdUser", idUser);
                        totalItem = Convert.ToInt32(cmdItem.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Gagal mengambil akumulasi statistik: " + ex.Message); }
            return (jumlah, totalItem, omzet);
        }
        public List<Transaksi> GetAllTransaksi()
        {
            List<Transaksi> listTrx = new List<Transaksi>();
            try
            {
                // Ganti dbHelper.connStr sesuai dengan cara Anda memanggil koneksi database
                using (var conn = new Npgsql.NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    // Mengambil semua data dari tabel transaksi
                    string query = "SELECT * FROM transaksi";

                    using (var cmd = new Npgsql.NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaksi trx = new Transaksi();

                            // Sesuaikan string di dalam reader["..."] dengan nama kolom di database Anda
                            trx.id_transaksi = Convert.ToInt32(reader["id_transaksi"]);
                            trx.id_user = Convert.ToInt32(reader["id_user"]);
                            trx.total_harga = Convert.ToInt32(reader["total_harga"]);
                            trx.jumlah_bayar = Convert.ToInt32(reader["jumlah_bayar"]);
                            trx.metode_bayar = reader["metode_bayar"].ToString();
                            trx.status_transaksi = reader["status_transaksi"].ToString();

                            listTrx.Add(trx);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data transaksi: " + ex.Message, "Error Sistem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listTrx;
        }
    }
}
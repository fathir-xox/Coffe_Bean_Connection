using Npgsql;
using FinalProjek.Model;
using FinalProjek.Interface;
using FinalProjek.Database;
using System;
using System.Collections.Generic;

namespace FinalProjek.Controler
{
    public class TransaksiController : ITransaksi
    {
        private DbContext dbHelper;

        public TransaksiController()
        {
            dbHelper = new DbContext();
        }

        public int CreateTransaksi(Transaksi transaksi)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    // PERBAIKAN 1: Hapus kolom "kembalian", biarkan PostgreSQL yang menghitungnya.
                    // PERBAIKAN 2: Sesuaikan nama tabel "transaksi" dan enum-nya.
                    string query = @"
            INSERT INTO transaksi (id_kasir, total_harga, jumlah_bayar, metode_bayar, status_transaksi) 
            VALUES (@id_kasir, @total_harga, @jumlah_bayar, @metode_bayar::metode_bayar_enum, @status_transaksi::status_transaksi_enum) 
            RETURNING id_transaksi";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_kasir", transaksi.id_kasir);
                        command.Parameters.AddWithValue("@total_harga", transaksi.total_harga); // Pastikan properti model sudah int
                        command.Parameters.AddWithValue("@jumlah_bayar", transaksi.jumlah_bayar); // Pastikan properti model sudah int

                        // Pastikan value string dari Model sesuai dengan ENUM database (huruf kecil: 'tunai', 'transfer', 'qris')
                        command.Parameters.AddWithValue("@metode_bayar", transaksi.metode_bayar.ToLower());
                        command.Parameters.AddWithValue("@status_transaksi", transaksi.status_transaksi.ToLower());

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
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
                    // PERBAIKAN 1: Nama tabel di database menjadi "detailtransaksi" (karena di DDL tidak diapit tanda kutip).
                    // PERBAIKAN 2: Hapus kolom "subtotal", biarkan PostgreSQL yang mengalikannya.
                    string queryInsert = @"
            INSERT INTO detailtransaksi (id_transaksi, id_produk, nama_produk, harga, qty) 
            VALUES (@id_transaksi, @id_produk, @nama_produk, @harga, @qty)";

                    using (NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, connection))
                    {
                        commandInsert.Parameters.AddWithValue("@id_transaksi", detail.id_transaksi);
                        commandInsert.Parameters.AddWithValue("@id_produk", detail.id_produk);
                        commandInsert.Parameters.AddWithValue("@nama_produk", detail.nama_produk);
                        commandInsert.Parameters.AddWithValue("@harga", detail.harga);
                        commandInsert.Parameters.AddWithValue("@qty", detail.qty);

                        commandInsert.ExecuteNonQuery();
                    }

                    // Update stok produk
                    string queryUpdateStok = "UPDATE produk SET stok = stok - @qty WHERE id_produk = @id_produk";
                    using (NpgsqlCommand commandUpdate = new NpgsqlCommand(queryUpdateStok, connection))
                    {
                        commandUpdate.Parameters.AddWithValue("@qty", detail.qty);
                        commandUpdate.Parameters.AddWithValue("@id_produk", detail.id_produk);
                        commandUpdate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambahkan detail pesanan: " + ex.Message);
            }
        }

        public List<Transaksi> GetAll()
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    string query = @"SELECT id_transaksi, id_kasir, tanggal, total_harga FROM transaksi ORDER BY id_transaksi DESC";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi transaksi = new Transaksi
                                {
                                    id_transaksi = reader.GetInt32(0),
                                    id_kasir = reader.GetInt32(1),
                                    tanggal = reader.GetDateTime(2),
                                    total_harga = reader.GetInt32(3)
                                };
                                list.Add(transaksi);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil semua data transaksi: " + ex.Message);
            }

            return list;
        }

        public List<DetailTransaksi> GetDetails(int idTransaksi)
        {
            List<DetailTransaksi> list = new List<DetailTransaksi>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "SELECT id_detail_transaksi, id_transaksi, id_produk, qty, harga, subtotal, nama_produk FROM detail_transaksi WHERE id_transaksi = @IdTransaksi";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdTransaksi", idTransaksi);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DetailTransaksi detail = new DetailTransaksi
                                {
                                    id_detail_transaksi = reader.GetInt32(0),
                                    id_transaksi = reader.GetInt32(1),
                                    id_produk = reader.GetInt32(2),
                                    qty = reader.GetInt32(3),
                                    harga = reader.GetInt32(4),
                                    subtotal = reader.GetInt32(5),
                                    nama_produk = reader.GetString(6)
                                };
                                list.Add(detail);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil detail transaksi: " + ex.Message);
            }

            return list;
        }

        public int GetPemasukanHariIni()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                        SELECT COALESCE(SUM(total_harga), 0)
                        FROM transaksi
                        WHERE DATE(tanggal) = CURRENT_DATE";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data pemasukan hari ini: " + ex.Message);
            }
        }

        public int GetJumlahTransaksiBulanIni()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                        SELECT COUNT(*)
                        FROM transaksi
                        WHERE EXTRACT(MONTH FROM tanggal) = EXTRACT(MONTH FROM CURRENT_DATE)
                        AND EXTRACT(YEAR FROM tanggal) = EXTRACT(YEAR FROM CURRENT_DATE)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil jumlah transaksi bulan ini: " + ex.Message);
            }
        }

        public int GetTotalPemasukanBulanIni()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                        SELECT COALESCE(SUM(total_harga), 0)
                        FROM transaksi
                        WHERE EXTRACT(MONTH FROM tanggal) = EXTRACT(MONTH FROM CURRENT_DATE)
                        AND EXTRACT(YEAR FROM tanggal) = EXTRACT(YEAR FROM CURRENT_DATE)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil total pemasukan bulan ini: " + ex.Message);
            }
        }

        public List<Transaksi> GetRiwayatByKasir(int idKasir)
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                        SELECT id_transaksi, tanggal, total_harga
                        FROM transaksi
                        WHERE id_kasir = @IdKasir
                        ORDER BY tanggal DESC";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdKasir", idKasir);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi transaksi = new Transaksi
                                {
                                    id_transaksi = reader.GetInt32(0),
                                    tanggal = reader.GetDateTime(1),
                                    total_harga = reader.GetInt32(2)
                                };
                                list.Add(transaksi);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil riwayat transaksi kasir: " + ex.Message);
            }

            return list;
        }
    }
}
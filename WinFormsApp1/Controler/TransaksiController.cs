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
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO transaksi (id_kasir, total_harga, jumlah_bayar, metode_bayar, status_transaksi) 
                        VALUES (@IdKasir, @TotalHarga, @JumlahBayar, @MetodePembayaran::metode_bayar_enum, @StatusTransaksi::status_transaksi_enum) 
                        RETURNING id_transaksi";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdKasir", transaksi.id_kasir);
                        command.Parameters.AddWithValue("@TotalHarga", transaksi.total_harga);
                        command.Parameters.AddWithValue("@JumlahBayar", transaksi.jumlah_bayar);
                        command.Parameters.AddWithValue("@MetodePembayaran", transaksi.metode_bayar.ToLower());
                        command.Parameters.AddWithValue("@StatusTransaksi", transaksi.status_transaksi.ToLower());

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Gagal membuat transaksi baru: " + ex.Message); }
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

        public List<Transaksi> GetRiwayatLengkapByKasir(int idKasir)
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
                        WHERE t.id_kasir = @IdKasir
                        GROUP BY t.id_transaksi, t.tanggal, t.total_harga, t.metode_bayar
                        ORDER BY t.tanggal DESC";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdKasir", idKasir);
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

        public (int jumlahTransaksi, int totalItem, int omzet) GetStatistikRiwayat(int idKasir)
        {
            int jumlah = 0; int totalItem = 0; int omzet = 0;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string queryTrx = "SELECT COUNT(id_transaksi), COALESCE(SUM(total_harga), 0) FROM transaksi WHERE id_kasir = @IdKasir";
                    using (var cmdTrx = new NpgsqlCommand(queryTrx, connection))
                    {
                        cmdTrx.Parameters.AddWithValue("@IdKasir", idKasir);
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
                        WHERE t.id_kasir = @IdKasir";
                    using (var cmdItem = new NpgsqlCommand(queryItem, connection))
                    {
                        cmdItem.Parameters.AddWithValue("@IdKasir", idKasir);
                        totalItem = Convert.ToInt32(cmdItem.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Gagal mengambil akumulasi statistik: " + ex.Message); }
            return (jumlah, totalItem, omzet);
        }
    }
}
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
                    // Query tetap menggunakan snake_case sesuai format kolom Database
                    string query = @"
                    INSERT INTO transaksi (id_kasir, total_harga, jumlah_bayar, kembalian, metode_bayar::metode_bayar, status_transaksi::status_transaksi) 
                    VALUES (@id_kasir, @total_harga, @jumlah_bayar, @kembalian, @metode_bayar::metode_bayar, @status_transaksi::status_transaksi) 
                    RETURNING id_transaksi";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Parameter dan properti model sekarang menggunakan PascalCase
                        command.Parameters.AddWithValue("@id_kasir", transaksi.id_kasir);
                        command.Parameters.AddWithValue("@total_harga", transaksi.total_harga);
                        command.Parameters.AddWithValue("@jumlah_bayar", transaksi.jumlah_bayar);
                        command.Parameters.AddWithValue("@kembalian", transaksi.kembalian);
                        command.Parameters.AddWithValue("@metode_bayar", transaksi.metode_pembayaran);
                        command.Parameters.AddWithValue("@status_transaksi", transaksi.status_transaksi);

                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                // Saran 2: Melempar error agar bisa ditangkap oleh Try-Catch di Form (UI)
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
                    
                    // 1. Insert data rincian produk yang dibeli
                    string queryInsert = @"
                    INSERT INTO detail_transaksi (id_transaksi, id_produk, nama_produk, harga, qty, subtotal) 
                    VALUES (@id_transaksi, @id_produk, @nama_produk, @harga, @qty, @subtotal)";

                    using (NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, connection))
                    {
                        commandInsert.Parameters.AddWithValue("@id_transaksi", detail.id_transaksi);
                        commandInsert.Parameters.AddWithValue("@id_produk", detail.id_produk);
                        commandInsert.Parameters.AddWithValue("@nama_produk", detail.nama_produk);
                        commandInsert.Parameters.AddWithValue("@harga", detail.harga);
                        commandInsert.Parameters.AddWithValue("@qty", detail.qty);
                        commandInsert.Parameters.AddWithValue("@subtotal", detail.subtotal);

                        commandInsert.ExecuteNonQuery();
                    }

                    // Saran 4: Update stok produk berkurang sesuai quantity (Qty)
                    string queryUpdateStok = "UPDATE produk SET stok = stok - @Qty WHERE id_produk = @IdProduk";
                    
                    using (NpgsqlCommand commandUpdate = new NpgsqlCommand(queryUpdateStok, connection))
                    {
                        commandUpdate.Parameters.AddWithValue("@Qty", detail.qty);
                        commandUpdate.Parameters.AddWithValue("@IdProduk", detail.id_produk);
                        
                        commandUpdate.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambahkan detail pesanan atau mengurangi stok: " + ex.Message);
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
using Npgsql;
using FinalProjek.Model;
using FinalProjek.Interface;
using FinalProjek.Database;

using FinalProjek.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Controler
{
    public class TransaksiController : ITransaksi
    {
        private DbContext dbHelper;

        public TransaksiController()
        {
            dbHelper = new DbContext();
        }

        public void CreateTransaksi(Transaksi transaksi)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                    INSERT INTO transaksi (id_transaksi, id_kasir, total_harga, jumlah_bayar, kembalian, metode_bayar::metode_bayar, status_transaksi::status_transaksi) 
                    VALUES (@id_transaksi, @id_kasir, @total_harga, @jumlah_bayar, @kembalian, @metode_bayar::metode_bayar, @status_transaksi::status_transaksi)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_transaksi", transaksi.id_transaksi);
                        command.Parameters.AddWithValue("@id_kasir", transaksi.id_kasir);
                        command.Parameters.AddWithValue("@total_harga", transaksi.total_harga);
                        command.Parameters.AddWithValue("@jumlah_bayar", transaksi.jumlah_bayar);
                        command.Parameters.AddWithValue("@kembalian", transaksi.kembalian);
                        command.Parameters.AddWithValue("@metode_bayar", transaksi.metode_pembayaran);
                        command.Parameters.AddWithValue("@status_transaksi", transaksi.status_transaksi);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating transaksi: " + ex.Message);
            }
        }

        public void AddDetail(DetailTransaksi detail)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"
                    INSERT INTO detail_transaksi (id_detail_transaksi, id_transaksi, id_produk, nama_produk, harga, qty, subtotal) 
                    VALUES (@id_detail_transaksi, @id_transaksi, @id_produk, @nama_produk, @harga, @qty, @subtotal)";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_detail_transaksi", detail.id_detail_transaksi);
                        command.Parameters.AddWithValue("@id_transaksi", detail.id_transaksi);
                        command.Parameters.AddWithValue("@id_produk", detail.id_produk);
                        command.Parameters.AddWithValue("@nama_produk", detail.nama_produk);
                        command.Parameters.AddWithValue("@harga", detail.harga);
                        command.Parameters.AddWithValue("@qty", detail.qty);
                        command.Parameters.AddWithValue("@subtotal", detail.subtotal);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding detail: " + ex.Message);
            }
        }

        public List<TransaksiController> GetAll()
        {
            List<TransaksiController> list = new List<TransaksiController>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();

                    string query = @"SELECT id_transaksi, id_kasir, tanggal, total_harga FROM transaksi ORDER BY id DESC";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader  = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransaksiController transaksi = new TransaksiController();
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

           
           
using Npgsql;
using FinalProjek.Database;
using FinalProjek.Interface;
using FinalProjek.Model;
using System;
using System.Collections.Generic;
// Hapus System.Windows.Forms karena UI tidak boleh ada di Controller

namespace FinalProjek.Controler
{
    // Typo diperbaiki menjadi dua L: Controller
    public class ProdukController : IProduk
    {
        private DbContext dbHelper;

        public ProdukController()
        {
            dbHelper = new DbContext();
        }

        public void CreateProduk(Produk produk)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"INSERT INTO produk (nama_produk, harga, stok, imageproduk, deskripsi, id_kategori) 
                                     VALUES (@nama_produk, @harga, @stok, @imageproduk, @deskripsi, @id_kategori)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        // Disesuaikan dengan PascalCase dari C# conventions
                        cmd.Parameters.AddWithValue("@nama_produk", produk.nama_produk);
                        cmd.Parameters.AddWithValue("@harga", produk.harga);
                        cmd.Parameters.AddWithValue("@stok", produk.stok);
                        cmd.Parameters.AddWithValue("@imageproduk", produk.imageproduk ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@deskripsi", produk.deskripsi);
                        cmd.Parameters.AddWithValue("@id_kategori", produk.id_kategori);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Melempar pesan error ke View (Form) agar form yang memunculkan MessageBox
                throw new Exception($"Gagal menambah produk: {ex.Message}");
            }
        }

        public List<Produk> GetAllProduk()
        {
            List<Produk> produks = new List<Produk>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();

                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, imageproduk FROM produk ORDER BY id_produk DESC";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Produk produk = new Produk
                                {
                                    id_produk = reader.GetInt32(0),
                                    nama_produk = reader.GetString(1),
                                    // Menggunakan GetInt32 asumsikan Harga Rupiah utuh. Jika database pakai double/numeric, gunakan GetDecimal() atau GetDouble() dengan hati-hati.
                                    harga = reader.GetInt32(2),
                                    stok = reader.GetInt32(3),
                                    deskripsi = reader.IsDBNull(4) ? "" : reader.GetString(4), // Jaga-jaga jika deskripsi kosong
                                    imageproduk = reader.IsDBNull(5) ? null : (byte[])reader["imageproduk"]
                                };
                                produks.Add(produk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Melempar pesan error
                throw new Exception($"Gagal mengambil data produk: {ex.Message}");
            }

            return produks;
        }
    }
}
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

        public List<Produk> GetAllProduk()
        {
            List<Produk> produks = new List<Produk>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();

                    // Saya sesuaikan juga di sini: tidak mengambil 'image' karena di bawahnya tidak ada reader untuk image
                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, imageproduk FROM produk WHERE isactive = true"; //tambah image dan is_active untuk hanya menampilkan produk yang aktif

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
                                    harga = reader.GetDouble(2),
                                    stok = reader.GetInt32(3),
                                    deskripsi = reader.GetString(4),
                                    imageproduk = reader["imageproduk"] as byte[]
                                };
                                produks.Add(produk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get All Product Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produks;
        }

        internal void UpdateProduk(Produk produk)
        {
            throw new NotImplementedException();
        }


        // PERBAIKAN 4: Implementasi soft delete dengan mengubah is_active menjadi false
        // Signature changed to match IProduk.DeleteProduk(object)
        public bool DeleteProduk(object id_produk)
        {
            try
            {
                int id;
                if (id_produk is int i) id = i;
                else
                {
                    // Try to convert common types (string, long, etc.)
                    id = Convert.ToInt32(id_produk);
                }

                using var conn = new NpgsqlConnection(dbHelper.connStr);
                conn.Open();
                // Soft delete: set is_active = false
                string query = "UPDATE produk SET isactive = false, updated_at = NOW() WHERE id_produk = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat soft delete: {ex.Message}");
                return false;
            }
        }
    }
}
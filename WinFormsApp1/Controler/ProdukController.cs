using Npgsql;
using FinalProjek.Database;
using FinalProjek.Interface;
using FinalProjek.Model;
using FinalProjek.Helper;
using System;
using System.Collections.Generic; // PERBAIKAN 1: Tambahan untuk List
using System.Windows.Forms;       // PERBAIKAN 1: Tambahan untuk MessageBox

namespace FinalProjek.Controler
{
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
                    string query = @"Insert Into produk (nama_produk,harga,stok,image,deskripsi,id_user) 
                                     Values (@nama_produk,@harga,@stok,@image,@deskripsi)";

                    // PERBAIKAN 2: Masukkan 'query' ke dalam NpgsqlCommand
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama_produk", produk.nama_produk);
                        cmd.Parameters.AddWithValue("@harga", produk.harga);
                        cmd.Parameters.AddWithValue("@stok", produk.stok);
                        cmd.Parameters.AddWithValue("@image", produk.image ?? (object)DBNull.Value); // Mencegah error jika gambar kosong
                        cmd.Parameters.AddWithValue("@deskripsi", produk.deskripsi);
                        

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Create Product Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Produk> GetByUserId(int id_user)
        {
            List<Produk> produks = new List<Produk>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();

                    // PERBAIKAN 3: Ubah 'image' menjadi 'id_user' pada query SELECT
                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, id_user FROM produk WHERE id_user = @idUser";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idUser", id_user);
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
                                    id_user = reader.GetInt32(5) // Sekarang indeks ke-5 benar-benar id_user
                                };
                                produks.Add(produk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Product By User ID Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produks;
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
                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi FROM produk";

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
                                    deskripsi = reader.GetString(4)
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
    }
}
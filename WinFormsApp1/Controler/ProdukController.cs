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
                    string query = @"Insert Into produk (nama_produk,harga,stok,imageproduk,deskripsi,id_kategori) 
                                     Values (@nama_produk,@harga,@stok,@imageproduk,@deskripsi,@id_kategori)";

                    // PERBAIKAN 2: Masukkan 'query' ke dalam NpgsqlCommand
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama_produk", produk.nama_produk);
                        cmd.Parameters.AddWithValue("@harga", produk.harga);
                        cmd.Parameters.AddWithValue("@stok", produk.stok);
                        cmd.Parameters.AddWithValue("@imageproduk", produk.imageproduk ?? (object)DBNull.Value); // Mencegah error jika gambar kosong
                        cmd.Parameters.AddWithValue("@deskripsi", produk.deskripsi);
                        cmd.Parameters.AddWithValue("@id_kategori", produk.id_kategori);


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
                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, id_kategori, imageproduk FROM produk"; //tambah image

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
                                    id_kategori = reader.GetInt32(5),
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
                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, imageproduk FROM produk WHERE is_active = true"; //tambah image dan is_active untuk hanya menampilkan produk yang aktif

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
                                    imageproduk = reader[5] as byte[]
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

        // method untuk menghapus produk dengan cara men-set is_active menjadi false
        public bool DeleteProduk(int id_produk)
        {
            try
            {
                using var conn = new NpgsqlConnection(dbHelper.connStr);
                conn.Open();
                string query = "UPDATE produk SET is_active = false WHERE id_produk = @id";
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id_produk);
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete error: {ex.Message}");
                return false;
            }
        }

        // method untuk mengembalikan produk yang sudah dihapus (non-aktif)
        public bool RestoreProduk(int id_produk)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "UPDATE produk SET is_active = true, updated_at = NOW() WHERE id_produk = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id_produk);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Restore produk error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // method untuk mengambil produk yang non-aktif
        public List<Produk> GetNonActiveProducts()
        {
            List<Produk> produks = new List<Produk>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    // Ambil produk dengan is_active = false
                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, imageproduk 
                             FROM produk 
                             WHERE is_active = false
                             ORDER BY id_produk";

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
                                    imageproduk = reader[5] as byte[]
                                };
                                produks.Add(produk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get non-active products error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produks;
        }
    }
}
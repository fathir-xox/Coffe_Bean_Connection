using Npgsql;
using FinalProjek.Database;
using FinalProjek.Interface;
using FinalProjek.Model;
using System;
using System.Collections.Generic;

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
                    string query = @"INSERT INTO produk (nama_produk, harga, stok, imageproduk, deskripsi, id_kategori) 
                                     VALUES (@nama_produk, @harga, @stok, @imageproduk, @deskripsi, @id_kategori)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
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
                throw new Exception($"Gagal menambah produk: {ex.Message}");
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
                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, id_kategori, imageproduk 
                                     FROM produk WHERE isactive = true";

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
                                    harga = reader.GetInt32(2),
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

                    string query = @"SELECT id_produk, nama_produk, harga, stok, deskripsi, imageproduk, id_kategori 
                                     FROM produk WHERE isactive = true";

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
                                    harga = reader.GetInt32(2),
                                    stok = reader.GetInt32(3),
                                    deskripsi = reader.GetString(4),
                                    imageproduk = reader["imageproduk"] as byte[],
                                    id_kategori = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
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

        public bool DeleteProduk(object id_produk)
        {
            try
            {
                int id;
                if (id_produk is int i) id = i;
                else
                {
                    id = Convert.ToInt32(id_produk);
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "UPDATE produk SET isactive = false WHERE id_produk = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat soft delete: {ex.Message}");
                return false;
            }
        }


      
        public bool UpdateStok(int idProduk, int jumlahPerubahan)
        {
            try
            {
                using (var conn = new NpgsqlConnection(dbHelper.connStr))
                {
                    conn.Open();
                    string query = "UPDATE produk SET stok = stok + @Perubahan WHERE id_produk = @IdProduk";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Perubahan", jumlahPerubahan);
                        cmd.Parameters.AddWithValue("@IdProduk", idProduk);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Update stok error: {ex.Message}");
                return false;

                throw new Exception("Gagal mengupdate stok: " + ex.Message);
            }
        }

        public bool UpdateProduk(Produk produk)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"UPDATE produk 
                                     SET nama_produk = @nama, harga = @harga, stok = @stok, 
                                         deskripsi = @deskripsi, id_kategori = @id_kategori
                                     WHERE id_produk = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama", produk.nama_produk);
                        cmd.Parameters.AddWithValue("@harga", produk.harga);
                        cmd.Parameters.AddWithValue("@stok", produk.stok);
                        cmd.Parameters.AddWithValue("@deskripsi", produk.deskripsi ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_kategori", produk.id_kategori);
                        cmd.Parameters.AddWithValue("@id", produk.id_produk);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Produk Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
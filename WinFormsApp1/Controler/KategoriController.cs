using Npgsql;
using FinalProjek.Database;
using FinalProjek.Interface;
using FinalProjek.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProjek.Controler
{
    public class KategoriController : IKategori
    {
        private DbContext dbHelper;

        public KategoriController()
        {
            dbHelper = new DbContext();
        }

        public void CreateKategori(Kategori kategori)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"INSERT INTO kategori (nama_kategori, deskripsi, isactive) 
                                     VALUES (@nama_kategori, @deskripsi, true)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama_kategori", kategori.nama_kategori);
                        cmd.Parameters.AddWithValue("@deskripsi", kategori.deskripsi ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Create Kategori Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Kategori> GetAllKategori()
        {
            List<Kategori> list = new List<Kategori>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "SELECT id_kategori, nama_kategori, deskripsi, isactive FROM kategori ORDER BY id_kategori";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Kategori
                            {
                                id_kategori = reader.GetInt32(0),
                                nama_kategori = reader.GetString(1),
                                deskripsi = reader.IsDBNull(2) ? null : reader.GetString(2),
                                isactive = reader.GetBoolean(3)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get All Kategori Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        public List<Kategori> GetActiveKategori()
        {
            List<Kategori> list = new List<Kategori>();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "SELECT id_kategori, nama_kategori, deskripsi, isactive FROM kategori WHERE isactive = true ORDER BY id_kategori";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Kategori
                            {
                                id_kategori = reader.GetInt32(0),
                                nama_kategori = reader.GetString(1),
                                deskripsi = reader.IsDBNull(2) ? null : reader.GetString(2),
                                isactive = reader.GetBoolean(3)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Active Kategori Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        public Kategori GetKategoriById(int id)
        {
            Kategori kategori = null;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "SELECT id_kategori, nama_kategori, deskripsi, isactive FROM kategori WHERE id_kategori = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                kategori = new Kategori
                                {
                                    id_kategori = reader.GetInt32(0),
                                    nama_kategori = reader.GetString(1),
                                    deskripsi = reader.IsDBNull(2) ? null : reader.GetString(2),
                                    isactive = reader.GetBoolean(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Kategori By ID Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return kategori;
        }

        public bool UpdateKategori(Kategori kategori)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = @"UPDATE kategori 
                                     SET nama_kategori = @nama_kategori, deskripsi = @deskripsi 
                                     WHERE id_kategori = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nama_kategori", kategori.nama_kategori);
                        cmd.Parameters.AddWithValue("@deskripsi", kategori.deskripsi ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", kategori.id_kategori);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Kategori Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteKategori(object id)
        {
            try
            {
                int kategoriId = Convert.ToInt32(id);
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "UPDATE kategori SET isactive = false WHERE id_kategori = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", kategoriId);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete Kategori Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool RestoreKategori(int id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(dbHelper.connStr))
                {
                    connection.Open();
                    string query = "UPDATE kategori SET isactive = true WHERE id_kategori = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Restore Kategori Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
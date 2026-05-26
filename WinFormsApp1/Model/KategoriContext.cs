using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using FinalProjek.DatabaseHelper;

namespace FinalProjek.Model
{
    public class KategoriContext
    {
        public List<Kategori> GetAllKategori()
        {
            List<Kategori> list = new List<Kategori>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT idKategori, namaKategori, deskripsi, isActive FROM kategori",
                conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Kategori(
                   reader.GetInt32(0),
                   reader.GetString(1),
                   reader.GetString(2),
                   reader.GetBoolean(3)
                ));
            }
            return list;
        }

        public void AddKategori(Kategori kategori)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO kategori (namaKategori, deskripsi, isActive) VALUES (@namaKategori, @deskripsi, @isActive)",
                conn);
            cmd.Parameters.AddWithValue("namaKategori", kategori.namaKategori);
            cmd.Parameters.AddWithValue("deskripsi", kategori.deskripsi);
            cmd.Parameters.AddWithValue("isActive", kategori.isActive);
            cmd.ExecuteNonQuery();
        }

        public void UpdateKategori(Kategori kategori)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE kategori SET namaKategori = @namaKategori, deskripsi = @deskripsi, isActive = @isActive WHERE idKategori = @idKategori",
                conn);
            cmd.Parameters.AddWithValue("idKategori", kategori.idKategori);
            cmd.Parameters.AddWithValue("namaKategori", kategori.namaKategori);
            cmd.Parameters.AddWithValue("deskripsi", kategori.deskripsi);
            cmd.Parameters.AddWithValue("isActive", kategori.isActive);
            cmd.ExecuteNonQuery();
        }

        public void DeleteKategori(int idKategori)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "DELETE FROM kategori WHERE idKategori = @idKategori",
                conn);
            cmd.Parameters.AddWithValue("idKategori", idKategori);
            cmd.ExecuteNonQuery();
        }
    }
}

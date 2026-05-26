using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using FinalProjek.DatabaseHelper;

namespace FinalProjek.Model
{
    public class ProdukContext
    {
        public List<Produk> GetAllProduk()
        {
            List<Produk> list = new List<Produk>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT idProduk, idKategori, namaProduk, harga, stok, stokMinimum, deskripsi, imageProduk, isActive FROM produk",
                conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Produk(
                   reader.GetInt32(0),
                   reader.GetInt32(1),
                   reader.GetString(2),
                   reader.GetDecimal(3),
                   reader.GetInt32(4),
                   reader.GetInt32(5),
                   reader.GetString(6),
                   (byte[])reader["imageProduk"],
                   reader.GetBoolean(8)
                ));
            }
            return list;
        }

        public void AddProduk(Produk produk)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO produk (idKategori, namaProduk, harga, stok, stokMinimum, deskripsi, imageProduk, isActive) " +
                "VALUES (@idKategori, @namaProduk, @harga, @stok, @stokMinimum, @deskripsi, @imageProduk, @isActive)",
                conn);
            cmd.Parameters.AddWithValue("idKategori", produk.idKategori);
            cmd.Parameters.AddWithValue("namaProduk", produk.namaProduk);
            cmd.Parameters.AddWithValue("harga", produk.harga);
            cmd.Parameters.AddWithValue("stok", produk.stok);
            cmd.Parameters.AddWithValue("stokMinimum", produk.stokMinimum);
            cmd.Parameters.AddWithValue("deskripsi", produk.deskripsi);
            cmd.Parameters.AddWithValue("imageProduk", produk.imageProduk);
            cmd.Parameters.AddWithValue("isActive", produk.isActive);
            cmd.ExecuteNonQuery();
        }

        public void UpdateProduk(Produk produk)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE produk SET idKategori = @idKategori, namaProduk = @namaProduk, harga = @harga, " +
                "stok = @stok, stokMinimum = @stokMinimum, deskripsi = @deskripsi, imageProduk = @imageProduk, isActive = @isActive " +
                "WHERE idProduk = @idProduk",
                conn);
            cmd.Parameters.AddWithValue("idProduk", produk.idProduk);
            cmd.Parameters.AddWithValue("idKategori", produk.idKategori);
            cmd.Parameters.AddWithValue("namaProduk", produk.namaProduk);
            cmd.Parameters.AddWithValue("harga", produk.harga);
            cmd.Parameters.AddWithValue("stok", produk.stok);
            cmd.Parameters.AddWithValue("stokMinimum", produk.stokMinimum);
            cmd.Parameters.AddWithValue("deskripsi", produk.deskripsi);
            cmd.Parameters.AddWithValue("imageProduk", produk.imageProduk);
            cmd.Parameters.AddWithValue("isActive", produk.isActive);
            cmd.ExecuteNonQuery();
        }


        public void DeleteProduk(int idProduk)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "DELETE FROM produk WHERE idProduk = @idProduk",
                conn);
            cmd.Parameters.AddWithValue("idProduk", idProduk);
            cmd.ExecuteNonQuery();
        }

    }
}

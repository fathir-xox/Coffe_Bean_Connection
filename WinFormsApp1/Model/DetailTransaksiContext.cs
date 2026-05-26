using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using FinalProjek.DatabaseHelper;

namespace FinalProjek.Model
{
    public class DetailTransaksiContext
    {
        public List<DetailTransaksi> GetAllDetailTransaksi()
        {
            List<DetailTransaksi> list = new List<DetailTransaksi>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT idDetailTransaksi, idTransaksi, idProduk, namaProduk, harga, qty, subtotal FROM detailTransaksi",
                conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new DetailTransaksi(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetInt32(2),
                    reader.GetString(3),
                    reader.GetDecimal(4),
                    reader.GetInt32(5),
                    reader.GetDecimal(6)
                ));
            }
            return list;
        }

        public void AddDetailTransaksi(DetailTransaksi detailTransaksi)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO detailTransaksi (idTransaksi, idProduk, namaProduk, harga, qty, subtotal) " +
                "VALUES (@idTransaksi, @idProduk, @namaProduk, @harga, @qty, @subtotal)",
                conn);
            cmd.Parameters.AddWithValue("idTransaksi", detailTransaksi.idTransaksi);
            cmd.Parameters.AddWithValue("idProduk", detailTransaksi.idProduk);
            cmd.Parameters.AddWithValue("namaProduk", detailTransaksi.namaProduk);
            cmd.Parameters.AddWithValue("harga", detailTransaksi.harga);
            cmd.Parameters.AddWithValue("qty", detailTransaksi.qty);
            cmd.Parameters.AddWithValue("subtotal", detailTransaksi.subtotal);
            cmd.ExecuteNonQuery();
        }

        public void UpdateDetailTransaksi(DetailTransaksi detailTransaksi)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE detailTransaksi SET idTransaksi = @idTransaksi, idProduk = @idProduk, namaProduk = @namaProduk, " +
                "harga = @harga, qty = @qty, subtotal = @subtotal WHERE idDetailTransaksi = @idDetailTransaksi",
                conn);
            cmd.Parameters.AddWithValue("idDetailTransaksi", detailTransaksi.idDetailTransaksi);
            cmd.Parameters.AddWithValue("idTransaksi", detailTransaksi.idTransaksi);
            cmd.Parameters.AddWithValue("idProduk", detailTransaksi.idProduk);
            cmd.Parameters.AddWithValue("namaProduk", detailTransaksi.namaProduk);
            cmd.Parameters.AddWithValue("harga", detailTransaksi.harga);
            cmd.Parameters.AddWithValue("qty", detailTransaksi.qty);
            cmd.Parameters.AddWithValue("subtotal", detailTransaksi.subtotal);
            cmd.ExecuteNonQuery();
        }

        public void DeleteDetailTransaksi(int idDetailTransaksi)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "DELETE FROM detailTransaksi WHERE idDetailTransaksi=@idDetailTransaksi",
                conn);
            cmd.Parameters.AddWithValue("idDetailTransaksi", idDetailTransaksi);
            cmd.ExecuteNonQuery();
        }
    }

}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using FinalProjek.DatabaseHelper;

namespace FinalProjek.Model
{
    public class TransaksiContext
    {
        public List<Transaksi> GetAllTransaksi()
        {
            List<Transaksi> list = new List<Transaksi>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT idTransaksi, idKasir, tanggal, totalHarga, jumlahBayar, kembalian, metodePembayaran, statusTransaksi FROM transaksi",
                conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Transaksi(
                    reader.GetInt32(0),
                    reader.GetInt32(1),
                    reader.GetDateTime(2),
                    reader.GetDecimal(3),
                    reader.GetDecimal(4),
                    reader.GetDecimal(5),
                    reader.GetString(6),
                    reader.GetString(7)
                ));
            }
            return list;
        }

        public void AddTransaksi(Transaksi transaksi)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO transaksi (idKasir, tanggal, totalHarga, jumlahBayar, kembalian, metodePembayaran, statusTransaksi) " +
                "VALUES (@idKasir, @tanggal, @totalHarga, @jumlahBayar, @kembalian, @metodePembayaran, @statusTransaksi)",
                conn);
            cmd.Parameters.AddWithValue("idKasir", transaksi.idKasir);
            cmd.Parameters.AddWithValue("tanggal", transaksi.tanggal);
            cmd.Parameters.AddWithValue("totalHarga", transaksi.totalHarga);
            cmd.Parameters.AddWithValue("jumlahBayar", transaksi.jumlahBayar);
            cmd.Parameters.AddWithValue("kembalian", transaksi.kembalian);
            cmd.Parameters.AddWithValue("metodePembayaran", transaksi.metodePembayaran);
            cmd.Parameters.AddWithValue("statusTransaksi", transaksi.statusTransaksi);
            cmd.ExecuteNonQuery();
        }

        public void UpdateTransaksi(Transaksi transaksi)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE transaksi SET idKasir = @idKasir, tanggal = @tanggal, totalHarga = @totalHarga, " +
                "jumlahBayar = @jumlahBayar, kembalian = @kembalian, metodePembayaran = @metodePembayaran, " +
                "statusTransaksi = @statusTransaksi WHERE idTransaksi = @idTransaksi",
                conn);
            cmd.Parameters.AddWithValue("idTransaksi", transaksi.idTransaksi);
            cmd.Parameters.AddWithValue("idKasir", transaksi.idKasir);
            cmd.Parameters.AddWithValue("tanggal", transaksi.tanggal);
            cmd.Parameters.AddWithValue("totalHarga", transaksi.totalHarga);
            cmd.Parameters.AddWithValue("jumlahBayar", transaksi.jumlahBayar);
            cmd.Parameters.AddWithValue("kembalian", transaksi.kembalian);
            cmd.Parameters.AddWithValue("metodePembayaran", transaksi.metodePembayaran);
            cmd.Parameters.AddWithValue("statusTransaksi", transaksi.statusTransaksi);
            cmd.ExecuteNonQuery();
        }

        public void DeleteTransaksi(int idTransaksi)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "DELETE FROM transaksi WHERE idTransaksi = @idTransaksi",
                conn);
            cmd.Parameters.AddWithValue("idTransaksi", idTransaksi);
            cmd.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Transaksi
    {
        public int idTransaksi { get; set; }
        public int idKasir { get; set; }
        public DateTime tanggal { get; set; }
        public decimal totalHarga { get; set; }
        public decimal jumlahBayar { get; set; }
        public decimal kembalian { get; set; }
        public string metodePembayaran { get; set; }
        public string statusTransaksi { get; set; }

        public Transaksi(int idTransaksi, int idKasir, DateTime tanggal, decimal totalHarga, decimal jumlahBayar, decimal kembalian, string metodePembayaran, string statusTransaksi)
        {
            this.idTransaksi = idTransaksi;
            this.idKasir = idKasir;
            this.tanggal = tanggal;
            this.totalHarga = totalHarga;
            this.jumlahBayar = jumlahBayar;
            this.kembalian = kembalian;
            this.metodePembayaran = metodePembayaran;
            this.statusTransaksi = statusTransaksi;
        }
    }
}

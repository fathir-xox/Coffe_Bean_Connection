using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }
        // Ubah dari id_kasir menjadi id_user
        public int id_user { get; set; }
        public DateTime tanggal { get; set; }
        public int total_harga { get; set; }
        public int jumlah_bayar { get; set; }
        public string metode_bayar { get; set; }
        public string status_transaksi { get; set; }

        // Properti tambahan untuk statistik (tidak masuk database)
        public int total_item { get; set; }
    }
}
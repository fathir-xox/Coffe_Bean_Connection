using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Transaksi
    {
        public int id_transaksi { get; set; }
        public int id_kasir { get; set; }

        public DateTime tanggal { get; set; }

        public double total_harga { get; set; }
        public double jumlah_bayar { get; set; }
        public double kembalian { get; set; }

        public string metode_bayar { get; set; }
        public string status_transaksi { get; set; }
        public List<DetailTransaksi> Detail { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public int IdKasir { get; set; }
        public DateTime Tanggal { get; set; }
        public int TotalHarga { get; set; }
        public int JumlahBayar { get; set; }
        public int Kembalian { get; set; }
        public string MetodePembayaran { get; set; }
        public string StatusTransaksi { get; set; }
        public List<DetailTransaksi> Detail { get; set; }
    }
}

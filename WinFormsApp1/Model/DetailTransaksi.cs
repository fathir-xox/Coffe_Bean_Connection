using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class DetailTransaksi
    {
        public int id_detail_transaksi { get; set; }

        public int id_transaksi { get; set; }
        public int id_produk { get; set; }

        public string nama_produk { get; set; }
        public int harga { get; set; }
        public int qty { get; set; }
        public int subtotal { get; set; }

       

    }
}

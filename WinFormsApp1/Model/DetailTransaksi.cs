using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class DetailTransaksi
    {
        public int idDetailTransaksi { get; set; }
        public int idTransaksi { get; set; }
        public int idProduk { get; set; }
        public string namaProduk { get; set; }
        public decimal harga { get; set; }
        public int qty { get; set; }
        public decimal subtotal { get; set; }

        public DetailTransaksi(int idDetailTransaksi, int idTransaksi, int idProduk, string namaProduk, decimal harga, int qty, decimal subtotal)
        {
            this.idDetailTransaksi = idDetailTransaksi;
            this.idTransaksi = idTransaksi;
            this.idProduk = idProduk;
            this.namaProduk = namaProduk;
            this.harga = harga;
            this.qty = qty;
            this.subtotal = harga * qty;
        }
    }
}

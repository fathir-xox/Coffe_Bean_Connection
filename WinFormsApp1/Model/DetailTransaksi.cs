using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class DetailTransaksi
    {
        public int IdDetailTransaksi { get; set; }
        public int IdTransaksi { get; set; }
        public int IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Qty { get; set; }
        public int Subtotal { get; set; }
    }
}

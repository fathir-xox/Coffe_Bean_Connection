using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Produk
    {
        public int IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public int StokMinimum { get; set; }
        public string Deskripsi { get; set; }
        public byte[] ImageProduk { get; set; }
        public bool IsActive { get; set; }
        public string StatusText => IsActive ? "Aktif" : "Nonaktif";
        public int CreatedBy { get; set; }  
    }
}

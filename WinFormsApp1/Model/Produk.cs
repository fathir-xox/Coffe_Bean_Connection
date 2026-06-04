using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Produk
    {
        public int id_produk { get; set; }
        public int id_kategori { get; set; }

        public string nama_produk { get; set; }
        public double harga { get; set; }
        public int stok { get; set; }
        public string deskripsi { get; set; }
        public byte[] imageproduk { get; set; }
        public bool is_active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        //public int id_user { get; set; }

    }
}

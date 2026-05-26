using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Produk
    {
        public int idProduk { get; set; }
        public int idKategori { get; set; }
        public string namaProduk { get; set; }
        public decimal harga { get; set; }
        public int stok { get; set; }
        public int stokMinimum { get; set; }
        public string deskripsi { get; set; }
        public byte[] imageProduk { get; set; }
        public bool isActive { get; set; }

        public Produk(int idProduk, int idKategori, string namaProduk, decimal harga, int stok,
                      int stokMinimum, string deskripsi, byte[] imageProduk, bool isActive)
        {
            this.idProduk = idProduk;
            this.idKategori = idKategori;
            this.namaProduk = namaProduk;
            this.harga = harga;
            this.stok = stok;
            this.stokMinimum = stokMinimum;
            this.deskripsi = deskripsi;
            this.imageProduk = imageProduk;
            this.isActive = isActive;
        }
    }
}

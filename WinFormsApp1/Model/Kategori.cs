using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Model
{
    public class Kategori
    {
        public int idKategori { get; set; }
        public string namaKategori { get; set; }
        public string deskripsi { get; set; }
        public bool isActive { get; set; }

        public Kategori(int idKategori, string namaKategori, string deskripsi, bool isActive)
        {
            this.idKategori = idKategori;
            this.namaKategori = namaKategori;
            this.deskripsi = deskripsi;
            this.isActive = isActive;
        }
    }
}

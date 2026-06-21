using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace FinalProjek.Model
{
    public class Kategori : BaseModel
    {
        public int id_kategori { get; set; }
        public string nama_kategori { get; set; }
        public string deskripsi { get; set; }
    }
}

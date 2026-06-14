using FinalProjek.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Interface
{
    public interface IKategori
    {
        void CreateKategori(Kategori kategori);
        List<Kategori> GetAllKategori();
        List<Kategori> GetActiveKategori();
        Kategori GetKategoriById(int id);
        bool UpdateKategori(Kategori kategori);
        bool DeleteKategori(object id);    // soft delete (set is_active = false)
        bool RestoreKategori(int id);      // optional: set is_active = true
    }
}

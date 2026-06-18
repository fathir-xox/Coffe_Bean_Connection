using System.Collections.Generic;
using FinalProjek.Model;

namespace FinalProjek.Interface
{
    public interface IKategori
    {
        void CreateKategori(Kategori kategori);
        List<Kategori> GetAllKategori();
        List<Kategori> GetActiveKategori();
        Kategori GetKategoriById(int id);
        bool UpdateKategori(Kategori kategori);
        bool DeleteKategori(object id);
        bool RestoreKategori(int id);
    }
}
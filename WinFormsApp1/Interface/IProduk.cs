using System.Collections.Generic;
using FinalProjek.Model;

namespace FinalProjek.Interface
{
    public interface IProduk
    {
        void CreateProduk(Produk produk);
        List<Produk> GetByUserId(int id_user);
        List<Produk> GetAllProduk();
        bool DeleteProduk(object id_produk);
        bool UpdateProduk(Produk produk);
    }
}
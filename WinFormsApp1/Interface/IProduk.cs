using System;
using System.Collections.Generic;
using System.Text;
using FinalProjek.Model;

namespace FinalProjek.Interface
{
    public interface IProduk
    {
        void CreateProduk(Produk produk);
        List<Produk> GetAllProduk();
        bool DeleteProduk(object id_produk);
    }
}

using FinalProjek.Controler;
using FinalProjek.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjek.Interface
{
    public interface ITransaksi
    {
        int CreateTransaksi(TransaksiController transaksi);
        void AddDetail(DetailTransaksi detail);
        List<TransaksiController> GetAll();
        List<DetailTransaksi> GetDetails(int transaksiId);
        List<TransaksiController> GetRiwayatByKasir(int userId);
        int GetPemasukanHariIni();
        int GetJumlahTransaksiBulanIni();
        int GetTotalPemasukanBulanIni();
    }
}

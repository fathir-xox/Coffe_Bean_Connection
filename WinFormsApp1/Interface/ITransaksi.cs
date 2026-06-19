using System.Collections.Generic;
using FinalProjek.Model; 

namespace FinalProjek.Interface
{
    public interface ITransaksi
    {
        int CreateTransaksi(Transaksi transaksi);
        void AddDetail(DetailTransaksi detail);
        List<Transaksi> GetAll();
        List<DetailTransaksi> GetDetails(int idTransaksi);
        int GetPemasukanHariIni();
        int GetJumlahTransaksiBulanIni();
        int GetTotalPemasukanBulanIni();
        List<Transaksi> GetRiwayatByKasir(int idKasir);
    }
}
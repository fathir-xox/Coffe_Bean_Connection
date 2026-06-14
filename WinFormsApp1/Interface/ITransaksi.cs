using System.Collections.Generic;
using FinalProjek.Model; // Pastikan memanggil namespace Model

namespace FinalProjek.Interface
{
    public interface ITransaksi
    {
        // Parameter dan return type wajib menggunakan Model (Transaksi dan DetailTransaksi)
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
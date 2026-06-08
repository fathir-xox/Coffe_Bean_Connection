using FinalProjek.Controler;
using FinalProjek.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_MonitorStok : Form
    {
        public V_MonitorStok()
        {
            InitializeComponent();
        }

        private void btDashboar_Click(object sender, EventArgs e)
        {
            this.Close();
            IProduk produkController = new ProdukController(); // buat instance controller
            AdminDashboardView frmDashboard = new AdminDashboardView(produkController);
            frmDashboard.ShowDialog();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Produk frmProduk = new V_Produk();
            frmProduk.ShowDialog();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Kategori frmKategori = new V_Kategori();
            frmKategori.ShowDialog();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            this.Close();
            V_MonitorStok frmMonitorStok = new V_MonitorStok();
            frmMonitorStok.ShowDialog();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Close();
            V_RiwayatTransaksi frmRiwayatTransaksi = new V_RiwayatTransaksi();
            frmRiwayatTransaksi.ShowDialog();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            this.Close();
            V_KelolaAkunUserr frmKelolaAkunUser = new V_KelolaAkunUserr();
            frmKelolaAkunUser.ShowDialog();
        }
    }
}

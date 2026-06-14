using FinalProjek.Controler;
using FinalProjek.Helper;
using FinalProjek.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FinalProjek.View.Kasir_View; // Pastikan namespace ini benar

namespace FinalProjek.View.Kasir_View
{
    public partial class V_RiwayatSaya : Form
    {
        private TransaksiController transaksiController;

        public V_RiwayatSaya()
        {
            InitializeComponent();
            transaksiController = new TransaksiController();
        }

        // =======================================================
        // SATU-SATUNYA EVENT LOAD YANG DIGUNAKAN
        // =======================================================
        private void V_RiwayatSaya_Load(object sender, EventArgs e)
        {
            // Pastikan APPSession sudah terisi saat login
            if (APPSession.CurrentUser != null)
            {
                int idKasirAktif = APPSession.CurrentUser.id_user;
                LoadStatistikCard(idKasirAktif);
                LoadTabelRiwayat(idKasirAktif);
            }
            else
            {
                // Jika null, mungkin user belum login, arahkan ke login atau beri peringatan
                MessageBox.Show("Sesi login tidak ditemukan. Silakan login kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =======================================================
        // 1. MENGISI 3 KARTU ATAS (Statistik)
        // =======================================================
        private void LoadStatistikCard(int idKasir)
        {
            try
            {
                var statistik = transaksiController.GetStatistikRiwayat(idKasir);
                lblTotalTrx.Text = statistik.jumlahTransaksi.ToString();
                lblTotalItem.Text = statistik.totalItem.ToString();
                lblOmzet.Text = $"Rp {statistik.omzet:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat statistik: " + ex.Message);
            }
        }

        // =======================================================
        // 2. MENGISI TABEL BAWAH (DataGridView)
        // =======================================================
        private void LoadTabelRiwayat(int idUser)
        {
            try
            {
                SetupDesainTabel();
                List<Transaksi> listRiwayat = transaksiController.GetRiwayatLengkapByUser(idUser);
                dgvRiwayat.Rows.Clear();

                foreach (var trx in listRiwayat)
                {
                    dgvRiwayat.Rows.Add(
                        $"#{trx.id_transaksi:D4}",
                        trx.tanggal.ToString("dd MMM yyyy, HH.mm"),
                        trx.total_item.ToString(),
                        $"Rp {trx.total_harga:N0}",
                        char.ToUpper(trx.metode_bayar[0]) + trx.metode_bayar.Substring(1)
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat tabel riwayat: " + ex.Message);
            }
        }

        private void SetupDesainTabel()
        {
            if (dgvRiwayat.Columns.Count > 0) return; // Mencegah duplikasi kolom

            dgvRiwayat.AutoGenerateColumns = false;
            dgvRiwayat.Columns.Add("ColNoTrx", "NO. TRX");
            dgvRiwayat.Columns.Add("ColTanggal", "TANGGAL");
            dgvRiwayat.Columns.Add("ColItem", "ITEM");
            dgvRiwayat.Columns.Add("ColTotal", "TOTAL");
            dgvRiwayat.Columns.Add("ColMetode", "METODE");

            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.RowTemplate.Height = 45;
            dgvRiwayat.ColumnHeadersHeight = 40;
        }

        // =======================================================
        // NAVIGASI
        // =======================================================
        private void btTransaksi_Click(object sender, EventArgs e)
        {
            KasirDashboardView frmKasir = new KasirDashboardView();
            frmKasir.Show();
            this.Hide();
        }

        // Abaikan fungsi kosong lainnya
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void V_RiwayatSaya_Load_1(object sender, EventArgs e) { }
    }
}
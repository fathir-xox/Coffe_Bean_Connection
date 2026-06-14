using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;
using FinalProjek.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProjek.View.Kasir_View
{
    public partial class KasirDashboardView : Form
    {
        // 1. DEKLARASI VARIABEL KELAS (Harus ada di dalam kurung kurawal class)
        private IProduk produkController;
        private TransaksiController transaksiController;
        private List<DetailTransaksi> keranjangBelanja;
        private int totalBelanja = 0;

        public KasirDashboardView()
        {
            InitializeComponent();

            produkController = new ProdukController();
            transaksiController = new TransaksiController();
            keranjangBelanja = new List<DetailTransaksi>();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            LoadDataProduk();
            RefreshKeranjang();

            cmbMetodeBayar.Items.Clear();
            cmbMetodeBayar.Items.Add("Tunai");
            cmbMetodeBayar.Items.Add("Transfer");
            cmbMetodeBayar.Items.Add("QRIS");
            if (cmbMetodeBayar.Items.Count > 0)
                cmbMetodeBayar.SelectedIndex = 0;
        }

        private void cmbMetodeBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodeBayar.SelectedItem == null) return;

            string metode = cmbMetodeBayar.SelectedItem.ToString();

            if (metode == "Transfer" || metode == "QRIS")
            {
                txtUangDiterima.Text = totalBelanja.ToString();
                txtUangDiterima.ReadOnly = true;
            }
            else
            {
                txtUangDiterima.Clear();
                txtUangDiterima.ReadOnly = false;
                lblKembalian.Text = "Rp 0";
            }
        }

        // =======================================================
        // MENGGAMBAR KARTU KERANJANG DI FLOWLAYOUTPANEL
        // =======================================================
        private void RefreshKeranjang()
        {
            // Pastikan Anda sudah mengubah nama komponen keranjang menjadi flpKeranjang
            flpKeranjang.Controls.Clear();
            totalBelanja = 0;

            foreach (var item in keranjangBelanja)
            {
                totalBelanja += item.subtotal;

                Panel pnlItem = new Panel
                {
                    Size = new Size(320, 70),
                    Margin = new Padding(3, 3, 3, 8),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblNama = new Label { Text = item.nama_produk, Location = new Point(10, 10), AutoSize = true, Font = new Font("Segoe UI", 11, FontStyle.Bold) };
                Label lblSubtotal = new Label { Text = $"Rp {item.subtotal:N0}", Location = new Point(10, 38), AutoSize = true, ForeColor = Color.DarkOrange, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
                Label lblQty = new Label { Text = item.qty.ToString(), Location = new Point(235, 25), Size = new Size(30, 20), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 10, FontStyle.Bold) };

                Button btnMin = new Button { Text = "-", Location = new Point(200, 20), Size = new Size(30, 30), BackColor = Color.Crimson, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 12, FontStyle.Bold), Cursor = Cursors.Hand };
                btnMin.FlatAppearance.BorderSize = 0;
                btnMin.Click += (s, e) =>
                {
                    if (item.qty > 1)
                    {
                        item.qty -= 1;
                        item.subtotal = item.qty * item.harga;
                    }
                    else
                    {
                        keranjangBelanja.Remove(item);
                    }
                    RefreshKeranjang();
                };

                Button btnPlus = new Button { Text = "+", Location = new Point(270, 20), Size = new Size(30, 30), BackColor = Color.MediumSeaGreen, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 12, FontStyle.Bold), Cursor = Cursors.Hand };
                btnPlus.FlatAppearance.BorderSize = 0;
                btnPlus.Click += (s, e) =>
                {
                    var produkAsli = produkController.GetAllProduk().Find(p => p.id_produk == item.id_produk);
                    if (produkAsli != null)
                    {
                        if (item.qty + 1 > produkAsli.stok)
                        {
                            MessageBox.Show("Stok habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        item.qty += 1;
                        item.subtotal = item.qty * item.harga;
                        RefreshKeranjang();
                    }
                };

                pnlItem.Controls.Add(lblNama);
                pnlItem.Controls.Add(lblSubtotal);
                pnlItem.Controls.Add(btnMin);
                pnlItem.Controls.Add(lblQty);
                pnlItem.Controls.Add(btnPlus);

                flpKeranjang.Controls.Add(pnlItem);
            }

            lblSubTotal.Text = $"Rp {totalBelanja:N0}";
            cmbMetodeBayar_SelectedIndexChanged(null, null);
        }

        // =======================================================
        // MENGGAMBAR KARTU PRODUK (Desain Kustom Anda)
        // =======================================================
        private void LoadDataProduk()
        {
            try
            {
                flpProduk.Controls.Clear();
                List<Produk> listProduk = produkController.GetAllProduk();

                foreach (var produk in listProduk)
                {
                    Panel card = new Panel
                    {
                        Size = new Size(373, 172),
                        Margin = new Padding(3),
                        BackgroundImage = Properties.Resources.CardKerTran,
                        BackgroundImageLayout = ImageLayout.Zoom,
                    };

                    Label lblNama = new Label
                    {
                        Text = produk.nama_produk,
                        Location = new Point(25, 31),
                        Size = new Size(262, 36),
                        BackColor = Color.Transparent,
                        Font = new Font("Times New Roman", 16, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label lblHarga = new Label
                    {
                        Text = $"Rp {produk.harga:N0}",
                        Location = new Point(27, 73),
                        Size = new Size(141, 32),
                        BackColor = Color.Transparent,
                        Font = new Font("Times New Roman", 14, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label lblStok = new Label
                    {
                        Text = $"Stok: {produk.stok}",
                        Location = new Point(23, 115),
                        Size = new Size(108, 26),
                        BackColor = Color.Transparent,
                        Font = new Font("Times New Roman", 12, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Button btnAdd = new Button
                    {
                        Text = "+",
                        Location = new Point(303, 111),
                        Size = new Size(44, 41),
                        BackColor = Color.Transparent,
                        Font = new Font("Times New Roman", 14, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Cursor = Cursors.Hand
                    };
                    btnAdd.FlatAppearance.BorderSize = 0;

                    btnAdd.Click += (s, ev) =>
                    {
                        TambahKeKeranjang(produk);
                    };

                    card.Controls.Add(lblNama);
                    card.Controls.Add(lblHarga);
                    card.Controls.Add(lblStok);
                    card.Controls.Add(btnAdd);

                    flpProduk.Controls.Add(card);
                }
            }
            catch (Exception ex) { MessageBox.Show("Gagal memuat produk: " + ex.Message); }
        }

        // =======================================================
        // FUNGSI MENAMBAH BARANG CERDAS
        // =======================================================
        private void TambahKeKeranjang(Produk produk)
        {
            var item = keranjangBelanja.Find(x => x.id_produk == produk.id_produk);

            if (item != null)
            {
                if (item.qty + 1 > produk.stok)
                {
                    MessageBox.Show("Stok tidak mencukupi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.qty += 1;
                item.subtotal = item.qty * item.harga;
            }
            else
            {
                if (produk.stok < 1)
                {
                    MessageBox.Show("Stok produk habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                keranjangBelanja.Add(new DetailTransaksi
                {
                    id_produk = produk.id_produk,
                    nama_produk = produk.nama_produk,
                    harga = produk.harga,
                    qty = 1,
                    subtotal = produk.harga
                });
            }

            RefreshKeranjang();
        }

        private void txtUangDiterima_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUangDiterima.Text))
            {
                lblKembalian.Text = "Rp 0";
                lblKembalian.ForeColor = Color.Black;
                return;
            }

            if (int.TryParse(txtUangDiterima.Text, out int uangDiterima))
            {
                int kembalian = uangDiterima - totalBelanja;
                if (kembalian < 0)
                {
                    lblKembalian.Text = "Uang Kurang!";
                    lblKembalian.ForeColor = Color.Red;
                }
                else
                {
                    lblKembalian.Text = $"Rp {kembalian:N0}";
                    lblKembalian.ForeColor = Color.MediumSeaGreen;
                }
            }
        }

        // =======================================================
        // CHECKOUT
        // =======================================================
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (keranjangBelanja.Count == 0) return;
            if (!int.TryParse(txtUangDiterima.Text, out int uangDiterima) || uangDiterima < totalBelanja)
            {
                MessageBox.Show("Nominal uang tidak valid atau kurang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string metodeTerpilih = cmbMetodeBayar.SelectedItem.ToString().ToLower();
                int idKasirAktif = APPSession.CurrentUser != null ? APPSession.CurrentUser.id_user : 1;

                int idTrx = transaksiController.CreateTransaksi(new Transaksi
                {
                    id_kasir = idKasirAktif,
                    total_harga = totalBelanja,
                    jumlah_bayar = uangDiterima,
                    metode_bayar = metodeTerpilih,
                    status_transaksi = "selesai"
                });

                if (idTrx > 0)
                {
                    foreach (var item in keranjangBelanja)
                    {
                        item.id_transaksi = idTrx;
                        transaksiController.AddDetail(item);
                    }

                    MessageBox.Show($"Transaksi Berhasil!\nMetode: {metodeTerpilih.ToUpper()}\nKembalian: Rp {uangDiterima - totalBelanja:N0}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    keranjangBelanja.Clear();
                    txtUangDiterima.Clear();
                    LoadDataProduk();
                    RefreshKeranjang();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error Sistem Checkout", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // =======================================================
        // EVENT KOSONG (Biarkan saja agar UI Designer tidak error)
        // =======================================================
        private void btDashboar_Click(object sender, EventArgs e) { }
        private void btRiwayatTransaksi_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void l_Click(object sender, EventArgs e) { }
        private void panel8_Paint(object sender, PaintEventArgs e) { }
        private void lblHarga_Click(object sender, EventArgs e) { }
        private void lblNamaProduk_Click(object sender, EventArgs e) { }
        private void lblPlus_Click(object sender, EventArgs e) { }
        private void lblQty_Click(object sender, EventArgs e) { }
        private void btnMinus_Click(object sender, EventArgs e) { }
        private void lblSubTotal_Click(object sender, EventArgs e) { }
    }
}
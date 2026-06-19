using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;
using FinalProjek.Helper;
using System.Drawing.Printing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProjek.View.Kasir_View
{
    public partial class KasirDashboardView : Form
    {
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

        private void KasirDashboardView_Load(object sender, EventArgs e)
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
        private void RefreshKeranjang()
        {
            flpKeranjang.Controls.Clear();
            totalBelanja = 0;

            int lebarKartu = 350; 

            foreach (var item in keranjangBelanja)
            {
                totalBelanja += item.subtotal;

                Panel pnlItem = new Panel
                {
                    Width = lebarKartu,
                    Height = 70,
                    Margin = new Padding(5, 5, 5, 8),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblNama = new Label
                {
                    Text = item.nama_produk,
                    Location = new Point(10, 8),
                    Size = new Size(200, 25),
                    Font = new Font("Times New Roman", 10, FontStyle.Bold)
                };

                Label lblSubtotal = new Label
                {
                    Text = $"Rp {item.subtotal:N0}",
                    Location = new Point(10, 38),
                    Size = new Size(200, 25),
                    ForeColor = Color.DarkOrange,
                    Font = new Font("Times New Roman", 10, FontStyle.Bold)
                };

                Button btnMin = new Button
                {
                    Text = "−",
                    Location = new Point(250, 18),
                    Size = new Size(28, 28),
                    BackColor = Color.Crimson,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Times New Roman", 12, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
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

                Label lblQty = new Label
                {
                    Text = item.qty.ToString(),
                    Location = new Point(285, 18),
                    Size = new Size(28, 28),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Times New Roman", 12, FontStyle.Bold)
                };

                Button btnPlus = new Button
                {
                    Text = "+",
                    Location = new Point(318, 18),
                    Size = new Size(28, 28),
                    BackColor = Color.MediumSeaGreen,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Times New Roman", 12, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnPlus.FlatAppearance.BorderSize = 0;
                btnPlus.Click += (s, e) =>
                {
                    var produkAsli = produkController.GetAllProduk().Find(p => p.id_produk == item.id_produk);
                    if (produkAsli != null && item.qty + 1 <= produkAsli.stok)
                    {
                        item.qty += 1;
                        item.subtotal = item.qty * item.harga;
                        RefreshKeranjang();
                    }
                    else
                    {
                        MessageBox.Show("Stok habis!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                pnlItem.Controls.Add(lblNama);
                pnlItem.Controls.Add(lblSubtotal);
                pnlItem.Controls.Add(btnMin);
                pnlItem.Controls.Add(lblQty);
                pnlItem.Controls.Add(btnPlus);

                flpKeranjang.Controls.Add(pnlItem);
            }

            // Update total
            lblSubTotal.Text = $"Rp {totalBelanja:N0}";
            txtUangDiterima_TextChanged(null, null);
        }

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
                        Size = new Size(230, 130),
                        Margin = new Padding(5),
                        BackColor = Color.White,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    Label lblNama = new Label
                    {
                        Text = produk.nama_produk,
                        Location = new Point(10, 10),
                        Size = new Size(200, 40),
                        AutoEllipsis = true,
                        Font = new Font("Times New Roman", 11, FontStyle.Bold)
                    };

                    Label lblHarga = new Label
                    {
                        Text = $"Rp {produk.harga:N0}",
                        Location = new Point(10, 60),
                        AutoSize = true,
                        ForeColor = Color.FromArgb(100, 60, 20),
                        Font = new Font("Times New Roman", 11, FontStyle.Bold)
                    };

                    Label lblStok = new Label
                    {
                        Text = $"Stok: {produk.stok}",
                        Location = new Point(10, 90),
                        AutoSize = true,
                        Font = new Font("Times New Roman", 9, FontStyle.Regular)
                    };

                    Button btnAdd = new Button
                    {
                        Text = "+",
                        Location = new Point(175, 80),
                        Size = new Size(45, 40),
                        BackColor = Color.DarkOrange,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Times New Roman", 14, FontStyle.Bold),
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
                int idUserAktif = APPSession.CurrentUser != null ? APPSession.CurrentUser.id_user : 1;

                int idTrx = transaksiController.CreateTransaksi(new Transaksi
                {
                    id_user = idUserAktif,
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
        private void FormTransaksi_Load(object sender, EventArgs e) { } 
        private void label5_Click(object sender, EventArgs e) { }
        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            btnCheckout_Click(sender, e);
        }

        private void btRiwayatTransaksi_Click_1(object sender, EventArgs e)
        {
            V_RiwayatSaya frmRiwayat = new V_RiwayatSaya();
            frmRiwayat.Show();
            this.Hide();
        }

        private void btDaftarProduk_Click(object sender, EventArgs e)
        {
            V_DaftarProduk formDaftarProduk = new V_DaftarProduk();
            formDaftarProduk.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.FormClosed += (s, args) => this.Close();
            frmLogin.Show();
            this.Hide();
        }
    }
}
using FinalProjek.Controler;
using FinalProjek.Model;
using FinalProjek.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_MonitorStok : Form
    {
        private ProdukController produkController;

        public V_MonitorStok()
        {
            InitializeComponent();
            produkController = new ProdukController();
            LoadDataStok();
        }

        public Panel CreateProductPanel(Produk produk)
        {
            Panel panel = new Panel
            {
                Size = new Size(1053, 92),
                Margin = new Padding(3),
                BackgroundImage = Properties.Resources.CardMonitorStokdalam,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            Label namaProduk = new Label
            {
                Text = produk.nama_produk,
                Location = new Point(24, 30),
                Size = new Size(454, 32),
                BackColor = Color.Transparent,
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };

            Label stokProduk = new Label
            {
                Text = produk.stok.ToString(),
                Location = new Point(535, 29),
                Size = new Size(49, 32),
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(100, 60, 20),
                Font = new Font("Times New Roman", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Button buttonRestok = new Button
            {
                Location = new Point(780, 25),
                Size = new Size(125, 43),
                Font = new Font("Times New Roman", 12, FontStyle.Regular),
                BackColor = Color.DarkOrange,
                ForeColor = Color.White,
                Text = "Restok",
                Cursor = Cursors.Hand
            };

            buttonRestok.Click += (sender, e) => ProsesUpdateStok(produk, "tambah");

            Button buttonKurangi = new Button
            {
                Location = new Point(911, 25),
                Size = new Size(125, 43),
                Font = new Font("Times New Roman", 12, FontStyle.Regular),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Text = "Kurangi",
                Cursor = Cursors.Hand
            };
            buttonKurangi.Click += (sender, e) => ProsesUpdateStok(produk, "kurang");
            panel.Controls.Add(namaProduk);
            panel.Controls.Add(stokProduk);
            panel.Controls.Add(buttonRestok);
            panel.Controls.Add(buttonKurangi);

            return panel;
        }

        public void LoadDataStok()
        {
            try
            {
                flpMonitorStok.Controls.Clear();

                var produks = produkController.GetAllProduk();

                foreach (Produk produk in produks)
                {
                    Panel rowPanel = CreateProductPanel(produk);
                    flpMonitorStok.Controls.Add(rowPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data stok: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProsesUpdateStok(Produk produk, string aksi)
        {
            Form prompt = new Form()
            {
                Width = 550,              
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = aksi == "tambah" ? "Restok: " + produk.nama_produk : "Kurangi: " + produk.nama_produk,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Width = 500,
                Height = 25,
                Text = "Masukkan jumlah yang ingin di" + aksi + ":",
                Font = new Font("Segoe UI", 10)
            };

            NumericUpDown inputAngka = new NumericUpDown()
            {
                Left = 20,
                Top = 55,
                Width = 500,
                Maximum = 10000,
                Minimum = 1,
                Value = 1,
                Font = new Font("Segoe UI", 10)
            };

            FlowLayoutPanel flowButtons = new FlowLayoutPanel()
            {
                Left = 20,
                Top = 100,
                Width = 500,
                Height = 50,
                FlowDirection = FlowDirection.RightToLeft, 
                AutoSize = false
            };

            Button btnSimpan = new Button()
            {
                Text = "Simpan",
                Width = 90,
                Height = 35,
                DialogResult = DialogResult.OK,
                BackColor = Color.Chocolate,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            Button btnBatal = new Button()
            {
                Text = "Batal",
                Width = 90,
                Height = 35,
                DialogResult = DialogResult.Cancel,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            flowButtons.Controls.Add(btnSimpan);
            flowButtons.Controls.Add(btnBatal);

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputAngka);
            prompt.Controls.Add(flowButtons);

            prompt.AcceptButton = btnSimpan;
            prompt.CancelButton = btnBatal;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                int nilaiInput = (int)inputAngka.Value;

                if (aksi == "kurang")
                {
                    if (produk.stok - nilaiInput < 0)
                    {
                        MessageBox.Show("Stok tidak bisa kurang dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    nilaiInput = nilaiInput * -1;
                }

                bool sukses = produkController.UpdateStok(produk.id_produk, nilaiInput);
                if (sukses)
                {
                    MessageBox.Show("Stok berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataStok();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui stok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            prompt.Dispose();
        }

        private void btDashboar_Click(object sender, EventArgs e)
        {
            IProduk pc = new ProdukController();
            AdminDashboardView frm = new AdminDashboardView(pc);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btProduk_Click(object sender, EventArgs e)
        {
            V_Produk frm = new V_Produk();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btKategori_Click(object sender, EventArgs e)
        {
            V_Kategori frm = new V_Kategori();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btMonitorStok_Click(object sender, EventArgs e)
        {
            LoadDataStok();
        }

        private void btRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            V_RiwayatTransaksi frm = new V_RiwayatTransaksi();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btKelolaAkunUser_Click(object sender, EventArgs e)
        {
            V_KelolaAkunUserr frm = new V_KelolaAkunUserr();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btRestok_Click(object sender, EventArgs e)
        {

        }

        private void btKurangi_Click(object sender, EventArgs e)
        {

        }

        private void lbStok_Click(object sender, EventArgs e)
        {

        }

        private void lbNamaProduk_Click(object sender, EventArgs e)
        {

        }
    }
}
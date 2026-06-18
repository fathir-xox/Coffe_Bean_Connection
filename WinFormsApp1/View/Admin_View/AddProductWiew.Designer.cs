namespace FinalProjek.View.Admin_View
{
    partial class AddProductWiew
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox tbNamaProduk;
        private TextBox tbHargaProduk;
        private TextBox tbStokProduk;
        private ComboBox cbIdKategori;
        private RichTextBox rtbDeskripsi;
        private Button btnTambahGambar;
        private Button btnSimpan;
        private Panel panel1;
        private PictureBox pbGambar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbNamaProduk = new TextBox();
            tbHargaProduk = new TextBox();
            tbStokProduk = new TextBox();
            cbIdKategori = new ComboBox();
            rtbDeskripsi = new RichTextBox();
            btnTambahGambar = new Button();
            btnSimpan = new Button();
            panel1 = new Panel();
            pbGambar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambar).BeginInit();
            SuspendLayout();

            // panel1
            panel1.BackgroundImage = Properties.Resources.VTambahProduk;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(pbGambar);
            panel1.Controls.Add(btnTambahGambar);
            panel1.Controls.Add(rtbDeskripsi);
            panel1.Controls.Add(cbIdKategori);
            panel1.Controls.Add(tbStokProduk);
            panel1.Controls.Add(tbHargaProduk);
            panel1.Controls.Add(tbNamaProduk);
            panel1.Controls.Add(btnSimpan);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 719);
            panel1.TabIndex = 0;

            // tbNamaProduk
            tbNamaProduk.Location = new Point(500, 180);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(300, 30);
            tbNamaProduk.TabIndex = 0;
            tbNamaProduk.Text = "Nama Produk";

            // tbHargaProduk
            tbHargaProduk.Location = new Point(500, 240);
            tbHargaProduk.Name = "tbHargaProduk";
            tbHargaProduk.Size = new Size(300, 30);
            tbHargaProduk.TabIndex = 1;
            tbHargaProduk.Text = "Harga Produk";

            // tbStokProduk
            tbStokProduk.Location = new Point(500, 300);
            tbStokProduk.Name = "tbStokProduk";
            tbStokProduk.Size = new Size(300, 30);
            tbStokProduk.TabIndex = 2;
            tbStokProduk.Text = "Stok Produk";

            // cbIdKategori
            cbIdKategori.Location = new Point(500, 360);
            cbIdKategori.Name = "cbIdKategori";
            cbIdKategori.Size = new Size(300, 30);
            cbIdKategori.TabIndex = 3;
            cbIdKategori.Text = "Id Kategori";
            cbIdKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            // rtbDeskripsi
            rtbDeskripsi.Location = new Point(500, 420);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(300, 100);
            rtbDeskripsi.TabIndex = 4;
            rtbDeskripsi.Text = "Deskripsi Produk";

            // btnTambahGambar
            btnTambahGambar.BackColor = Color.FromArgb(100, 60, 20);
            btnTambahGambar.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            btnTambahGambar.ForeColor = Color.White;
            btnTambahGambar.Location = new Point(500, 540);
            btnTambahGambar.Name = "btnTambahGambar";
            btnTambahGambar.Size = new Size(140, 35);
            btnTambahGambar.TabIndex = 5;
            btnTambahGambar.Text = "Tambah Gambar";
            btnTambahGambar.UseVisualStyleBackColor = false;

            // pbGambar
            pbGambar.Location = new Point(830, 180);
            pbGambar.Name = "pbGambar";
            pbGambar.Size = new Size(200, 200);
            pbGambar.TabIndex = 6;
            pbGambar.TabStop = false;
            pbGambar.BackColor = Color.LightGray;
            pbGambar.SizeMode = PictureBoxSizeMode.Zoom;

            // btnSimpan
            btnSimpan.BackColor = Color.FromArgb(100, 60, 20);
            btnSimpan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.OldLace;
            btnSimpan.Location = new Point(500, 600);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(300, 46);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;

            // AddProductWiew
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Name = "AddProductWiew";
            Text = "Tambah Produk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambar).EndInit();
            ResumeLayout(false);
        }
    }
}
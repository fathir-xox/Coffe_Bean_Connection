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
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambar).BeginInit();
            SuspendLayout();
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Location = new Point(761, 92);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(279, 31);
            tbNamaProduk.TabIndex = 0;
            // 
            // tbHargaProduk
            // 
            tbHargaProduk.Location = new Point(759, 186);
            tbHargaProduk.Name = "tbHargaProduk";
            tbHargaProduk.Size = new Size(282, 31);
            tbHargaProduk.TabIndex = 1;
            // 
            // tbStokProduk
            // 
            tbStokProduk.Location = new Point(761, 279);
            tbStokProduk.Name = "tbStokProduk";
            tbStokProduk.Size = new Size(280, 31);
            tbStokProduk.TabIndex = 2;
            // 
            // cbIdKategori
            // 
            cbIdKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIdKategori.Location = new Point(759, 370);
            cbIdKategori.Name = "cbIdKategori";
            cbIdKategori.Size = new Size(281, 33);
            cbIdKategori.TabIndex = 3;
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(759, 463);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.Size = new Size(282, 69);
            rtbDeskripsi.TabIndex = 4;
            rtbDeskripsi.Text = "";
            // 
            // btnTambahGambar
            // 
            btnTambahGambar.BackColor = Color.FromArgb(100, 60, 20);
            btnTambahGambar.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahGambar.ForeColor = Color.White;
            btnTambahGambar.Location = new Point(308, 542);
            btnTambahGambar.Name = "btnTambahGambar";
            btnTambahGambar.Size = new Size(293, 44);
            btnTambahGambar.TabIndex = 5;
            btnTambahGambar.Text = "Tambah Gambar";
            btnTambahGambar.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(100, 60, 20);
            btnSimpan.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.OldLace;
            btnSimpan.Location = new Point(754, 576);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(295, 46);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Ttambahproduknew;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbGambar);
            panel1.Controls.Add(btnTambahGambar);
            panel1.Controls.Add(rtbDeskripsi);
            panel1.Controls.Add(cbIdKategori);
            panel1.Controls.Add(tbStokProduk);
            panel1.Controls.Add(tbHargaProduk);
            panel1.Controls.Add(tbNamaProduk);
            panel1.Controls.Add(btnSimpan);
            panel1.Location = new Point(-40, -28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 719);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pbGambar
            // 
            pbGambar.BackColor = Color.Transparent;
            pbGambar.Location = new Point(247, 103);
            pbGambar.Name = "pbGambar";
            pbGambar.Size = new Size(413, 386);
            pbGambar.SizeMode = PictureBoxSizeMode.Zoom;
            pbGambar.TabIndex = 6;
            pbGambar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(754, 336);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 8;
            label1.Text = "Kategori";
            // 
            // AddProductWiew
            // 
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

        private Label label1;
    }
}
namespace FinalProjek.View.Admin_View
{
    partial class AddProductWiew
    {
        
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            btTambahGambar = new Button();
            tbNamaProduk = new TextBox();
            tbHargaProduk = new TextBox();
            tbStokProduk = new TextBox();
            btSIMPAN = new Button();
            gambarProduk = new PictureBox();
            rtbDeskripsiProduk = new RichTextBox();
            tbKategoriProduk = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gambarProduk).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btTambahGambar
            // 
            btTambahGambar.BackColor = Color.OldLace;
            btTambahGambar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTambahGambar.ForeColor = Color.FromArgb(100, 60, 20);
            btTambahGambar.Location = new Point(353, 529);
            btTambahGambar.Name = "btTambahGambar";
            btTambahGambar.Size = new Size(302, 49);
            btTambahGambar.TabIndex = 0;
            btTambahGambar.Text = "Tambah Gambar";
            btTambahGambar.UseVisualStyleBackColor = false;
            btTambahGambar.Click += btTambahGambar_Click;
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Location = new Point(799, 91);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(282, 31);
            tbNamaProduk.TabIndex = 1;
            // 
            // tbHargaProduk
            // 
            tbHargaProduk.Location = new Point(801, 182);
            tbHargaProduk.Name = "tbHargaProduk";
            tbHargaProduk.Size = new Size(280, 31);
            tbHargaProduk.TabIndex = 2;
            // 
            // tbStokProduk
            // 
            tbStokProduk.Location = new Point(801, 274);
            tbStokProduk.Name = "tbStokProduk";
            tbStokProduk.Size = new Size(280, 31);
            tbStokProduk.TabIndex = 3;
            // 
            // btSIMPAN
            // 
            btSIMPAN.BackColor = Color.FromArgb(100, 60, 20);
            btSIMPAN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSIMPAN.ForeColor = Color.OldLace;
            btSIMPAN.Location = new Point(801, 565);
            btSIMPAN.Name = "btSIMPAN";
            btSIMPAN.Size = new Size(280, 46);
            btSIMPAN.TabIndex = 4;
            btSIMPAN.Text = "SIMPAN";
            btSIMPAN.UseVisualStyleBackColor = false;
            btSIMPAN.Click += btSIMPAN_Click;
            // 
            // gambarProduk
            // 
            gambarProduk.BackColor = Color.Transparent;
            gambarProduk.BackgroundImageLayout = ImageLayout.Stretch;
            gambarProduk.Location = new Point(308, 108);
            gambarProduk.Name = "gambarProduk";
            gambarProduk.Size = new Size(381, 367);
            gambarProduk.TabIndex = 8;
            gambarProduk.TabStop = false;
            gambarProduk.Click += gambarProduk_Click;
            // 
            // rtbDeskripsiProduk
            // 
            rtbDeskripsiProduk.Location = new Point(799, 454);
            rtbDeskripsiProduk.Name = "rtbDeskripsiProduk";
            rtbDeskripsiProduk.Size = new Size(282, 71);
            rtbDeskripsiProduk.TabIndex = 11;
            rtbDeskripsiProduk.Text = "";
            // 
            // tbKategoriProduk
            // 
            tbKategoriProduk.Location = new Point(801, 365);
            tbKategoriProduk.Name = "tbKategoriProduk";
            tbKategoriProduk.Size = new Size(280, 31);
            tbKategoriProduk.TabIndex = 12;
            tbKategoriProduk.TextChanged += tbKategoriProduk_TextChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VTambahProduk;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tbKategoriProduk);
            panel1.Controls.Add(rtbDeskripsiProduk);
            panel1.Controls.Add(gambarProduk);
            panel1.Controls.Add(btSIMPAN);
            panel1.Controls.Add(tbStokProduk);
            panel1.Controls.Add(tbHargaProduk);
            panel1.Controls.Add(tbNamaProduk);
            panel1.Controls.Add(btTambahGambar);
            panel1.Location = new Point(-77, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1418, 706);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // AddProductWiew
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.VTambahProduk;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Name = "AddProductWiew";
            Text = "AddProductWiew";
            ((System.ComponentModel.ISupportInitialize)gambarProduk).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btSIMPAN_Click(object sender, EventArgs e)
        {
            // Forward to the implemented handler in the other partial class
            BtSIMPAN_Click(sender, e);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btTambahGambar;
        private TextBox tbNamaProduk;
        private TextBox tbHargaProduk;
        private TextBox tbStokProduk;
        private Button btSIMPAN;
        private PictureBox gambarProduk;
        private RichTextBox rtbDeskripsiProduk;
        private TextBox tbKategoriProduk;
        private Panel panel1;
    }
}
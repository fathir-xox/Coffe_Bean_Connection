namespace FinalProjek.View.Admin_View
{
    partial class AddProductWiew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            btTambahGambar = new Button();
            tbNamaProduk = new TextBox();
            tbHargaProduk = new TextBox();
            tbStokProduk = new TextBox();
            btSIMPAN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gambarProduk = new PictureBox();
            label4 = new Label();
            rtbDeskripsiProduk = new RichTextBox();
            label5 = new Label();
            tbKategoriProduk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gambarProduk).BeginInit();
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
            btTambahGambar.Location = new Point(319, 493);
            btTambahGambar.Name = "btTambahGambar";
            btTambahGambar.Size = new Size(226, 49);
            btTambahGambar.TabIndex = 0;
            btTambahGambar.Text = "Tambah Gambar";
            btTambahGambar.UseVisualStyleBackColor = false;
            btTambahGambar.Click += btTambahGambar_Click;
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Location = new Point(690, 130);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(290, 31);
            tbNamaProduk.TabIndex = 1;
            // 
            // tbHargaProduk
            // 
            tbHargaProduk.Location = new Point(690, 197);
            tbHargaProduk.Name = "tbHargaProduk";
            tbHargaProduk.Size = new Size(290, 31);
            tbHargaProduk.TabIndex = 2;
            // 
            // tbStokProduk
            // 
            tbStokProduk.Location = new Point(690, 264);
            tbStokProduk.Name = "tbStokProduk";
            tbStokProduk.Size = new Size(290, 31);
            tbStokProduk.TabIndex = 3;
            // 
            // btSIMPAN
            // 
            btSIMPAN.BackColor = Color.FromArgb(100, 60, 20);
            btSIMPAN.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSIMPAN.ForeColor = Color.OldLace;
            btSIMPAN.Location = new Point(763, 496);
            btSIMPAN.Name = "btSIMPAN";
            btSIMPAN.Size = new Size(140, 46);
            btSIMPAN.TabIndex = 4;
            btSIMPAN.Text = "SIMPAN";
            btSIMPAN.UseVisualStyleBackColor = false;
            btSIMPAN.Click += btSIMPAN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(695, 102);
            label1.Name = "label1";
            label1.Size = new Size(117, 22);
            label1.TabIndex = 5;
            label1.Text = "Nama Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(696, 172);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 6;
            label2.Text = "Harga Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 60, 20);
            label3.Location = new Point(696, 239);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 7;
            label3.Text = "Stok Produk";
            // 
            // gambarProduk
            // 
            gambarProduk.BackColor = Color.Transparent;
            gambarProduk.BackgroundImageLayout = ImageLayout.Stretch;
            gambarProduk.Location = new Point(242, 102);
            gambarProduk.Name = "gambarProduk";
            gambarProduk.Size = new Size(381, 367);
            gambarProduk.TabIndex = 8;
            gambarProduk.TabStop = false;
            gambarProduk.Click += gambarProduk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 60, 20);
            label4.Location = new Point(696, 371);
            label4.Name = "label4";
            label4.Size = new Size(148, 22);
            label4.TabIndex = 10;
            label4.Text = "Deskripsi Produk";
            // 
            // rtbDeskripsiProduk
            // 
            rtbDeskripsiProduk.Location = new Point(690, 396);
            rtbDeskripsiProduk.Name = "rtbDeskripsiProduk";
            rtbDeskripsiProduk.Size = new Size(290, 85);
            rtbDeskripsiProduk.TabIndex = 11;
            rtbDeskripsiProduk.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(100, 60, 20);
            label5.Location = new Point(697, 305);
            label5.Name = "label5";
            label5.Size = new Size(140, 22);
            label5.TabIndex = 13;
            label5.Text = "Kategori Produk";
            // 
            // tbKategoriProduk
            // 
            tbKategoriProduk.Location = new Point(690, 330);
            tbKategoriProduk.Name = "tbKategoriProduk";
            tbKategoriProduk.Size = new Size(290, 31);
            tbKategoriProduk.TabIndex = 12;
            tbKategoriProduk.TextChanged += tbKategoriProduk_TextChanged;
            // 
            // AddProductWiew
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(label5);
            Controls.Add(tbKategoriProduk);
            Controls.Add(rtbDeskripsiProduk);
            Controls.Add(label4);
            Controls.Add(gambarProduk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btSIMPAN);
            Controls.Add(tbStokProduk);
            Controls.Add(tbHargaProduk);
            Controls.Add(tbNamaProduk);
            Controls.Add(btTambahGambar);
            Name = "AddProductWiew";
            Text = "AddProductWiew";
            ((System.ComponentModel.ISupportInitialize)gambarProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox gambarProduk;
        private Label label4;
        private RichTextBox rtbDeskripsiProduk;
        private Label label5;
        private TextBox tbKategoriProduk;
    }
}
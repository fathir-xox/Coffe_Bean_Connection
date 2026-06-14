namespace FinalProjek.View.Kasir_View
{
    partial class KasirDashboardView
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
            panel1 = new Panel();
            flpProduk = new FlowLayoutPanel();
            panel8 = new Panel();
            button1 = new Button();
            Stok = new Label();
            NamaProduk = new Label();
            HargaProduk = new Label();
            panel2 = new Panel();
            flpKeranjang = new FlowLayoutPanel();
            panel3 = new Panel();
            lblQty = new Label();
            lblHarga = new Label();
            lblNamaProduk = new Label();
            lblSubTotal = new Label();
            btnMinus = new Button();
            lblPlus = new Button();
            btnCheckout = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblKembalian = new Label();
            txtUangDiterima = new TextBox();
            cmbMetodeBayar = new ComboBox();
            btLogout = new Button();
            btDaftarProduk = new Button();
            btRiwayatTransaksi = new Button();
            btTransaksi = new Button();
            panel1.SuspendLayout();
            flpProduk.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            flpKeranjang.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VTransaksi;
            panel1.Controls.Add(flpProduk);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(btDaftarProduk);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btTransaksi);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 1026);
            panel1.TabIndex = 0;
            // 
            // flpProduk
            // 
            flpProduk.AutoScroll = true;
            flpProduk.Controls.Add(panel8);
            flpProduk.Location = new Point(357, 170);
            flpProduk.Name = "flpProduk";
            flpProduk.Size = new Size(1054, 825);
            flpProduk.TabIndex = 13;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.CardKerTran;
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Controls.Add(button1);
            panel8.Controls.Add(Stok);
            panel8.Controls.Add(NamaProduk);
            panel8.Controls.Add(HargaProduk);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(373, 172);
            panel8.TabIndex = 6;
            panel8.Paint += panel8_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(303, 111);
            button1.Name = "button1";
            button1.Size = new Size(44, 41);
            button1.TabIndex = 6;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // Stok
            // 
            Stok.AutoSize = true;
            Stok.BackColor = Color.Transparent;
            Stok.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stok.ForeColor = Color.FromArgb(100, 60, 20);
            Stok.Location = new Point(23, 115);
            Stok.Name = "Stok";
            Stok.RightToLeft = RightToLeft.Yes;
            Stok.Size = new Size(108, 26);
            Stok.TabIndex = 5;
            Stok.Text = "Stok : 20 ";
            // 
            // NamaProduk
            // 
            NamaProduk.AutoSize = true;
            NamaProduk.BackColor = Color.Transparent;
            NamaProduk.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaProduk.ForeColor = Color.Black;
            NamaProduk.Location = new Point(25, 31);
            NamaProduk.Name = "NamaProduk";
            NamaProduk.Size = new Size(262, 36);
            NamaProduk.TabIndex = 2;
            NamaProduk.Text = "Biji Kopi Arabika";
            // 
            // HargaProduk
            // 
            HargaProduk.AutoSize = true;
            HargaProduk.BackColor = Color.Transparent;
            HargaProduk.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HargaProduk.ForeColor = Color.FromArgb(100, 60, 20);
            HargaProduk.Location = new Point(27, 73);
            HargaProduk.Name = "HargaProduk";
            HargaProduk.Size = new Size(141, 32);
            HargaProduk.TabIndex = 4;
            HargaProduk.Text = "Rp. 55.000";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.CardTransaksi;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(flpKeranjang);
            panel2.Controls.Add(btnCheckout);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblKembalian);
            panel2.Controls.Add(txtUangDiterima);
            panel2.Controls.Add(cmbMetodeBayar);
            panel2.Location = new Point(1432, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 783);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // flpKeranjang
            // 
            flpKeranjang.Controls.Add(panel3);
            flpKeranjang.Location = new Point(11, 73);
            flpKeranjang.Name = "flpKeranjang";
            flpKeranjang.Size = new Size(422, 239);
            flpKeranjang.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.CardKeranjang;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(lblQty);
            panel3.Controls.Add(lblHarga);
            panel3.Controls.Add(lblNamaProduk);
            panel3.Controls.Add(lblSubTotal);
            panel3.Controls.Add(btnMinus);
            panel3.Controls.Add(lblPlus);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 87);
            panel3.TabIndex = 0;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.BackColor = Color.Transparent;
            lblQty.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.ForeColor = Color.FromArgb(100, 60, 20);
            lblQty.Location = new Point(232, 31);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(24, 26);
            lblQty.TabIndex = 13;
            lblQty.Text = "3";
            lblQty.Click += lblQty_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.Transparent;
            lblHarga.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.FromArgb(100, 60, 20);
            lblHarga.Location = new Point(13, 44);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(99, 23);
            lblHarga.TabIndex = 12;
            lblHarga.Text = "Rp. 55.000";
            lblHarga.Click += lblHarga_Click;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.Transparent;
            lblNamaProduk.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(7, 17);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(180, 25);
            lblNamaProduk.TabIndex = 11;
            lblNamaProduk.Text = "Biji Kopi Arabika";
            lblNamaProduk.Click += lblNamaProduk_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(311, 31);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(94, 23);
            lblSubTotal.TabIndex = 10;
            lblSubTotal.Text = "Rp 12.000";
            lblSubTotal.Click += lblSubTotal_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.DarkOrange;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.ForeColor = Color.Transparent;
            btnMinus.Location = new Point(262, 17);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(39, 53);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblPlus
            // 
            lblPlus.BackColor = Color.DarkOrange;
            lblPlus.FlatStyle = FlatStyle.Flat;
            lblPlus.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlus.ForeColor = Color.Transparent;
            lblPlus.Location = new Point(186, 16);
            lblPlus.Name = "lblPlus";
            lblPlus.Size = new Size(39, 53);
            lblPlus.TabIndex = 7;
            lblPlus.Text = "+";
            lblPlus.UseVisualStyleBackColor = false;
            lblPlus.Click += lblPlus_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.OldLace;
            btnCheckout.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.Location = new Point(37, 689);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(372, 48);
            btnCheckout.TabIndex = 8;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(265, 350);
            label5.Name = "label5";
            label5.Size = new Size(134, 32);
            label5.TabIndex = 7;
            label5.Text = "Rp 12.000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 350);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 6;
            label4.Text = "TOTAL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 406);
            label3.Name = "label3";
            label3.Size = new Size(212, 27);
            label3.TabIndex = 5;
            label3.Text = "Metode Pembayaran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 502);
            label2.Name = "label2";
            label2.Size = new Size(152, 27);
            label2.TabIndex = 4;
            label2.Text = "Uang Diterima";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 628);
            label1.Name = "label1";
            label1.Size = new Size(116, 27);
            label1.TabIndex = 3;
            label1.Text = "Kembalian";
            label1.Click += label1_Click;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.BackColor = Color.Transparent;
            lblKembalian.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKembalian.ForeColor = Color.Red;
            lblKembalian.Location = new Point(289, 628);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(102, 26);
            lblKembalian.TabIndex = 2;
            lblKembalian.Text = "Rp 1.000";
            // 
            // txtUangDiterima
            // 
            txtUangDiterima.Location = new Point(37, 552);
            txtUangDiterima.Name = "txtUangDiterima";
            txtUangDiterima.Size = new Size(372, 31);
            txtUangDiterima.TabIndex = 1;
            txtUangDiterima.TextChanged += txtUangDiterima_TextChanged;
            // 
            // cmbMetodeBayar
            // 
            cmbMetodeBayar.FormattingEnabled = true;
            cmbMetodeBayar.Location = new Point(37, 453);
            cmbMetodeBayar.Name = "cmbMetodeBayar";
            cmbMetodeBayar.Size = new Size(372, 33);
            cmbMetodeBayar.TabIndex = 0;
            cmbMetodeBayar.SelectedIndexChanged += cmbMetodeBayar_SelectedIndexChanged;
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(37, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 11;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            // 
            // btDaftarProduk
            // 
            btDaftarProduk.BackColor = Color.OldLace;
            btDaftarProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDaftarProduk.ForeColor = Color.FromArgb(100, 60, 20);
            btDaftarProduk.Location = new Point(77, 428);
            btDaftarProduk.Name = "btDaftarProduk";
            btDaftarProduk.Size = new Size(224, 41);
            btDaftarProduk.TabIndex = 5;
            btDaftarProduk.Text = "Daftar Produk";
            btDaftarProduk.UseVisualStyleBackColor = false;
            // 
            // btRiwayatTransaksi
            // 
            btRiwayatTransaksi.BackColor = Color.OldLace;
            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btRiwayatTransaksi.Location = new Point(77, 304);
            btRiwayatTransaksi.Name = "btRiwayatTransaksi";
            btRiwayatTransaksi.Size = new Size(224, 41);
            btRiwayatTransaksi.TabIndex = 4;
            btRiwayatTransaksi.Text = "Riwayat Transaksi";
            btRiwayatTransaksi.UseVisualStyleBackColor = false;
            // 
            // btTransaksi
            // 
            btTransaksi.BackColor = Color.OldLace;
            btTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btTransaksi.Location = new Point(77, 220);
            btTransaksi.Name = "btTransaksi";
            btTransaksi.Size = new Size(224, 41);
            btTransaksi.TabIndex = 3;
            btTransaksi.Text = "Transaksi";
            btTransaksi.UseVisualStyleBackColor = false;
            btTransaksi.Click += btDashboar_Click;
            // 
            // KasirDashboardView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "KasirDashboardView";
            Text = "KasirDashboardView";
            panel1.ResumeLayout(false);
            flpProduk.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flpKeranjang.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btDaftarProduk;
        private Button btRiwayatTransaksi;
        private Button btTransaksi;
        private Button btLogout;
        private Panel panel2;
        private ComboBox cmbMetodeBayar;
        private TextBox txtUangDiterima;
        private Label label1;
        private Label lblKembalian;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flpProduk;
        private Panel panel8;
        private Label Stok;
        private Label NamaProduk;
        private Label HargaProduk;
        private Button button1;
        private Button btnCheckout;
        private FlowLayoutPanel flpKeranjang;
        private Panel panel3;
        private Button lblPlus;
        private Button btnMinus;
        private Label lblSubTotal;
        private Label lblNamaProduk;
        private Label lblQty;
        private Label lblHarga;
    }
}
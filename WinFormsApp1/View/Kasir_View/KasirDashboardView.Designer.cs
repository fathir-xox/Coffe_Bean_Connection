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
            panel = new Panel();
            flpKeranjang = new FlowLayoutPanel();
            btnCheckout = new Button();
            lblSubTotal = new Label();
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
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VTransaksi;
            panel1.Controls.Add(flpProduk);
            panel1.Controls.Add(panel);
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
            flpProduk.Location = new Point(357, 170);
            flpProduk.Name = "flpProduk";
            flpProduk.Size = new Size(1054, 825);
            flpProduk.TabIndex = 13;
            // 
            // panel
            // 
            panel.BackgroundImage = Properties.Resources.CardTransaksi;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.Controls.Add(flpKeranjang);
            panel.Controls.Add(btnCheckout);
            panel.Controls.Add(lblSubTotal);
            panel.Controls.Add(label4);
            panel.Controls.Add(label3);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Controls.Add(lblKembalian);
            panel.Controls.Add(txtUangDiterima);
            panel.Controls.Add(cmbMetodeBayar);
            panel.Location = new Point(1432, 170);
            panel.Name = "panel";
            panel.Size = new Size(453, 783);
            panel.TabIndex = 12;
            panel.Paint += panel2_Paint;
            // 
            // flpKeranjang
            // 
            flpKeranjang.AutoScroll = true;
            flpKeranjang.BackColor = Color.Transparent;
            flpKeranjang.Location = new Point(14, 67);
            flpKeranjang.Name = "flpKeranjang";
            flpKeranjang.Size = new Size(418, 251);
            flpKeranjang.TabIndex = 9;
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
            btnCheckout.Click += btnCheckout_Click_1;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(265, 350);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(134, 32);
            lblSubTotal.TabIndex = 7;
            lblSubTotal.Text = "Rp 12.000";
            lblSubTotal.Click += label5_Click;
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
            btRiwayatTransaksi.Click += btRiwayatTransaksi_Click_1;
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
            Load += KasirDashboardView_Load;
            panel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btDaftarProduk;
        private Button btRiwayatTransaksi;
        private Button btTransaksi;
        private Button btLogout;
        private Panel panel;
        private ComboBox cmbMetodeBayar;
        private TextBox txtUangDiterima;
        private Label label1;
        private Label lblKembalian;
        private Label label2;
        private Label lblSubTotal;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flpProduk;
        private Button btnCheckout;
        private FlowLayoutPanel flpKeranjang;
    }
}
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
            btLogout = new Button();
            btDaftarProduk = new Button();
            btRiwayatTransaksi = new Button();
            btTransaksi = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VTransaksi;
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
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.CardTransaksi;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(1432, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 783);
            panel2.TabIndex = 12;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btDaftarProduk;
        private Button btRiwayatTransaksi;
        private Button btTransaksi;
        private Button btLogout;
        private Panel panel2;
    }
}
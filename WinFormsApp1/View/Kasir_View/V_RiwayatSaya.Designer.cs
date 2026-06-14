namespace FinalProjek.View.Kasir_View
{
    partial class V_RiwayatSaya
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
            dgvRiwayat = new DataGridView();
            panel4 = new Panel();
            lblOmzet = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblTotalItem = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblTotalTrx = new Label();
            label1 = new Label();
            btLogout = new Button();
            btDaftarProduk = new Button();
            btRiwayatTransaksi = new Button();
            btTransaksi = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.VRiwayatSaya;
            panel1.Controls.Add(dgvRiwayat);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btLogout);
            panel1.Controls.Add(btDaftarProduk);
            panel1.Controls.Add(btRiwayatTransaksi);
            panel1.Controls.Add(btTransaksi);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1899, 1027);
            panel1.TabIndex = 0;
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AllowUserToAddRows = false;
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(373, 348);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.RowHeadersWidth = 62;
            dgvRiwayat.Size = new Size(1467, 620);
            dgvRiwayat.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.CardRiwayatSaya;
            panel4.Controls.Add(lblOmzet);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(1164, 161);
            panel4.Name = "panel4";
            panel4.Size = new Size(372, 155);
            panel4.TabIndex = 17;
            // 
            // lblOmzet
            // 
            lblOmzet.AutoSize = true;
            lblOmzet.BackColor = Color.Transparent;
            lblOmzet.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOmzet.Location = new Point(42, 87);
            lblOmzet.Name = "lblOmzet";
            lblOmzet.Size = new Size(28, 32);
            lblOmzet.TabIndex = 4;
            lblOmzet.Text = "0";
            lblOmzet.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 21);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 5;
            label5.Text = "Omzet";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.CardRiwayatSaya;
            panel3.Controls.Add(lblTotalItem);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(767, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(372, 155);
            panel3.TabIndex = 17;
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.BackColor = Color.Transparent;
            lblTotalItem.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItem.Location = new Point(40, 87);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(28, 32);
            lblTotalItem.TabIndex = 3;
            lblTotalItem.Text = "0";
            lblTotalItem.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 21);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 2;
            label2.Text = "Total Item";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.CardRiwayatSaya;
            panel2.Controls.Add(lblTotalTrx);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(373, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 155);
            panel2.TabIndex = 16;
            // 
            // lblTotalTrx
            // 
            lblTotalTrx.AutoSize = true;
            lblTotalTrx.BackColor = Color.Transparent;
            lblTotalTrx.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTrx.Location = new Point(31, 87);
            lblTotalTrx.Name = "lblTotalTrx";
            lblTotalTrx.Size = new Size(28, 32);
            lblTotalTrx.TabIndex = 1;
            lblTotalTrx.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 0;
            label1.Text = "Jumlah Transaksi";
            // 
            // btLogout
            // 
            btLogout.BackColor = Color.Red;
            btLogout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogout.ForeColor = Color.White;
            btLogout.Location = new Point(37, 912);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(224, 41);
            btLogout.TabIndex = 15;
            btLogout.Text = "Logout";
            btLogout.UseVisualStyleBackColor = false;
            // 
            // btDaftarProduk
            // 
            btDaftarProduk.BackColor = Color.OldLace;
            btDaftarProduk.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDaftarProduk.ForeColor = Color.FromArgb(100, 60, 20);
            btDaftarProduk.Location = new Point(75, 428);
            btDaftarProduk.Name = "btDaftarProduk";
            btDaftarProduk.Size = new Size(224, 41);
            btDaftarProduk.TabIndex = 14;
            btDaftarProduk.Text = "Daftar Produk";
            btDaftarProduk.UseVisualStyleBackColor = false;
            // 
            // btRiwayatTransaksi
            // 
            btRiwayatTransaksi.BackColor = Color.OldLace;
            btRiwayatTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRiwayatTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btRiwayatTransaksi.Location = new Point(75, 304);
            btRiwayatTransaksi.Name = "btRiwayatTransaksi";
            btRiwayatTransaksi.Size = new Size(224, 41);
            btRiwayatTransaksi.TabIndex = 13;
            btRiwayatTransaksi.Text = "Riwayat Transaksi";
            btRiwayatTransaksi.UseVisualStyleBackColor = false;
            // 
            // btTransaksi
            // 
            btTransaksi.BackColor = Color.OldLace;
            btTransaksi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btTransaksi.ForeColor = Color.FromArgb(100, 60, 20);
            btTransaksi.Location = new Point(75, 220);
            btTransaksi.Name = "btTransaksi";
            btTransaksi.Size = new Size(224, 41);
            btTransaksi.TabIndex = 12;
            btTransaksi.Text = "Transaksi";
            btTransaksi.UseVisualStyleBackColor = false;
            btTransaksi.Click += btTransaksi_Click;
            // 
            // V_RiwayatSaya
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "V_RiwayatSaya";
            Text = "V_RiwayatSaya";
            Load += V_RiwayatSaya_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btLogout;
        private Button btDaftarProduk;
        private Button btRiwayatTransaksi;
        private Button btTransaksi;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label lblOmzet;
        private Label label5;
        private Label lblTotalItem;
        private Label label2;
        private Label lblTotalTrx;
        private DataGridView dgvRiwayat;
    }
}
namespace FinalProjek.View.Admin_View
{
    partial class V_EditProduk
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
            tbNamaProduk = new TextBox();
            tbHarga = new TextBox();
            tbStok = new TextBox();
            btUploadGambar = new Button();
            btSimpan = new Button();
            SuspendLayout();
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Location = new Point(52, 153);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(177, 31);
            tbNamaProduk.TabIndex = 0;
            tbNamaProduk.TextChanged += tbNamaProduk_TextChanged;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(52, 209);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(177, 31);
            tbHarga.TabIndex = 1;
            // 
            // tbStok
            // 
            tbStok.Location = new Point(52, 271);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(177, 31);
            tbStok.TabIndex = 2;
            // 
            // btUploadGambar
            // 
            btUploadGambar.Location = new Point(348, 173);
            btUploadGambar.Name = "btUploadGambar";
            btUploadGambar.Size = new Size(112, 34);
            btUploadGambar.TabIndex = 3;
            btUploadGambar.Text = "Upload Gambar";
            btUploadGambar.UseVisualStyleBackColor = true;
            btUploadGambar.Click += btUploadGambar_Click;
            // 
            // btSimpan
            // 
            btSimpan.Location = new Point(348, 258);
            btSimpan.Name = "btSimpan";
            btSimpan.Size = new Size(112, 34);
            btSimpan.TabIndex = 4;
            btSimpan.Text = "Simpan";
            btSimpan.UseVisualStyleBackColor = true;
            btSimpan.Click += btSimpan_Click;
            // 
            // V_EditProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btSimpan);
            Controls.Add(btUploadGambar);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(tbNamaProduk);
            Name = "V_EditProduk";
            Text = "V_EditProduk";
            Load += V_EditProduk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNamaProduk;
        private TextBox tbHarga;
        private TextBox tbStok;
        private Button btUploadGambar;
        private Button btSimpan;
    }
}
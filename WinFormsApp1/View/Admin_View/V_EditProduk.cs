using FinalProjek.Controler;
using FinalProjek.Interface;
using FinalProjek.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_EditProduk : Form
    {
        private Produk produk;
        //private object imageproduk;
        private readonly ProdukController produkController;


        public V_EditProduk(Produk _produk)
        {
            InitializeComponent();
            produk = _produk;
            produkController = new ProdukController();
        }

        public V_EditProduk()
        {
        }

        private void V_EditProduk_Load(object sender, EventArgs e)
        {
            tbNamaProduk.Text = produk.nama_produk;
            tbHarga.Text = produk.harga.ToString();
            tbStok.Text = produk.stok.ToString();
            if (produk.imageproduk != null)
            {
                using (var ms = new System.IO.MemoryStream(produk.imageproduk))
                {
                    imageproduk.Image = Image.FromStream(ms);
                }
            }
        }

        private void tbNamaProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btUploadGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageproduk.Image = Image.FromFile(ofd.FileName);

                // Convert ke byte[]
                produk.imageproduk = File.ReadAllBytes(ofd.FileName);
            }
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNamaProduk.Text) ||
                string.IsNullOrWhiteSpace(tbHarga.Text) ||
                string.IsNullOrWhiteSpace(tbStok.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbHarga.Text, out int harga) || !int.TryParse(tbStok.Text, out int stok))
            {
                MessageBox.Show("Harga dan Stok harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (harga < 0)
            {
                MessageBox.Show("Harga tidak boleh kurang dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stok < 0)
            {
                MessageBox.Show("Stok tidak boleh kurang dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            produk.nama_produk = tbNamaProduk.Text;
            produk.harga = harga;
            produk.stok = stok;

            produkController.UpdateProduk(produk);
            MessageBox.Show("Produk berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

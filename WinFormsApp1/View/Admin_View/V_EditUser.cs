using FinalProjek.Controler;
using FinalProjek.Model;
using System;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_EditUser : Form
    {
        private User currentUser; // Menyimpan data user yang sedang diedit
        private AuthController authController;

        // Konstruktor dimodifikasi untuk menerima data 'User'
        public V_EditUser(User userToEdit)
        {
            InitializeComponent();

            currentUser = userToEdit;
            authController = new AuthController();

            // Panggil fungsi untuk menyiapkan isi form
            PopulateDataForm();
        }

        private void PopulateDataForm()
        {
            // 1. Isi pilihan ComboBox
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Kasir");

            cbStatus.Items.Add("Aktif");
            cbStatus.Items.Add("Non Aktif");

            // 2. Cegah error jika datanya kebetulan kosong
            if (currentUser == null) return;

            // 3. Masukkan data user saat ini ke dalam TextBox
            txtUsername.Text = currentUser.username;
            txtFullName.Text = currentUser.full_name;

            // 4. Pilih Role yang sesuai
            if (currentUser.role.ToString().ToLower() == "admin")
                cbRole.SelectedItem = "Admin";
            else
                cbRole.SelectedItem = "Kasir";

            // 5. Pilih Status yang sesuai
            if (currentUser.isactive)
                cbStatus.SelectedItem = "Aktif";
            else
                cbStatus.SelectedItem = "Non Aktif";
        }

        // Jangan lupa hubungkan Event Click ini ke tombol "SIMPAN" Anda
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi: Pastikan tidak ada kolom yang dibiarkan kosong
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                cbRole.SelectedItem == null ||
                cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update nilai di dalam objek currentUser dengan ketikan terbaru
            currentUser.username = txtUsername.Text.Trim();
            currentUser.full_name = txtFullName.Text.Trim();

            // Ubah teks "Admin"/"Kasir" kembali menjadi Enum UserRole
            string selectedRole = cbRole.SelectedItem.ToString();
            currentUser.role = (UserRole)Enum.Parse(typeof(UserRole), selectedRole, true);

            // Ubah teks "Aktif"/"Non Aktif" menjadi true/false
            currentUser.isactive = (cbStatus.SelectedItem.ToString() == "Aktif");

            // Panggil Controller untuk mengirim data baru ke Database
            bool sukses = authController.UpdateUser(currentUser);

            if (sukses)
            {
                MessageBox.Show("Data user berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Memberi sinyal "Sukses" ke halaman sebelumnya
                this.Close(); // Tutup form edit
            }
        }
    }
}
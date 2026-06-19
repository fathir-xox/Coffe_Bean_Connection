using FinalProjek.Controler;
using FinalProjek.Model;
using System;
using System.Windows.Forms;

namespace FinalProjek.View.Admin_View
{
    public partial class V_EditUser : Form
    {
        private User currentUser; 
        private AuthController authController;

        public V_EditUser(User userToEdit)
        {
            InitializeComponent();
            currentUser = userToEdit;
            authController = new AuthController();
            PopulateDataForm();
        }

        private void PopulateDataForm()
        {
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Kasir");

            cbStatus.Items.Add("Aktif");
            cbStatus.Items.Add("Non Aktif");

            if (currentUser == null) return;

            txtUsername.Text = currentUser.username;
            txtFullName.Text = currentUser.full_name;

            if (currentUser.role.ToString().ToLower() == "admin")
                cbRole.SelectedItem = "Admin";
            else
                cbRole.SelectedItem = "Kasir";

            if (currentUser.isactive)
                cbStatus.SelectedItem = "Aktif";
            else
                cbStatus.SelectedItem = "Non Aktif";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                cbRole.SelectedItem == null ||
                cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currentUser.username = txtUsername.Text.Trim();
            currentUser.full_name = txtFullName.Text.Trim();

            string selectedRole = cbRole.SelectedItem.ToString();
            currentUser.role = (UserRole)Enum.Parse(typeof(UserRole), selectedRole, true);

            currentUser.isactive = (cbStatus.SelectedItem.ToString() == "Aktif");

            bool sukses = authController.UpdateUser(currentUser);

            if (sukses)
            {
                MessageBox.Show("Data user berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            }
        }
    }
}
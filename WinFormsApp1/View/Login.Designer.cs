namespace FinalProjek.View
{
    partial class Login
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
            linkLabelRegister = new LinkLabel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.LoginView1;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(linkLabelRegister);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 708);
            panel1.TabIndex = 0;
            // 
            // linkLabelRegister
            // 
            linkLabelRegister.AutoSize = true;
            linkLabelRegister.Font = new Font("Times New Roman", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelRegister.Location = new Point(838, 471);
            linkLabelRegister.Name = "linkLabelRegister";
            linkLabelRegister.Size = new Size(176, 19);
            linkLabelRegister.TabIndex = 6;
            linkLabelRegister.TabStop = true;
            linkLabelRegister.Text = "Belum punya  akun? Daftar.";
            linkLabelRegister.LinkClicked += linkLabelRegister_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(781, 425);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += tbPasswordLogin_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(782, 323);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 31);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += tbUsernameLogin_TextChanged;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Wheat;
            btLogin.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.FromArgb(100, 60, 20);
            btLogin.Location = new Point(773, 506);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(299, 55);
            btLogin.TabIndex = 3;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 60, 20);
            label3.Location = new Point(779, 387);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 60, 20);
            label2.Location = new Point(779, 286);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 60, 20);
            label1.Location = new Point(863, 210);
            label1.Name = "label1";
            label1.Size = new Size(119, 36);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btLogin;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private LinkLabel linkLabelRegister;
    }
}
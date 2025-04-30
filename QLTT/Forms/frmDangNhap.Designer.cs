namespace QLTT.Forms
{
    partial class frmDangNhap
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            pictureBox1 = new PictureBox();
            btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            txtTenDangNhap = new Guna.UI2.WinForms.Guna2TextBox();
            txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            cbHienMatKhau = new CheckBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(507, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.BorderRadius = 20;
            btnDangNhap.CustomizableEdges = customizableEdges1;
            btnDangNhap.DisabledState.BorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangNhap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangNhap.FillColor = Color.Indigo;
            btnDangNhap.Font = new Font("Segoe UI", 9F);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.HoverState.BorderColor = Color.FromArgb(128, 128, 255);
            btnDangNhap.HoverState.CustomBorderColor = Color.Blue;
            btnDangNhap.Location = new Point(457, 275);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDangNhap.ShadowDecoration.Depth = 100;
            btnDangNhap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnDangNhap.Size = new Size(195, 45);
            btnDangNhap.TabIndex = 8;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BorderRadius = 20;
            btnThoat.CustomizableEdges = customizableEdges3;
            btnThoat.DisabledState.BorderColor = Color.DarkGray;
            btnThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThoat.FillColor = Color.Indigo;
            btnThoat.Font = new Font("Segoe UI", 9F);
            btnThoat.ForeColor = Color.White;
            btnThoat.HoverState.BorderColor = Color.FromArgb(128, 128, 255);
            btnThoat.HoverState.CustomBorderColor = Color.Blue;
            btnThoat.Location = new Point(457, 326);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThoat.ShadowDecoration.Depth = 100;
            btnThoat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnThoat.Size = new Size(195, 45);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.CustomizableEdges = customizableEdges5;
            txtTenDangNhap.DefaultText = "";
            txtTenDangNhap.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenDangNhap.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenDangNhap.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangNhap.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenDangNhap.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangNhap.Font = new Font("Segoe UI", 9F);
            txtTenDangNhap.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenDangNhap.Location = new Point(442, 148);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Tên đăng nhập...";
            txtTenDangNhap.SelectedText = "";
            txtTenDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTenDangNhap.Size = new Size(224, 36);
            txtTenDangNhap.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            txtMatKhau.CustomizableEdges = customizableEdges7;
            txtMatKhau.DefaultText = "";
            txtMatKhau.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMatKhau.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMatKhau.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMatKhau.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Font = new Font("Segoe UI", 9F);
            txtMatKhau.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMatKhau.Location = new Point(442, 190);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Mật khẩu...";
            txtMatKhau.SelectedText = "";
            txtMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtMatKhau.Size = new Size(224, 36);
            txtMatKhau.TabIndex = 11;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // cbHienMatKhau
            // 
            cbHienMatKhau.AutoSize = true;
            cbHienMatKhau.BackColor = Color.Transparent;
            cbHienMatKhau.Location = new Point(502, 240);
            cbHienMatKhau.Margin = new Padding(2);
            cbHienMatKhau.Name = "cbHienMatKhau";
            cbHienMatKhau.Size = new Size(104, 19);
            cbHienMatKhau.TabIndex = 6;
            cbHienMatKhau.Text = "Hiện mật khẩu";
            cbHienMatKhau.UseVisualStyleBackColor = false;
            cbHienMatKhau.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = this;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(729, 433);
            ControlBox = false;
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(pictureBox1);
            Controls.Add(cbHienMatKhau);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private CheckBox cbHienMatKhau;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
namespace QLTT.Forms
{
    partial class frmMenu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            borderRadiousMenu = new Guna.UI2.WinForms.Guna2Elipse(components);
            ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            pnMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            pnSidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            btnLich = new Guna.UI2.WinForms.Guna2Button();
            btnDanhSach = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pnSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // borderRadiousMenu
            // 
            borderRadiousMenu.BorderRadius = 20;
            borderRadiousMenu.TargetControl = this;
            // 
            // ShadowForm
            // 
            ShadowForm.TargetForm = this;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.Transparent;
            pnMain.BorderRadius = 20;
            pnMain.CustomizableEdges = customizableEdges1;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(195, 0);
            pnMain.Name = "pnMain";
            pnMain.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnMain.Size = new Size(771, 518);
            pnMain.TabIndex = 3;
            // 
            // pnSidebar
            // 
            pnSidebar.BackColor = Color.White;
            pnSidebar.BorderRadius = 20;
            pnSidebar.Controls.Add(btnThoat);
            pnSidebar.Controls.Add(btnLich);
            pnSidebar.Controls.Add(btnDanhSach);
            pnSidebar.Controls.Add(pictureBox1);
            pnSidebar.CustomizableEdges = customizableEdges9;
            pnSidebar.Dock = DockStyle.Left;
            pnSidebar.Location = new Point(0, 0);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnSidebar.Size = new Size(195, 518);
            pnSidebar.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.CustomizableEdges = customizableEdges3;
            btnThoat.DisabledState.BorderColor = Color.DarkGray;
            btnThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThoat.Font = new Font("Segoe UI", 9F);
            btnThoat.ForeColor = Color.White;
            btnThoat.HoverState.FillColor = Color.FromArgb(128, 255, 255);
            btnThoat.Location = new Point(24, 245);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThoat.Size = new Size(146, 45);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLich
            // 
            btnLich.CustomizableEdges = customizableEdges5;
            btnLich.DisabledState.BorderColor = Color.DarkGray;
            btnLich.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLich.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLich.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLich.Font = new Font("Segoe UI", 9F);
            btnLich.ForeColor = Color.White;
            btnLich.HoverState.FillColor = Color.FromArgb(128, 255, 255);
            btnLich.Location = new Point(24, 108);
            btnLich.Name = "btnLich";
            btnLich.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLich.Size = new Size(146, 45);
            btnLich.TabIndex = 2;
            btnLich.Text = "Lịch";
            btnLich.Click += btnLich_Click;
            // 
            // btnDanhSach
            // 
            btnDanhSach.CustomizableEdges = customizableEdges7;
            btnDanhSach.DisabledState.BorderColor = Color.DarkGray;
            btnDanhSach.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDanhSach.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDanhSach.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDanhSach.Font = new Font("Segoe UI", 9F);
            btnDanhSach.ForeColor = Color.White;
            btnDanhSach.HoverState.FillColor = Color.FromArgb(128, 255, 255);
            btnDanhSach.Location = new Point(24, 177);
            btnDanhSach.Name = "btnDanhSach";
            btnDanhSach.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDanhSach.Size = new Size(146, 45);
            btnDanhSach.TabIndex = 1;
            btnDanhSach.Text = "Danh sách";
            btnDanhSach.Click += btnDanhSach_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hololive_logo_svg;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = btnDanhSach;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = btnLich;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = btnThoat;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(966, 518);
            Controls.Add(pnMain);
            Controls.Add(pnSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMenu";
            pnSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse borderRadiousMenu;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2GradientPanel pnMain;
        private Guna.UI2.WinForms.Guna2GradientPanel pnSidebar;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDanhSach;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnLich;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
    }
}
namespace QLTT.Forms
{
    partial class frmCongTy
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongTy));
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            txtQuocGia = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtTenCongTy = new TextBox();
            txtMoTa = new TextBox();
            dtpNgayThanhLap = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnXuat = new Button();
            btnLuu = new Button();
            btnNhap = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dgvDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            CongTyId = new DataGridViewTextBoxColumn();
            TenCongTy = new DataGridViewTextBoxColumn();
            NgayThanhLap = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            QuocGia = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(txtQuocGia);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(txtTenCongTy);
            guna2Panel1.Controls.Add(txtMoTa);
            guna2Panel1.Controls.Add(dtpNgayThanhLap);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(12, 13);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(430, 142);
            guna2Panel1.TabIndex = 41;
            // 
            // txtQuocGia
            // 
            txtQuocGia.Location = new Point(142, 105);
            txtQuocGia.Name = "txtQuocGia";
            txtQuocGia.Size = new Size(271, 23);
            txtQuocGia.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 47;
            label1.Text = "Tên chi nhánh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 106);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 52;
            label4.Text = "Quốc gia trực thuộc:";
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Location = new Point(142, 15);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(271, 23);
            txtTenCongTy.TabIndex = 46;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(142, 77);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(271, 23);
            txtMoTa.TabIndex = 51;
            // 
            // dtpNgayThanhLap
            // 
            dtpNgayThanhLap.Format = DateTimePickerFormat.Short;
            dtpNgayThanhLap.Location = new Point(142, 44);
            dtpNgayThanhLap.MaxDate = new DateTime(2029, 12, 31, 0, 0, 0, 0);
            dtpNgayThanhLap.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpNgayThanhLap.Name = "dtpNgayThanhLap";
            dtpNgayThanhLap.Size = new Size(271, 23);
            dtpNgayThanhLap.TabIndex = 48;
            dtpNgayThanhLap.Value = new DateTime(2025, 4, 12, 9, 28, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 50;
            label3.Text = "Mô tả chi nhánh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 49;
            label2.Text = "Ngày thành lập:";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = guna2GradientPanel1;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.White;
            guna2GradientPanel1.Controls.Add(btnXuat);
            guna2GradientPanel1.Controls.Add(btnLuu);
            guna2GradientPanel1.Controls.Add(btnNhap);
            guna2GradientPanel1.Controls.Add(btnXoa);
            guna2GradientPanel1.Controls.Add(btnTimKiem);
            guna2GradientPanel1.Controls.Add(btnSua);
            guna2GradientPanel1.Controls.Add(btnThoat);
            guna2GradientPanel1.Controls.Add(btnThem);
            guna2GradientPanel1.Controls.Add(btnHuy);
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Location = new Point(461, 13);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(297, 142);
            guna2GradientPanel1.TabIndex = 42;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(209, 58);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 51;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(93, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 43;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(209, 29);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 50;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(12, 87);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 45;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(209, 87);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 49;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(12, 58);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 44;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(93, 87);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 48;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 46;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(93, 58);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 47;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            guna2Elipse2.TargetControl = guna2Panel1;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 10;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 10;
            guna2Elipse4.TargetControl = dgvDanhSach;
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AllowUserToDeleteRows = false;
            dgvDanhSach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSach.ColumnHeadersHeight = 17;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { CongTyId, TenCongTy, NgayThanhLap, MoTa, QuocGia });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.Location = new Point(12, 161);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.Size = new Size(746, 342);
            dgvDanhSach.TabIndex = 52;
            dgvDanhSach.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDanhSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDanhSach.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDanhSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDanhSach.ThemeStyle.BackColor = Color.White;
            dgvDanhSach.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDanhSach.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhSach.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSach.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDanhSach.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDanhSach.ThemeStyle.HeaderStyle.Height = 17;
            dgvDanhSach.ThemeStyle.ReadOnly = false;
            dgvDanhSach.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDanhSach.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSach.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSach.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSach.ThemeStyle.RowsStyle.Height = 25;
            dgvDanhSach.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // CongTyId
            // 
            CongTyId.DataPropertyName = "CongTyId";
            CongTyId.FillWeight = 50.76142F;
            CongTyId.HeaderText = "ID";
            CongTyId.Name = "CongTyId";
            // 
            // TenCongTy
            // 
            TenCongTy.DataPropertyName = "TenCongTy";
            TenCongTy.FillWeight = 112.309647F;
            TenCongTy.HeaderText = "Tên công ty";
            TenCongTy.Name = "TenCongTy";
            // 
            // NgayThanhLap
            // 
            NgayThanhLap.DataPropertyName = "NgayThanhLap";
            NgayThanhLap.FillWeight = 112.309647F;
            NgayThanhLap.HeaderText = "Ngày thành lập";
            NgayThanhLap.Name = "NgayThanhLap";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.FillWeight = 112.309647F;
            MoTa.HeaderText = "Mô tả";
            MoTa.Name = "MoTa";
            // 
            // QuocGia
            // 
            QuocGia.DataPropertyName = "QuocGia";
            QuocGia.FillWeight = 112.309647F;
            QuocGia.HeaderText = "Quốc gia trực thuộc";
            QuocGia.Name = "QuocGia";
            // 
            // frmCongTy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(771, 515);
            Controls.Add(dgvDanhSach);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCongTy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Công ty";
            Load += frmCongTy_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TextBox txtQuocGia;
        private Label label1;
        private Label label4;
        private TextBox txtTenCongTy;
        private TextBox txtMoTa;
        private DateTimePicker dtpNgayThanhLap;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Button btnXuat;
        private Button btnLuu;
        private Button btnNhap;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private Button btnHuy;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSach;
        private DataGridViewTextBoxColumn CongTyId;
        private DataGridViewTextBoxColumn TenCongTy;
        private DataGridViewTextBoxColumn NgayThanhLap;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn QuocGia;
    }
}
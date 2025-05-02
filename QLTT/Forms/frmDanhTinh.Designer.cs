namespace QLTT.Forms
{
    partial class frmDanhTinh
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dgvDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            DanhTinhId = new DataGridViewTextBoxColumn();
            HoTenThat = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            TenIdol = new DataGridViewTextBoxColumn();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cbIdol = new ComboBox();
            label5 = new Label();
            txtSdt = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            btnXuat = new Button();
            btnLuu = new Button();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnNhap = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            guna2Panel1.SuspendLayout();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
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
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { DanhTinhId, HoTenThat, NgaySinh, DiaChi, SoDienThoai, TenIdol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.Location = new Point(14, 172);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.Size = new Size(746, 330);
            dgvDanhSach.TabIndex = 55;
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
            // DanhTinhId
            // 
            DanhTinhId.DataPropertyName = "DanhTinhId";
            DanhTinhId.FillWeight = 50.76142F;
            DanhTinhId.HeaderText = "ID";
            DanhTinhId.Name = "DanhTinhId";
            // 
            // HoTenThat
            // 
            HoTenThat.DataPropertyName = "HoTenThat";
            HoTenThat.HeaderText = "Họ tên";
            HoTenThat.Name = "HoTenThat";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.Name = "SoDienThoai";
            // 
            // TenIdol
            // 
            TenIdol.DataPropertyName = "TenIdol";
            TenIdol.HeaderText = "Hóa thân";
            TenIdol.Name = "TenIdol";
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 10;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            guna2Elipse2.TargetControl = guna2Panel1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(cbIdol);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(txtSdt);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(txtTen);
            guna2Panel1.Controls.Add(txtDiaChi);
            guna2Panel1.Controls.Add(dtpNgaySinh);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(14, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(430, 142);
            guna2Panel1.TabIndex = 53;
            // 
            // cbIdol
            // 
            cbIdol.FormattingEnabled = true;
            cbIdol.Location = new Point(289, 106);
            cbIdol.Name = "cbIdol";
            cbIdol.Size = new Size(121, 23);
            cbIdol.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 109);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 54;
            label5.Text = "Hóa thân:";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(103, 106);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(112, 23);
            txtSdt.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 47;
            label1.Text = "Họ và tên thật:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 109);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 52;
            label4.Text = "Số điện thoại:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(103, 15);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(307, 23);
            txtTen.TabIndex = 46;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(103, 73);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(307, 23);
            txtDiaChi.TabIndex = 51;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(103, 44);
            dtpNgaySinh.MaxDate = new DateTime(2029, 12, 31, 0, 0, 0, 0);
            dtpNgaySinh.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(307, 23);
            dtpNgaySinh.TabIndex = 48;
            dtpNgaySinh.Value = new DateTime(2025, 4, 12, 9, 28, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 50;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 49;
            label2.Text = "Ngày sinh:";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(209, 87);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 51;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
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
            guna2GradientPanel1.Location = new Point(450, 12);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(310, 142);
            guna2GradientPanel1.TabIndex = 54;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(209, 58);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 50;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
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
            btnTimKiem.Location = new Point(209, 29);
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
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = guna2GradientPanel1;
            // 
            // frmDanhTinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 517);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(dgvDanhSach);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDanhTinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDanhTinh";
            Load += frmDanhTinh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private TextBox txtSdt;
        private Label label1;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private Label label3;
        private Label label2;
        private Button btnXuat;
        private Button btnLuu;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Button btnNhap;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private Button btnHuy;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label5;
        private ComboBox cbIdol;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSach;
        private DataGridViewTextBoxColumn DanhTinhId;
        private DataGridViewTextBoxColumn HoTenThat;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn TenIdol;
    }
}
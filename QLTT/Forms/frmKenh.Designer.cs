namespace QLTT.Forms
{
    partial class frmKenh
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            nudLuotXem = new NumericUpDown();
            nudLuotDangKy = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            cbChuKenh = new ComboBox();
            label3 = new Label();
            txtUrl = new TextBox();
            cbNenTang = new ComboBox();
            label5 = new Label();
            cbTinhTrangKenh = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenKenh = new TextBox();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dgvDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            KenhId = new DataGridViewTextBoxColumn();
            TenKenh = new DataGridViewTextBoxColumn();
            NenTang = new DataGridViewTextBoxColumn();
            UrlKenh = new DataGridViewTextBoxColumn();
            SoLuongNguoiDangKy = new DataGridViewTextBoxColumn();
            TongLuotXem = new DataGridViewTextBoxColumn();
            DangHoatDong = new DataGridViewTextBoxColumn();
            TenIdol = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLuotXem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLuotDangKy).BeginInit();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(nudLuotXem);
            guna2Panel1.Controls.Add(nudLuotDangKy);
            guna2Panel1.Controls.Add(label7);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(cbChuKenh);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(txtUrl);
            guna2Panel1.Controls.Add(cbNenTang);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(cbTinhTrangKenh);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(txtTenKenh);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(12, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(410, 158);
            guna2Panel1.TabIndex = 6;
            // 
            // nudLuotXem
            // 
            nudLuotXem.Location = new Point(287, 96);
            nudLuotXem.Name = "nudLuotXem";
            nudLuotXem.Size = new Size(93, 23);
            nudLuotXem.TabIndex = 49;
            // 
            // nudLuotDangKy
            // 
            nudLuotDangKy.Location = new Point(123, 96);
            nudLuotDangKy.Name = "nudLuotDangKy";
            nudLuotDangKy.Size = new Size(93, 23);
            nudLuotDangKy.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 98);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 47;
            label7.Text = "Lượt xem:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 98);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 46;
            label6.Text = "Lượt đăng ký:";
            // 
            // cbChuKenh
            // 
            cbChuKenh.FormattingEnabled = true;
            cbChuKenh.Location = new Point(287, 125);
            cbChuKenh.Name = "cbChuKenh";
            cbChuKenh.Size = new Size(93, 23);
            cbChuKenh.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 128);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 44;
            label3.Text = "Chủ kênh:";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(123, 69);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(259, 23);
            txtUrl.TabIndex = 43;
            // 
            // cbNenTang
            // 
            cbNenTang.FormattingEnabled = true;
            cbNenTang.Items.AddRange(new object[] { "Youtobe", "Twitch", "Billibili", "Khác" });
            cbNenTang.Location = new Point(123, 41);
            cbNenTang.Name = "cbNenTang";
            cbNenTang.Size = new Size(259, 23);
            cbNenTang.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 44);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 41;
            label5.Text = "Nền tảng:";
            // 
            // cbTinhTrangKenh
            // 
            cbTinhTrangKenh.FormattingEnabled = true;
            cbTinhTrangKenh.Items.AddRange(new object[] { "Đang hoạt động", "Tạm ngưng", "Mất/Bị xóa" });
            cbTinhTrangKenh.Location = new Point(121, 125);
            cbTinhTrangKenh.Name = "cbTinhTrangKenh";
            cbTinhTrangKenh.Size = new Size(95, 23);
            cbTinhTrangKenh.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 128);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 39;
            label4.Text = "Tình trạng kênh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 36;
            label2.Text = "Đường dẫn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 34;
            label1.Text = "Tên kênh:";
            // 
            // txtTenKenh
            // 
            txtTenKenh.Location = new Point(123, 12);
            txtTenKenh.Name = "txtTenKenh";
            txtTenKenh.Size = new Size(259, 23);
            txtTenKenh.TabIndex = 33;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(btnXuat);
            guna2Panel3.Controls.Add(btnNhap);
            guna2Panel3.Controls.Add(btnTimKiem);
            guna2Panel3.Controls.Add(btnThoat);
            guna2Panel3.Controls.Add(btnHuy);
            guna2Panel3.Controls.Add(btnLuu);
            guna2Panel3.Controls.Add(btnThem);
            guna2Panel3.Controls.Add(btnSua);
            guna2Panel3.Controls.Add(btnXoa);
            guna2Panel3.CustomizableEdges = customizableEdges3;
            guna2Panel3.Location = new Point(428, 12);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel3.Size = new Size(330, 158);
            guna2Panel3.TabIndex = 64;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(225, 44);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 57;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuatKenh_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(225, 73);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 56;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhapKenh_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(225, 102);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 22);
            btnTimKiem.TabIndex = 55;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(120, 102);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(39, 102);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 53;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(120, 44);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 49;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(39, 44);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(120, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 50;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(39, 73);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 51;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = guna2Panel1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 20;
            guna2Elipse2.TargetControl = guna2Panel3;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 20;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 20;
            guna2Elipse4.TargetControl = this;
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
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { KenhId, TenKenh, NenTang, UrlKenh, SoLuongNguoiDangKy, TongLuotXem, DangHoatDong, TenIdol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.Location = new Point(12, 187);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.Size = new Size(746, 268);
            dgvDanhSach.TabIndex = 65;
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
            dgvDanhSach.ThemeStyle.ReadOnly = true;
            dgvDanhSach.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDanhSach.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSach.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSach.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSach.ThemeStyle.RowsStyle.Height = 25;
            dgvDanhSach.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // KenhId
            // 
            KenhId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            KenhId.DataPropertyName = "KenhId";
            KenhId.FillWeight = 30.23396F;
            KenhId.HeaderText = "ID";
            KenhId.Name = "KenhId";
            KenhId.ReadOnly = true;
            KenhId.Width = 40;
            // 
            // TenKenh
            // 
            TenKenh.DataPropertyName = "TenKenh";
            TenKenh.FillWeight = 105.886612F;
            TenKenh.HeaderText = "Tên Channel";
            TenKenh.Name = "TenKenh";
            TenKenh.ReadOnly = true;
            // 
            // NenTang
            // 
            NenTang.DataPropertyName = "NenTang";
            NenTang.FillWeight = 116.135887F;
            NenTang.HeaderText = "Nền tảng";
            NenTang.Name = "NenTang";
            NenTang.ReadOnly = true;
            // 
            // UrlKenh
            // 
            UrlKenh.DataPropertyName = "UrlKenh";
            UrlKenh.FillWeight = 123.667236F;
            UrlKenh.HeaderText = "Đường dẫn";
            UrlKenh.Name = "UrlKenh";
            UrlKenh.ReadOnly = true;
            // 
            // SoLuongNguoiDangKy
            // 
            SoLuongNguoiDangKy.DataPropertyName = "SoLuongNguoiDangKy";
            SoLuongNguoiDangKy.FillWeight = 122.574219F;
            SoLuongNguoiDangKy.HeaderText = "Số người đăng ký";
            SoLuongNguoiDangKy.Name = "SoLuongNguoiDangKy";
            SoLuongNguoiDangKy.ReadOnly = true;
            // 
            // TongLuotXem
            // 
            TongLuotXem.DataPropertyName = "TongLuotXem";
            TongLuotXem.FillWeight = 91.76722F;
            TongLuotXem.HeaderText = "Lượt xem";
            TongLuotXem.Name = "TongLuotXem";
            TongLuotXem.ReadOnly = true;
            // 
            // DangHoatDong
            // 
            DangHoatDong.DataPropertyName = "DangHoatDong";
            DangHoatDong.FillWeight = 103.063454F;
            DangHoatDong.HeaderText = "Tình trạng";
            DangHoatDong.Name = "DangHoatDong";
            DangHoatDong.ReadOnly = true;
            // 
            // TenIdol
            // 
            TenIdol.DataPropertyName = "TenIdol";
            TenIdol.FillWeight = 106.67144F;
            TenIdol.HeaderText = "Thuộc về...";
            TenIdol.Name = "TenIdol";
            TenIdol.ReadOnly = true;
            // 
            // frmKenh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(770, 467);
            ControlBox = false;
            Controls.Add(dgvDanhSach);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmKenh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kênh";
            Load += frmKenh_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLuotXem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLuotDangKy).EndInit();
            guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ComboBox cbTinhTrangKenh;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtTenKenh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSach;
        private ComboBox cbNenTang;
        private Label label5;
        private TextBox txtUrl;
        private ComboBox cbChuKenh;
        private Label label3;
        private Label label6;
        private NumericUpDown nudLuotXem;
        private NumericUpDown nudLuotDangKy;
        private Label label7;
        private DataGridViewTextBoxColumn KenhId;
        private DataGridViewTextBoxColumn TenKenh;
        private DataGridViewTextBoxColumn NenTang;
        private DataGridViewTextBoxColumn UrlKenh;
        private DataGridViewTextBoxColumn SoLuongNguoiDangKy;
        private DataGridViewTextBoxColumn TongLuotXem;
        private DataGridViewTextBoxColumn DangHoatDong;
        private DataGridViewTextBoxColumn TenIdol;
    }
}
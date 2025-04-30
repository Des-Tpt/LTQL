namespace QLTT.Forms
{
    partial class frmIdol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdol));
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cbChiNhanh = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cbTrangThai = new ComboBox();
            txtMoTa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtpNgayDebut = new DateTimePicker();
            label1 = new Label();
            txtTen = new TextBox();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            dgvDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            IdolId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            NgayRaMat = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            TenCongTy = new DataGridViewTextBoxColumn();
            guna2Panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
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
            guna2Panel3.CustomizableEdges = customizableEdges1;
            guna2Panel3.Location = new Point(463, 12);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel3.Size = new Size(295, 180);
            guna2Panel3.TabIndex = 63;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(205, 47);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 57;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(205, 76);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 56;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(205, 105);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 22);
            btnTimKiem.TabIndex = 55;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(100, 105);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(19, 105);
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
            btnLuu.Location = new Point(100, 47);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 49;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(100, 76);
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
            btnXoa.Location = new Point(19, 76);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 51;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = guna2Panel1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(cbChiNhanh);
            guna2Panel1.Controls.Add(label5);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(cbTrangThai);
            guna2Panel1.Controls.Add(txtMoTa);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(dtpNgayDebut);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(txtTen);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(12, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(445, 180);
            guna2Panel1.TabIndex = 61;
            // 
            // cbChiNhanh
            // 
            cbChiNhanh.FormattingEnabled = true;
            cbChiNhanh.Items.AddRange(new object[] { "Đang hoạt động", "Nghỉ ngơi", "Tạm đình chỉ", "Tốt nghiệp" });
            cbChiNhanh.Location = new Point(131, 136);
            cbChiNhanh.Margin = new Padding(2);
            cbChiNhanh.Name = "cbChiNhanh";
            cbChiNhanh.Size = new Size(299, 23);
            cbChiNhanh.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 139);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 68;
            label5.Text = "Trực thuộc chi nhánh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 113);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 67;
            label6.Text = "Trạng thái hoạt động:";
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Tạm ngưng", "Tốt nghiệp" });
            cbTrangThai.Location = new Point(131, 109);
            cbTrangThai.Margin = new Padding(2);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(299, 23);
            cbTrangThai.TabIndex = 66;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(101, 81);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(329, 23);
            txtMoTa.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 84);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 62;
            label3.Text = "Mô tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 61;
            label2.Text = "Ngày ra mắt:";
            // 
            // dtpNgayDebut
            // 
            dtpNgayDebut.Format = DateTimePickerFormat.Short;
            dtpNgayDebut.Location = new Point(100, 53);
            dtpNgayDebut.MaxDate = new DateTime(2029, 12, 31, 0, 0, 0, 0);
            dtpNgayDebut.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpNgayDebut.Name = "dtpNgayDebut";
            dtpNgayDebut.Size = new Size(113, 23);
            dtpNgayDebut.TabIndex = 60;
            dtpNgayDebut.Value = new DateTime(2025, 4, 12, 9, 28, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 59;
            label1.Text = "Tên tài năng:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(101, 24);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(329, 23);
            txtTen.TabIndex = 58;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 10;
            guna2Elipse3.TargetControl = guna2Panel3;
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
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { IdolId, dataGridViewTextBoxColumn1, NgayRaMat, MoTa, dataGridViewTextBoxColumn2, TenCongTy });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.Location = new Point(12, 198);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.Size = new Size(746, 299);
            dgvDanhSach.TabIndex = 66;
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
            // IdolId
            // 
            IdolId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IdolId.DataPropertyName = "IdolId";
            IdolId.FillWeight = 30.23396F;
            IdolId.HeaderText = "ID";
            IdolId.Name = "IdolId";
            IdolId.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "TenIdol";
            dataGridViewTextBoxColumn1.FillWeight = 99.26425F;
            dataGridViewTextBoxColumn1.HeaderText = "Tên tài năng";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // NgayRaMat
            // 
            NgayRaMat.DataPropertyName = "NgayRaMat";
            NgayRaMat.FillWeight = 108.8725F;
            NgayRaMat.HeaderText = "Ngày ra mắt";
            NgayRaMat.Name = "NgayRaMat";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.FillWeight = 178.983765F;
            MoTa.HeaderText = "Mô tả";
            MoTa.Name = "MoTa";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "DangHoatDong";
            dataGridViewTextBoxColumn2.FillWeight = 96.61765F;
            dataGridViewTextBoxColumn2.HeaderText = "Tình trạng hoạt động";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // TenCongTy
            // 
            TenCongTy.DataPropertyName = "TenCongTy";
            TenCongTy.FillWeight = 86.02793F;
            TenCongTy.HeaderText = "Trực thuộc";
            TenCongTy.Name = "TenCongTy";
            // 
            // frmIdol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(770, 509);
            ControlBox = false;
            Controls.Add(dgvDanhSach);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmIdol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tài năng";
            Load += frmIdol_Load;
            guna2Panel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtQuocGia;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private ComboBox cbChiNhanh;
        private Label label5;
        private Label label6;
        private ComboBox cbTrangThai;
        private TextBox txtMoTa;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayDebut;
        private Label label1;
        private TextBox txtTen;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSach;
        private DataGridViewTextBoxColumn IdolId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn NgayRaMat;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn TenCongTy;
    }
}
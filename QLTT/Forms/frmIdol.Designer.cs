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
            grpThanTuong = new GroupBox();
            rbtTinhTrangHoatDong = new RadioButton();
            label4 = new Label();
            txtMoTa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnXuat = new Button();
            dtpNgayDebut = new DateTimePicker();
            btnNhap = new Button();
            label1 = new Label();
            btnTimKiem = new Button();
            btnThoat = new Button();
            txtTenIdol = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            grpDanhSach = new GroupBox();
            dgvDanhSach = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenIdol = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            NgayRaMat = new DataGridViewTextBoxColumn();
            TinhTrangHoatDong = new DataGridViewTextBoxColumn();
            grpThanTuong.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // grpThanTuong
            // 
            grpThanTuong.Controls.Add(rbtTinhTrangHoatDong);
            grpThanTuong.Controls.Add(label4);
            grpThanTuong.Controls.Add(txtMoTa);
            grpThanTuong.Controls.Add(label3);
            grpThanTuong.Controls.Add(label2);
            grpThanTuong.Controls.Add(btnXuat);
            grpThanTuong.Controls.Add(dtpNgayDebut);
            grpThanTuong.Controls.Add(btnNhap);
            grpThanTuong.Controls.Add(label1);
            grpThanTuong.Controls.Add(btnTimKiem);
            grpThanTuong.Controls.Add(btnThoat);
            grpThanTuong.Controls.Add(txtTenIdol);
            grpThanTuong.Controls.Add(btnHuy);
            grpThanTuong.Controls.Add(btnLuu);
            grpThanTuong.Controls.Add(btnThem);
            grpThanTuong.Controls.Add(btnSua);
            grpThanTuong.Controls.Add(btnXoa);
            grpThanTuong.Location = new Point(0, 3);
            grpThanTuong.Name = "grpThanTuong";
            grpThanTuong.Size = new Size(739, 168);
            grpThanTuong.TabIndex = 4;
            grpThanTuong.TabStop = false;
            grpThanTuong.Text = "Thông tin thần tượng";
            // 
            // rbtTinhTrangHoatDong
            // 
            rbtTinhTrangHoatDong.AutoSize = true;
            rbtTinhTrangHoatDong.Location = new Point(193, 133);
            rbtTinhTrangHoatDong.Name = "rbtTinhTrangHoatDong";
            rbtTinhTrangHoatDong.Size = new Size(133, 19);
            rbtTinhTrangHoatDong.TabIndex = 1;
            rbtTinhTrangHoatDong.TabStop = true;
            rbtTinhTrangHoatDong.Text = "Vẫn đang hoạt động";
            rbtTinhTrangHoatDong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 135);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 27;
            label4.Text = "-Tình trạng hoạt động:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(193, 97);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(244, 23);
            txtMoTa.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 100);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 25;
            label3.Text = "-Mô tả chi tiết thần tượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 69);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 24;
            label2.Text = "-Ngày ra mắt chính thức:";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(656, 92);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 23;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // dtpNgayDebut
            // 
            dtpNgayDebut.Format = DateTimePickerFormat.Short;
            dtpNgayDebut.Location = new Point(193, 63);
            dtpNgayDebut.MaxDate = new DateTime(2029, 12, 31, 0, 0, 0, 0);
            dtpNgayDebut.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpNgayDebut.Name = "dtpNgayDebut";
            dtpNgayDebut.Size = new Size(244, 23);
            dtpNgayDebut.TabIndex = 11;
            dtpNgayDebut.Value = new DateTime(2025, 4, 12, 9, 28, 0, 0);
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(656, 63);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 22;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 10;
            label1.Text = "-Tên của thần tượng:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(656, 34);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(540, 92);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTenIdol
            // 
            txtTenIdol.Location = new Point(193, 31);
            txtTenIdol.Name = "txtTenIdol";
            txtTenIdol.Size = new Size(244, 23);
            txtTenIdol.TabIndex = 2;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(540, 63);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(540, 34);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(459, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(459, 63);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(459, 92);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvDanhSach);
            grpDanhSach.Location = new Point(0, 177);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(742, 248);
            grpDanhSach.TabIndex = 5;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách loại sản phẩm";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AllowUserToDeleteRows = false;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { ID, TenIdol, MoTa, NgayRaMat, TinhTrangHoatDong });
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 19);
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.Size = new Size(736, 226);
            dgvDanhSach.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "IdolId";
            ID.FillWeight = 25.38071F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenIdol
            // 
            TenIdol.DataPropertyName = "TenIdol";
            TenIdol.FillWeight = 118.654823F;
            TenIdol.HeaderText = "Tên thần tượng";
            TenIdol.Name = "TenIdol";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.FillWeight = 118.654823F;
            MoTa.HeaderText = "Mô tả";
            MoTa.Name = "MoTa";
            // 
            // NgayRaMat
            // 
            NgayRaMat.DataPropertyName = "NgayRaMat";
            NgayRaMat.FillWeight = 118.654823F;
            NgayRaMat.HeaderText = "Ngày ra mắt chính thức";
            NgayRaMat.Name = "NgayRaMat";
            // 
            // TinhTrangHoatDong
            // 
            TinhTrangHoatDong.DataPropertyName = "TinhTrangHoatDong";
            TinhTrangHoatDong.FillWeight = 118.654823F;
            TinhTrangHoatDong.HeaderText = "Tình trạng hoạt động";
            TinhTrangHoatDong.Name = "TinhTrangHoatDong";
            // 
            // frmIdol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 423);
            Controls.Add(grpThanTuong);
            Controls.Add(grpDanhSach);
            Name = "frmIdol";
            Text = "Thần tượng";
            Load += frmIdol_Load;
            grpThanTuong.ResumeLayout(false);
            grpThanTuong.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThanTuong;
        private TextBox txtTenIdol;
        private GroupBox grpDanhSach;
        private DataGridView dgvDanhSach;
        private Label label1;
        private DateTimePicker dtpNgayDebut;
        private Label label2;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMoTa;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenIdol;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn NgayRaMat;
        private DataGridViewTextBoxColumn TinhTrangHoatDong;
        private RadioButton rbtTinhTrangHoatDong;
    }
}
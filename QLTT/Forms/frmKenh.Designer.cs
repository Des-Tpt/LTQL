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
            txtQuocGia = new TextBox();
            label4 = new Label();
            txtMoTa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtpNgayThanhLap = new DateTimePicker();
            grpCongTy = new GroupBox();
            btnXuat = new Button();
            btnNhap = new Button();
            label1 = new Label();
            btnTimKiem = new Button();
            btnThoat = new Button();
            txtTenCongTy = new TextBox();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            QuocGia = new DataGridViewTextBoxColumn();
            NgayThanhLap = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            TenCongTy = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            dgvDanhSach = new DataGridView();
            grpDanhSach = new GroupBox();
            grpCongTy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            grpDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuocGia
            // 
            txtQuocGia.Location = new Point(193, 126);
            txtQuocGia.Name = "txtQuocGia";
            txtQuocGia.Size = new Size(244, 23);
            txtQuocGia.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 129);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 27;
            label4.Text = "-Quốc gia trực thuộc:";
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
            label3.Size = new Size(128, 15);
            label3.TabIndex = 25;
            label3.Text = "-Mô tả chi tiết công ty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 72);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 24;
            label2.Text = "-Ngày thành lập:";
            // 
            // dtpNgayThanhLap
            // 
            dtpNgayThanhLap.Format = DateTimePickerFormat.Short;
            dtpNgayThanhLap.Location = new Point(193, 68);
            dtpNgayThanhLap.MaxDate = new DateTime(2029, 12, 31, 0, 0, 0, 0);
            dtpNgayThanhLap.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpNgayThanhLap.Name = "dtpNgayThanhLap";
            dtpNgayThanhLap.Size = new Size(244, 23);
            dtpNgayThanhLap.TabIndex = 11;
            dtpNgayThanhLap.Value = new DateTime(2025, 4, 12, 9, 28, 0, 0);
            // 
            // grpCongTy
            // 
            grpCongTy.Controls.Add(txtQuocGia);
            grpCongTy.Controls.Add(label4);
            grpCongTy.Controls.Add(txtMoTa);
            grpCongTy.Controls.Add(label3);
            grpCongTy.Controls.Add(label2);
            grpCongTy.Controls.Add(btnXuat);
            grpCongTy.Controls.Add(dtpNgayThanhLap);
            grpCongTy.Controls.Add(btnNhap);
            grpCongTy.Controls.Add(label1);
            grpCongTy.Controls.Add(btnTimKiem);
            grpCongTy.Controls.Add(btnThoat);
            grpCongTy.Controls.Add(txtTenCongTy);
            grpCongTy.Controls.Add(btnHuy);
            grpCongTy.Controls.Add(btnLuu);
            grpCongTy.Controls.Add(btnThem);
            grpCongTy.Controls.Add(btnSua);
            grpCongTy.Controls.Add(btnXoa);
            grpCongTy.Location = new Point(0, 1);
            grpCongTy.Name = "grpCongTy";
            grpCongTy.Size = new Size(736, 168);
            grpCongTy.TabIndex = 8;
            grpCongTy.TabStop = false;
            grpCongTy.Text = "Thông tin thần tượng";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(655, 97);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 23;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(655, 68);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 22;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 10;
            label1.Text = "-Tên công ty:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(655, 39);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(539, 97);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Location = new Point(193, 39);
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(244, 23);
            txtTenCongTy.TabIndex = 2;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(539, 68);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = SystemColors.Highlight;
            btnLuu.Location = new Point(539, 39);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(458, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(458, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(458, 97);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // QuocGia
            // 
            QuocGia.DataPropertyName = "QuocGia";
            QuocGia.FillWeight = 118.654823F;
            QuocGia.HeaderText = "Quốc gia trực thuộc";
            QuocGia.Name = "QuocGia";
            // 
            // NgayThanhLap
            // 
            NgayThanhLap.DataPropertyName = "NgayThanhLap";
            NgayThanhLap.FillWeight = 118.654823F;
            NgayThanhLap.HeaderText = "Ngày thành lập";
            NgayThanhLap.Name = "NgayThanhLap";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.FillWeight = 118.654823F;
            MoTa.HeaderText = "Mô tả";
            MoTa.Name = "MoTa";
            // 
            // TenCongTy
            // 
            TenCongTy.DataPropertyName = "TenCongTy";
            TenCongTy.FillWeight = 118.654823F;
            TenCongTy.HeaderText = "Tên công ty";
            TenCongTy.Name = "TenCongTy";
            // 
            // ID
            // 
            ID.DataPropertyName = "CongTyId";
            ID.FillWeight = 25.38071F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AllowUserToDeleteRows = false;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { ID, TenCongTy, MoTa, NgayThanhLap, QuocGia });
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 19);
            dgvDanhSach.MultiSelect = false;
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.Size = new Size(733, 226);
            dgvDanhSach.TabIndex = 0;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvDanhSach);
            grpDanhSach.Location = new Point(0, 175);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(739, 248);
            grpDanhSach.TabIndex = 9;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách loại sản phẩm";
            // 
            // Kenh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 423);
            Controls.Add(grpCongTy);
            Controls.Add(grpDanhSach);
            Name = "Kenh";
            Text = "Kenh";
            grpCongTy.ResumeLayout(false);
            grpCongTy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            grpDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtQuocGia;
        private Label label4;
        private TextBox txtMoTa;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayThanhLap;
        private GroupBox grpCongTy;
        private Button btnXuat;
        private Button btnNhap;
        private Label label1;
        private Button btnTimKiem;
        private Button btnThoat;
        private TextBox txtTenCongTy;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridViewTextBoxColumn QuocGia;
        private DataGridViewTextBoxColumn NgayThanhLap;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn TenCongTy;
        private DataGridViewTextBoxColumn ID;
        private DataGridView dgvDanhSach;
        private GroupBox grpDanhSach;
    }
}
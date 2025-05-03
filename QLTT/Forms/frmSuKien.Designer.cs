namespace QLTT
{
    partial class frmSuKien
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
            dgvDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            SuKienId = new DataGridViewTextBoxColumn();
            TenSuKien = new DataGridViewTextBoxColumn();
            DiaDiem = new DataGridViewTextBoxColumn();
            NgayToChuc = new DataGridViewTextBoxColumn();
            TenNhaTaiTro = new DataGridViewTextBoxColumn();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
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
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cbNhaTaiTro = new ComboBox();
            label3 = new Label();
            dtpThoiDiem = new DateTimePicker();
            label6 = new Label();
            txtDiaDiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtTenSuKien = new TextBox();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            guna2Panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
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
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { SuKienId, TenSuKien, DiaDiem, NgayToChuc, TenNhaTaiTro });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.Location = new Point(14, 154);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.RowHeadersWidth = 72;
            dgvDanhSach.Size = new Size(744, 355);
            dgvDanhSach.TabIndex = 68;
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
            // SuKienId
            // 
            SuKienId.DataPropertyName = "SuKienId";
            SuKienId.FillWeight = 35.6674538F;
            SuKienId.HeaderText = "ID";
            SuKienId.Name = "SuKienId";
            SuKienId.ReadOnly = true;
            // 
            // TenSuKien
            // 
            TenSuKien.DataPropertyName = "TenSuKien";
            TenSuKien.FillWeight = 156.204391F;
            TenSuKien.HeaderText = "Tên sự kiện";
            TenSuKien.MinimumWidth = 9;
            TenSuKien.Name = "TenSuKien";
            TenSuKien.ReadOnly = true;
            // 
            // DiaDiem
            // 
            DiaDiem.DataPropertyName = "DiaDiem";
            DiaDiem.FillWeight = 182.434448F;
            DiaDiem.HeaderText = "Địa điểm";
            DiaDiem.MinimumWidth = 9;
            DiaDiem.Name = "DiaDiem";
            DiaDiem.ReadOnly = true;
            // 
            // NgayToChuc
            // 
            NgayToChuc.DataPropertyName = "NgayToChuc";
            NgayToChuc.FillWeight = 93.74133F;
            NgayToChuc.HeaderText = "Thời gian diễn ra";
            NgayToChuc.MinimumWidth = 9;
            NgayToChuc.Name = "NgayToChuc";
            NgayToChuc.ReadOnly = true;
            // 
            // TenNhaTaiTro
            // 
            TenNhaTaiTro.DataPropertyName = "TenNhaTaiTro";
            TenNhaTaiTro.FillWeight = 84.0804138F;
            TenNhaTaiTro.HeaderText = "Nhà tài trợ";
            TenNhaTaiTro.Name = "TenNhaTaiTro";
            TenNhaTaiTro.ReadOnly = true;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 20;
            guna2Elipse4.TargetControl = dgvDanhSach;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 20;
            guna2Elipse3.TargetControl = guna2Panel3;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(btnReset);
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
            guna2Panel3.Location = new Point(397, 8);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel3.Size = new Size(361, 140);
            guna2Panel3.TabIndex = 67;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(41, 102);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 57;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(122, 102);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 56;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(254, 74);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 22);
            btnTimKiem.TabIndex = 55;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(122, 73);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(41, 73);
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
            btnLuu.Location = new Point(122, 15);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 49;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(122, 44);
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
            btnXoa.Location = new Point(41, 44);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 51;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 20;
            guna2Elipse2.TargetControl = guna2Panel3;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = guna2Panel1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(cbNhaTaiTro);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(dtpThoiDiem);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(txtDiaDiem);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(txtTenSuKien);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(14, 8);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(372, 140);
            guna2Panel1.TabIndex = 66;
            // 
            // cbNhaTaiTro
            // 
            cbNhaTaiTro.FormattingEnabled = true;
            cbNhaTaiTro.Location = new Point(86, 103);
            cbNhaTaiTro.Name = "cbNhaTaiTro";
            cbNhaTaiTro.Size = new Size(272, 23);
            cbNhaTaiTro.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 106);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 50;
            label3.Text = "Nhà tài trợ:";
            // 
            // dtpThoiDiem
            // 
            dtpThoiDiem.Format = DateTimePickerFormat.Custom;
            dtpThoiDiem.Location = new Point(115, 68);
            dtpThoiDiem.Margin = new Padding(2);
            dtpThoiDiem.Name = "dtpThoiDiem";
            dtpThoiDiem.Size = new Size(243, 23);
            dtpThoiDiem.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 74);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 46;
            label6.Text = "Thời gian diễn ra:";
            // 
            // txtDiaDiem
            // 
            txtDiaDiem.Location = new Point(99, 40);
            txtDiaDiem.Name = "txtDiaDiem";
            txtDiaDiem.Size = new Size(259, 23);
            txtDiaDiem.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 43);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 36;
            label2.Text = "Địa điểm:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 34;
            label1.Text = "Tên sự kiện:";
            // 
            // txtTenSuKien
            // 
            txtTenSuKien.Location = new Point(99, 11);
            txtTenSuKien.Name = "txtTenSuKien";
            txtTenSuKien.Size = new Size(259, 23);
            txtTenSuKien.TabIndex = 33;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(254, 102);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 22);
            btnReset.TabIndex = 58;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // frmSuKien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 521);
            ControlBox = false;
            Controls.Add(dgvDanhSach);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmSuKien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sự kiện";
            Load += frmSuKien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            guna2Panel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSach;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label6;
        private TextBox txtDiaDiem;
        private Label label2;
        private Label label1;
        private TextBox txtTenSuKien;
        private DateTimePicker dtpThoiDiem;
        private ComboBox cbNhaTaiTro;
        private Label label3;
        private DataGridViewTextBoxColumn SuKienId;
        private DataGridViewTextBoxColumn TenSuKien;
        private DataGridViewTextBoxColumn DiaDiem;
        private DataGridViewTextBoxColumn NgayToChuc;
        private DataGridViewTextBoxColumn TenNhaTaiTro;
        private Button btnReset;
    }
}
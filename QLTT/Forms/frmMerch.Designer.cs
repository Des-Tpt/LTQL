namespace QLTT.Forms
{
    partial class frmMerch
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cbIdol = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            nudGiaBan = new NumericUpDown();
            dtpNgayBan = new DateTimePicker();
            label6 = new Label();
            label1 = new Label();
            txtTenHangHoa = new TextBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnXoa = new Button();
            dgvDanhSach = new Guna.UI2.WinForms.Guna2DataGridView();
            MerchId = new DataGridViewTextBoxColumn();
            TenMerch = new DataGridViewTextBoxColumn();
            NgayPhatHanh = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            TenIdol = new DataGridViewTextBoxColumn();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            pcHinhAnh = new PictureBox();
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            btnChonAnh = new Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnSua = new Button();
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcHinhAnh).BeginInit();
            guna2Panel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(cbIdol);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(nudGiaBan);
            guna2Panel1.Controls.Add(dtpNgayBan);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(txtTenHangHoa);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(12, 8);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(314, 155);
            guna2Panel1.TabIndex = 69;
            // 
            // cbIdol
            // 
            cbIdol.FormattingEnabled = true;
            cbIdol.Location = new Point(134, 109);
            cbIdol.Name = "cbIdol";
            cbIdol.Size = new Size(148, 23);
            cbIdol.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 112);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 52;
            label3.Text = "Dựa trên nhân vật:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 51;
            label2.Text = "Giá bán:";
            // 
            // nudGiaBan
            // 
            nudGiaBan.Location = new Point(80, 80);
            nudGiaBan.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudGiaBan.Name = "nudGiaBan";
            nudGiaBan.Size = new Size(202, 23);
            nudGiaBan.TabIndex = 50;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Format = DateTimePickerFormat.Short;
            dtpNgayBan.Location = new Point(113, 52);
            dtpNgayBan.Margin = new Padding(2);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(169, 23);
            dtpNgayBan.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 56);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 46;
            label6.Text = "Ngày mở bán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 34;
            label1.Text = "Tên merch:";
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Location = new Point(97, 24);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.Size = new Size(185, 23);
            txtTenHangHoa.TabIndex = 33;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 20;
            guna2Elipse1.TargetControl = guna2Panel1;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(63, 65);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 51;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
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
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { MerchId, TenMerch, NgayPhatHanh, GiaBan, HinhAnh, TenIdol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.Location = new Point(12, 169);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.RowHeadersWidth = 72;
            dgvDanhSach.Size = new Size(747, 334);
            dgvDanhSach.TabIndex = 71;
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
            dgvDanhSach.CellFormatting += dgvDanhSach_CellFormatting;
            // 
            // MerchId
            // 
            MerchId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MerchId.DataPropertyName = "MerchId";
            MerchId.FillWeight = 30.23396F;
            MerchId.HeaderText = "ID";
            MerchId.MinimumWidth = 9;
            MerchId.Name = "MerchId";
            MerchId.ReadOnly = true;
            MerchId.Width = 40;
            // 
            // TenMerch
            // 
            TenMerch.DataPropertyName = "TenMerch";
            TenMerch.FillWeight = 116.135887F;
            TenMerch.HeaderText = "Tên hàng hóa";
            TenMerch.MinimumWidth = 9;
            TenMerch.Name = "TenMerch";
            TenMerch.ReadOnly = true;
            // 
            // NgayPhatHanh
            // 
            NgayPhatHanh.DataPropertyName = "NgayPhatHanh";
            NgayPhatHanh.HeaderText = "Ngày mở bán";
            NgayPhatHanh.Name = "NgayPhatHanh";
            NgayPhatHanh.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá bán";
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TenIdol
            // 
            TenIdol.DataPropertyName = "TenIdol";
            TenIdol.HeaderText = "Dựa trên";
            TenIdol.Name = "TenIdol";
            TenIdol.ReadOnly = true;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 20;
            guna2Elipse4.TargetControl = this;
            // 
            // pcHinhAnh
            // 
            pcHinhAnh.BackColor = SystemColors.Control;
            pcHinhAnh.Location = new Point(3, 4);
            pcHinhAnh.Name = "pcHinhAnh";
            pcHinhAnh.Size = new Size(139, 116);
            pcHinhAnh.TabIndex = 0;
            pcHinhAnh.TabStop = false;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 20;
            guna2Elipse3.TargetControl = guna2Panel2;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.White;
            guna2Panel2.Controls.Add(btnChonAnh);
            guna2Panel2.Controls.Add(pcHinhAnh);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(335, 8);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(145, 155);
            guna2Panel2.TabIndex = 72;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(36, 126);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(75, 23);
            btnChonAnh.TabIndex = 58;
            btnChonAnh.Text = "Chọn ảnh:";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 20;
            guna2Elipse2.TargetControl = guna2Panel3;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(btnThoat);
            guna2Panel3.Controls.Add(btnHuy);
            guna2Panel3.Controls.Add(btnLuu);
            guna2Panel3.Controls.Add(btnThem);
            guna2Panel3.Controls.Add(btnSua);
            guna2Panel3.Controls.Add(btnXoa);
            guna2Panel3.CustomizableEdges = customizableEdges5;
            guna2Panel3.Location = new Point(490, 8);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel3.Size = new Size(269, 155);
            guna2Panel3.TabIndex = 70;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(144, 101);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(63, 101);
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
            btnLuu.Location = new Point(144, 28);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 49;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(63, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(144, 65);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 50;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 20;
            guna2Elipse5.TargetControl = guna2Panel3;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 20;
            guna2Elipse6.TargetControl = dgvDanhSach;
            // 
            // guna2Elipse7
            // 
            guna2Elipse7.BorderRadius = 20;
            guna2Elipse7.TargetControl = pcHinhAnh;
            // 
            // frmMerch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 516);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Controls.Add(dgvDanhSach);
            Controls.Add(guna2Panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmMerch";
            Text = "Hàng lưu niệm";
            Load += frmMerch_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcHinhAnh).EndInit();
            guna2Panel2.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private DateTimePicker dtpNgayBan;
        private Label label6;
        private Label label1;
        private TextBox txtTenHangHoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Button btnXoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSach;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnThem;
        private Button btnSua;
        private Label label2;
        private NumericUpDown nudGiaBan;
        private ComboBox cbIdol;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PictureBox pcHinhAnh;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Button btnChonAnh;
        private DataGridViewTextBoxColumn MerchId;
        private DataGridViewTextBoxColumn TenMerch;
        private DataGridViewTextBoxColumn NgayPhatHanh;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewTextBoxColumn TenIdol;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
    }
}
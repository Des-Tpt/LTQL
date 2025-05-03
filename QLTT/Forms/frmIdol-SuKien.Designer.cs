namespace QLTT.Forms
{
    partial class Idol_SuKien
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
            NguoiThamGia = new DataGridViewTextBoxColumn();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            btnThoat = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            cbTenSuKien = new ComboBox();
            groupBox1 = new GroupBox();
            clbIdolThamGia = new CheckedListBox();
            btnTimKiem = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            guna2Panel3.SuspendLayout();
            guna2Panel1.SuspendLayout();
            groupBox1.SuspendLayout();
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
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { SuKienId, TenSuKien, DiaDiem, NgayToChuc, NguoiThamGia });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSach.Location = new Point(10, 176);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.Size = new Size(746, 330);
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
            SuKienId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SuKienId.DataPropertyName = "SuKienId";
            SuKienId.FillWeight = 30.23396F;
            SuKienId.HeaderText = "ID";
            SuKienId.Name = "SuKienId";
            SuKienId.ReadOnly = true;
            SuKienId.Width = 40;
            // 
            // TenSuKien
            // 
            TenSuKien.DataPropertyName = "TenSuKien";
            TenSuKien.HeaderText = "Tên Sự Kiện";
            TenSuKien.Name = "TenSuKien";
            TenSuKien.ReadOnly = true;
            // 
            // DiaDiem
            // 
            DiaDiem.DataPropertyName = "DiaDiem";
            DiaDiem.HeaderText = "Địa Điểm";
            DiaDiem.Name = "DiaDiem";
            DiaDiem.ReadOnly = true;
            // 
            // NgayToChuc
            // 
            NgayToChuc.DataPropertyName = "NgayToChuc";
            NgayToChuc.HeaderText = "Ngày Tổ Chức";
            NgayToChuc.Name = "NgayToChuc";
            NgayToChuc.ReadOnly = true;
            // 
            // NguoiThamGia
            // 
            NguoiThamGia.DataPropertyName = "NguoiThamGia";
            NguoiThamGia.HeaderText = "Người Tham Gia";
            NguoiThamGia.Name = "NguoiThamGia";
            NguoiThamGia.ReadOnly = true;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 20;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 20;
            guna2Elipse3.TargetControl = dgvDanhSach;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 20;
            guna2Elipse2.TargetControl = guna2Panel3;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BackColor = Color.White;
            guna2Panel3.Controls.Add(btnReset);
            guna2Panel3.Controls.Add(btnTimKiem);
            guna2Panel3.Controls.Add(btnThoat);
            guna2Panel3.Controls.Add(btnHuy);
            guna2Panel3.Controls.Add(btnLuu);
            guna2Panel3.Controls.Add(btnThem);
            guna2Panel3.Controls.Add(btnSua);
            guna2Panel3.Controls.Add(btnXoa);
            guna2Panel3.CustomizableEdges = customizableEdges1;
            guna2Panel3.Location = new Point(485, 12);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel3.Size = new Size(271, 158);
            guna2Panel3.TabIndex = 67;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(101, 95);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(20, 95);
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
            btnLuu.Location = new Point(101, 37);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 49;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 37);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 52;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(101, 66);
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
            btnXoa.Location = new Point(20, 66);
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
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(cbTenSuKien);
            guna2Panel1.Controls.Add(groupBox1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(10, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(469, 158);
            guna2Panel1.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 10);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Sự kiện:";
            // 
            // cbTenSuKien
            // 
            cbTenSuKien.FormattingEnabled = true;
            cbTenSuKien.Location = new Point(21, 36);
            cbTenSuKien.Name = "cbTenSuKien";
            cbTenSuKien.Size = new Size(177, 23);
            cbTenSuKien.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clbIdolThamGia);
            groupBox1.Location = new Point(217, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các idol tham gia:";
            // 
            // clbIdolThamGia
            // 
            clbIdolThamGia.FormattingEnabled = true;
            clbIdolThamGia.Location = new Point(6, 26);
            clbIdolThamGia.Name = "clbIdolThamGia";
            clbIdolThamGia.Size = new Size(227, 94);
            clbIdolThamGia.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(182, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 55;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(182, 66);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 56;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Idol_SuKien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 514);
            Controls.Add(dgvDanhSach);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Idol_SuKien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Idol_SuKien";
            Load += Idol_SuKien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            guna2Panel3.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Button btnXoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private GroupBox groupBox1;
        private CheckedListBox clbIdolThamGia;
        private ComboBox cbTenSuKien;
        private Label label1;
        private DataGridViewTextBoxColumn SuKienId;
        private DataGridViewTextBoxColumn TenSuKien;
        private DataGridViewTextBoxColumn DiaDiem;
        private DataGridViewTextBoxColumn NgayToChuc;
        private DataGridViewTextBoxColumn NguoiThamGia;
        private Button btnReset;
        private Button btnTimKiem;
    }
}
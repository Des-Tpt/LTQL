using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTT.Data;
using ClosedXML.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTT.Forms
{
    public partial class frmIdol : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        int id;
        bool xuLyThem = false;


        private frmNavigation _parent;

        public frmIdol(frmNavigation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void frmIdol_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayChiNhanhVaoComboBox();
            dgvDanhSach.AutoGenerateColumns = false;

            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            List<Idol> idol = new List<Idol>();
            var danhSachIdol = context.Idol
                   .Select(i => new DanhSachIdol
                   {
                       IdolId = i.IdolId,
                       TenIdol = i.TenIdol,
                       NgayRaMat = i.NgayRaMat,
                       MoTa = i.MoTa,
                       DangHoatDong = i.DangHoatDong ?? "Không rõ",
                       CongTyId = i.CongTyId,
                       TenCongTy = i.CongTy.TenCongTy
                   }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachIdol;

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bindingSource, "TenIdol", false, DataSourceUpdateMode.Never);

            dtpNgayDebut.DataBindings.Clear();
            dtpNgayDebut.DataBindings.Add("Value", bindingSource, "NgayRaMat", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            cbTrangThai.DataBindings.Clear();
            cbTrangThai.DataBindings.Add("SelectedItem", bindingSource, "DangHoatDong", false, DataSourceUpdateMode.Never);

            cbChiNhanh.DataBindings.Clear();
            cbChiNhanh.DataBindings.Add("SelectedValue", bindingSource, "CongTyId", false, DataSourceUpdateMode.Never);

            dgvDanhSach.DataSource = bindingSource;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            txtTen.Enabled = giaTri;
            dtpNgayDebut.Enabled = giaTri;
            cbChiNhanh.Enabled = giaTri;
            cbTrangThai.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayChiNhanhVaoComboBox()
        {
            cbChiNhanh.DataSource = context.CongTy.ToList();
            cbChiNhanh.ValueMember = "CongTyId";
            cbChiNhanh.DisplayMember = "TenCongTy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMoTa.Clear();
            txtTen.Clear();
            dtpNgayDebut.Value = DateTime.Today;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text) || cbTrangThai.SelectedIndex == -1 || cbChiNhanh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                Idol idol = new Idol();
                idol.TenIdol = txtTen.Text;
                idol.NgayRaMat = dtpNgayDebut.Value;
                idol.MoTa = txtMoTa.Text;

                idol.DangHoatDong = cbTrangThai.SelectedItem.ToString();
                idol.CongTyId = (int)cbChiNhanh.SelectedValue;

                context.Idol.Add(idol);
                context.SaveChanges();
            }
            else
            {
                Idol idol = context.Idol.Find(id);
                if (idol != null)
                {
                    idol.TenIdol = txtTen.Text;
                    idol.NgayRaMat = dtpNgayDebut.Value;
                    idol.MoTa = txtMoTa.Text;

                    idol.DangHoatDong = cbTrangThai.SelectedItem.ToString();
                    idol.CongTyId = (int)cbChiNhanh.SelectedValue;

                    context.SaveChanges();
                }
            }
            frmIdol_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa idol?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["IdolId"].Value.ToString());
                Idol idol = context.Idol.Find(id);
                if (idol != null)
                {
                    context.Idol.Remove(idol);
                }
                context.SaveChanges();
                frmIdol_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null || dgvDanhSach.CurrentRow.Cells["IdolId"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi thực hiện thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["IdolId"].Value.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Idol từ Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                Idol idol = new Idol
                                {
                                    TenIdol = r["TenIdol"].ToString(),
                                    NgayRaMat = DateTime.Parse(r["NgayRaMat"].ToString()),
                                    MoTa = r["MoTa"].ToString(),
                                    DangHoatDong = r["DangHoatDong"].ToString(),
                                    CongTyId = int.Parse(r["CongTyId"].ToString())
                                };
                                context.Idol.Add(idol);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmIdol_Load(sender, e);
                        }

                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Idol ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSachIdol_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("IdolId", typeof(int)),
                        new DataColumn("TenIdol", typeof(string)),
                        new DataColumn("NgayRaMat", typeof(DateTime)),
                        new DataColumn("MoTa", typeof(string)),
                        new DataColumn("DangHoatDong", typeof(string)),
                        new DataColumn("CongTyId", typeof(int))
                    });

                    var idols = context.Idol.ToList();
                    foreach (var i in idols)
                    {
                        table.Rows.Add(i.IdolId, i.TenIdol, i.NgayRaMat, i.MoTa, i.DangHoatDong, i.CongTyId);
                    }

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add(table, "Idol");
                        sheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _parent.LoadForm(new frmNavigation());
        }
    }
}

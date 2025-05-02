using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using QLTT.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLTT.Forms
{
    public partial class frmDanhTinh : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        int id;
        bool xuLyThem = false;

        private frmNavigation _parent;
        public frmDanhTinh(frmNavigation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void frmDanhTinh_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayIdolVaoComboBox();
            dgvDanhSach.AutoGenerateColumns = false;

            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            List<DanhTinh> danhtinh = new List<DanhTinh>();
            var danhsachDanhtinh = context.DanhTinh
                   .Select(i => new DanhSachDanhTinh
                   {
                       DanhTinhId = i.DanhTinhId,
                       HoTenThat = i.HoTenThat,
                       NgaySinh = i.NgaySinh,
                       DiaChi = i.DiaChi,
                       SoDienThoai = i.SoDienThoai,
                       IdolId = i.IdolId,
                       TenIdol = i.Idol.TenIdol,
                   }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhsachDanhtinh;

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bindingSource, "HoTenThat", false, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);

            cbIdol.DataBindings.Clear();
            cbIdol.DataBindings.Add("SelectedItem", bindingSource, "IdolId", false, DataSourceUpdateMode.Never);

            dgvDanhSach.DataSource = bindingSource;
        }

        public void LayIdolVaoComboBox()
        {
            cbIdol.DataSource = context.Idol.ToList();
            cbIdol.ValueMember = "IdolId";
            cbIdol.DisplayMember = "TenIdol";
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTen.Enabled = giaTri;
            txtSdt.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            cbIdol.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTen.Clear();
            txtDiaChi.Clear();
            txtSdt.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            cbIdol.SelectedIndex = 0;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                DanhTinh dt = new DanhTinh();
                dt.HoTenThat = txtTen.Text;
                dt.NgaySinh = dtpNgaySinh.Value;
                dt.DiaChi = txtDiaChi.Text;
                dt.SoDienThoai = txtSdt.Text;
                dt.IdolId = (int)cbIdol.SelectedValue;

                context.DanhTinh.Add(dt);
            }
            else
            {
                DanhTinh dt = context.DanhTinh.Find(id);
                if (dt != null)
                {
                    dt.HoTenThat = txtTen.Text;
                    dt.NgaySinh = dtpNgaySinh.Value;
                    dt.DiaChi = txtDiaChi.Text;
                    dt.SoDienThoai = txtSdt.Text;
                    dt.IdolId = (int)cbIdol.SelectedValue;
                }
            }

            context.SaveChanges();
            frmDanhTinh_Load(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null || dgvDanhSach.CurrentRow.Cells["DanhTinhId"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["DanhTinhId"].Value.ToString());
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null || dgvDanhSach.CurrentRow.Cells["DanhTinhId"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["DanhTinhId"].Value.ToString());
                var dt = context.DanhTinh.Find(id);
                if (dt != null)
                {
                    context.DanhTinh.Remove(dt);
                    context.SaveChanges();
                    frmDanhTinh_Load(sender, e);
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Danh Tính từ Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";

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
                                DanhTinh dt = new DanhTinh
                                {
                                    HoTenThat = r["HoTenThat"].ToString(),
                                    NgaySinh = DateTime.Parse(r["NgaySinh"].ToString()),
                                    DiaChi = r["DiaChi"].ToString(),
                                    SoDienThoai = r["SoDienThoai"].ToString(),
                                    IdolId = int.Parse(r["IdolId"].ToString())
                                };
                                context.DanhTinh.Add(dt);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDanhTinh_Load(sender, e);
                        }

                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Danh Tính ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSachDanhTinh_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[]
                    {
                new DataColumn("DanhTinhId", typeof(int)),
                new DataColumn("HoTenThat", typeof(string)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("DiaChi", typeof(string)),
                new DataColumn("SoDienThoai", typeof(string)),
                new DataColumn("IdolId", typeof(int))
                    });

                    var danhTinhs = context.DanhTinh.ToList();
                    foreach (var dt in danhTinhs)
                    {
                        table.Rows.Add(dt.DanhTinhId, dt.HoTenThat, dt.NgaySinh, dt.DiaChi, dt.SoDienThoai, dt.IdolId);
                    }

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add(table, "DanhTinh");
                        sheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _parent.LoadForm(new frmNavigation());
        }
    }
}

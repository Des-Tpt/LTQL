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
using QLTT.Data;

namespace QLTT.Forms
{
    public partial class frmCongTy : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        int id;
        bool xuLyThem = false;

        private frmNavigation _parent;

        public frmCongTy(frmNavigation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            List<CongTy> ct = new List<CongTy>();
            ct = context.CongTy.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ct;

            txtTenCongTy.DataBindings.Clear();
            txtTenCongTy.DataBindings.Add("Text", bindingSource, "TenCongTy", false, DataSourceUpdateMode.Never);

            txtQuocGia.DataBindings.Clear();
            txtQuocGia.DataBindings.Add("Text", bindingSource, "QuocGia", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            dtpNgayThanhLap.DataBindings.Clear();
            dtpNgayThanhLap.DataBindings.Add("Value", bindingSource, "NgayThanhLap", false, DataSourceUpdateMode.Never);

            dgvDanhSach.DataSource = bindingSource;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            txtQuocGia.Enabled = giaTri;
            dtpNgayThanhLap.Enabled = giaTri;
            txtTenCongTy.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMoTa.Clear();
            txtQuocGia.Clear();
            txtTenCongTy.Clear();
            dtpNgayThanhLap.Value = DateTime.Today;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi thực hiện thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["CongTyId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa chi nhánh?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["CongTyId"].Value.ToString());
                CongTy ct = context.CongTy.Find(id);
                if (ct != null)
                {
                    context.CongTy.Remove(ct);
                }
                context.SaveChanges();
                frmCongTy_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenCongTy.Text) || string.IsNullOrWhiteSpace(txtQuocGia.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    CongTy ct = new CongTy();
                    ct.TenCongTy = txtTenCongTy.Text;
                    ct.NgayThanhLap = dtpNgayThanhLap.Value;
                    ct.QuocGia = txtQuocGia.Text;
                    ct.MoTa = txtMoTa.Text;
                    context.CongTy.Add(ct);
                    context.SaveChanges();
                }
                else
                {
                    CongTy ct = context.CongTy.Find(id);
                    if (ct != null)
                    {
                        ct.TenCongTy = txtTenCongTy.Text;
                        ct.NgayThanhLap = dtpNgayThanhLap.Value;
                        ct.QuocGia = txtQuocGia.Text;
                        ct.MoTa = txtMoTa.Text;
                        context.SaveChanges();
                    }
                }
                frmCongTy_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _parent.LoadForm(new frmNavigation());
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu Công Ty ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSachCongTy_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[]
                    {
                new DataColumn("CongTyId", typeof(int)),
                new DataColumn("TenCongTy", typeof(string)),
                new DataColumn("NgayThanhLap", typeof(DateTime)),
                new DataColumn("QuocGia", typeof(string)),
                new DataColumn("MoTa", typeof(string))
                    });

                    var congTyList = context.CongTy.ToList();
                    foreach (var ct in congTyList)
                    {
                        table.Rows.Add(ct.CongTyId, ct.TenCongTy, ct.NgayThanhLap, ct.QuocGia, ct.MoTa);
                    }

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add(table, "CongTy");
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


        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Công Ty từ Excel";
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
                                CongTy ct = new CongTy
                                {
                                    TenCongTy = r["TenCongTy"].ToString(),
                                    NgayThanhLap = DateTime.Parse(r["NgayThanhLap"].ToString()),
                                    QuocGia = r["QuocGia"].ToString(),
                                    MoTa = r["MoTa"].ToString()
                                };
                                context.CongTy.Add(ct);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmCongTy_Load(sender, e);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên công ty hoặc quốc gia cần tìm:", "Tìm kiếm", "");

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var ketQua = context.CongTy
                    .Where(ct => ct.TenCongTy.Contains(keyword) || ct.QuocGia.Contains(keyword))
                    .ToList();

                if (ketQua.Count > 0)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQua;
                    dgvDanhSach.DataSource = bindingSource;

                    txtTenCongTy.DataBindings.Clear();
                    txtTenCongTy.DataBindings.Add("Text", bindingSource, "TenCongTy", false, DataSourceUpdateMode.Never);

                    txtQuocGia.DataBindings.Clear();
                    txtQuocGia.DataBindings.Add("Text", bindingSource, "QuocGia", false, DataSourceUpdateMode.Never);

                    txtMoTa.DataBindings.Clear();
                    txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

                    dtpNgayThanhLap.DataBindings.Clear();
                    dtpNgayThanhLap.DataBindings.Add("Value", bindingSource, "NgayThanhLap", false, DataSourceUpdateMode.Never);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy công ty phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmCongTy_Load(sender, e);
        }
    }
}

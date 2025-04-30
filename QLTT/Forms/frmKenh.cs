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
    public partial class frmKenh : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        bool xuLyThem = false;
        int id;

        public frmKenh()
        {
            InitializeComponent();
        }

        private void frmKenh_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvDanhSach.AutoGenerateColumns = false;
            LayIdolVaoComboBox();

            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            List<Kenh> kenh = new List<Kenh>();
            var DanhSachKenh = context.Kenh
                   .Select(k => new DanhSachKenh
                   {
                       KenhId = k.KenhId,
                       TenKenh = k.TenKenh,
                       NenTang = k.NenTang,
                       UrlKenh = k.UrlKenh,
                       TinhTrangKenh = k.TinhTrangKenh,
                       SoLuongNguoiDangKy = k.SoLuongNguoiDangKy,
                       TongLuotXem = k.TongLuotXem,
                       IdolId = k.IdolId,
                       TenIdol = k.Idol.TenIdol
                   }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = DanhSachKenh;

            txtTenKenh.DataBindings.Clear();
            txtTenKenh.DataBindings.Add("Text", bindingSource, "TenKenh", false, DataSourceUpdateMode.Never);

            txtUrl.DataBindings.Clear();
            txtUrl.DataBindings.Add("Text", bindingSource, "UrlKenh", false, DataSourceUpdateMode.Never);

            cbNenTang.DataBindings.Clear();
            cbNenTang.DataBindings.Add("SelectedItem", bindingSource, "NenTang", false, DataSourceUpdateMode.Never);

            cbTinhTrangKenh.DataBindings.Clear();
            cbTinhTrangKenh.DataBindings.Add("SelectedItem", bindingSource, "TinhTrangKenh", false, DataSourceUpdateMode.Never);

            nudLuotDangKy.DataBindings.Clear();
            nudLuotDangKy.DataBindings.Add("Value", bindingSource, "SoLuongNguoiDangKy", false, DataSourceUpdateMode.Never);

            nudLuotXem.DataBindings.Clear();
            nudLuotXem.DataBindings.Add("Value", bindingSource, "TongLuotXem", false, DataSourceUpdateMode.Never);

            cbChuKenh.DataBindings.Clear();
            cbChuKenh.DataBindings.Add("SelectedValue", bindingSource, "IdolId", false, DataSourceUpdateMode.Never);

            dgvDanhSach.DataSource = bindingSource;

        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenKenh.Enabled = giaTri;
            txtUrl.Enabled = giaTri;
            cbChuKenh.Enabled = giaTri;
            cbTinhTrangKenh.Enabled = giaTri;
            cbNenTang.Enabled = giaTri;
            nudLuotDangKy.Enabled = giaTri;
            nudLuotXem.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayIdolVaoComboBox()
        {
            cbChuKenh.DataSource = context.Idol.ToList();
            cbChuKenh.ValueMember = "IdolId";
            cbChuKenh.DisplayMember = "TenIdol";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtUrl.Clear();
            txtTenKenh.Clear();
            nudLuotXem.Value = 0;
            nudLuotDangKy.Value = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKenh.Text) ||
                string.IsNullOrWhiteSpace(txtUrl.Text) ||
                cbNenTang.SelectedIndex == -1 ||
                cbTinhTrangKenh.SelectedIndex == -1 ||
                cbChuKenh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                Kenh kenh = new Kenh();
                kenh.TenKenh = txtTenKenh.Text;
                kenh.UrlKenh = txtUrl.Text;
                kenh.NenTang = cbNenTang.SelectedItem.ToString();
                kenh.TinhTrangKenh = cbTinhTrangKenh.SelectedItem.ToString();
                kenh.SoLuongNguoiDangKy = (int)nudLuotDangKy.Value;
                kenh.TongLuotXem = (int)nudLuotXem.Value;
                kenh.IdolId = (int)cbChuKenh.SelectedValue;

                context.Kenh.Add(kenh);
                context.SaveChanges();
            }
            else
            {
                Kenh kenh = context.Kenh.Find(id);
                if (kenh != null)
                {
                    kenh.TenKenh = txtTenKenh.Text;
                    kenh.UrlKenh = txtUrl.Text;
                    kenh.NenTang = cbNenTang.SelectedItem.ToString();
                    kenh.TinhTrangKenh = cbTinhTrangKenh.SelectedItem.ToString();
                    kenh.SoLuongNguoiDangKy = (int)nudLuotDangKy.Value;
                    kenh.TongLuotXem = (int)nudLuotXem.Value;
                    kenh.IdolId = (int)cbChuKenh.SelectedValue;

                    context.SaveChanges();
                }
            }

            frmKenh_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa kênh?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int kenhId = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["KenhId"].Value);
                Kenh kenh = context.Kenh.Find(kenhId);
                if (kenh != null)
                {
                    context.Kenh.Remove(kenh);
                    context.SaveChanges();
                    frmKenh_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["KenhId"].Value);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnNhapKenh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Nhập dữ liệu Kênh từ Excel",
                Filter = "Tập tin Excel|*.xls;*.xlsx",
                Multiselect = false
            };

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
                                Kenh kenh = new Kenh
                                {
                                    TenKenh = r["TenKenh"].ToString(),
                                    NenTang = r["NenTang"].ToString(),
                                    UrlKenh = r["UrlKenh"].ToString(),
                                    TinhTrangKenh = r["TinhTrangKenh"].ToString(),
                                    SoLuongNguoiDangKy = int.Parse(r["SoLuongNguoiDangKy"].ToString()),
                                    TongLuotXem = int.Parse(r["TongLuotXem"].ToString()),
                                    IdolId = int.Parse(r["IdolId"].ToString())
                                };
                                context.Kenh.Add(kenh);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKenh_Load(sender, e);
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

        private void btnXuatKenh_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Xuất dữ liệu Kênh ra Excel",
                Filter = "Tập tin Excel|*.xls;*.xlsx",
                FileName = "DanhSachKenh_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[]
                    {
                         new DataColumn("KenhId", typeof(int)),
                         new DataColumn("TenKenh", typeof(string)),
                         new DataColumn("NenTang", typeof(string)),
                         new DataColumn("UrlKenh", typeof(string)),
                         new DataColumn("TinhTrangKenh", typeof(string)),
                         new DataColumn("SoLuongNguoiDangKy", typeof(int)),
                         new DataColumn("TongLuotXem", typeof(int)),
                         new DataColumn("IdolId", typeof(int))
                    });

                    var kenhs = context.Kenh.ToList();
                    foreach (var k in kenhs)
                    {
                        table.Rows.Add(k.KenhId, k.TenKenh, k.NenTang, k.UrlKenh, k.TinhTrangKenh, k.SoLuongNguoiDangKy, k.TongLuotXem, k.IdolId);
                    }

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add(table, "Kenh");
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

    }
}

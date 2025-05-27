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

namespace QLTT.Forms
{
    public partial class frmNhaTaiTro : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        int id;
        bool xuLyThem = false;
        frmNavigation _parent;
        public frmNhaTaiTro(frmNavigation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void frmNhaTaiTro_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            List<NhaTaiTro> ntt = new List<NhaTaiTro>();
            ntt = context.NhaTaiTro.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ntt;

            txtTenNhaTaiTro.DataBindings.Clear();
            txtTenNhaTaiTro.DataBindings.Add("Text", bindingSource, "TenNhaTaiTro", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            dgvDanhSach.DataSource = bindingSource;
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenNhaTaiTro.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMoTa.Clear();
            txtTenNhaTaiTro.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenNhaTaiTro.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    NhaTaiTro ntt = new NhaTaiTro();
                    ntt.TenNhaTaiTro = txtTenNhaTaiTro.Text;
                    ntt.MoTa = txtMoTa.Text;
                    context.NhaTaiTro.Add(ntt);
                    context.SaveChanges();
                }
                else
                {
                    NhaTaiTro ntt = context.NhaTaiTro.Find(id);
                    if (ntt != null)
                    {
                        ntt.TenNhaTaiTro = txtTenNhaTaiTro.Text;
                        ntt.MoTa = txtMoTa.Text;
                        context.SaveChanges();
                    }
                }
                frmNhaTaiTro_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa chi nhánh?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["NhaTaiTroId"].Value.ToString());
                NhaTaiTro ntt = context.NhaTaiTro.Find(id);
                if (ntt != null)
                {
                    context.NhaTaiTro.Remove(ntt);
                }
                context.SaveChanges();
                frmNhaTaiTro_Load(sender, e);
            }
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
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["NhaTaiTroId"].Value.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _parent.LoadForm(new frmNavigation());
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Nhà Tài Trợ từ Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (var workbook = new ClosedXML.Excel.XLWorkbook(openFileDialog.FileName))
                    {
                        var worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (var row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (var cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (var cell in row.Cells(readRange))
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
                                NhaTaiTro ntt = new NhaTaiTro
                                {
                                    TenNhaTaiTro = r["TenNhaTaiTro"].ToString(),
                                    MoTa = r["MoTa"].ToString()
                                };
                                context.NhaTaiTro.Add(ntt);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhaTaiTro_Load(sender, e);
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
            saveFileDialog.Title = "Xuất dữ liệu Nhà Tài Trợ ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhaTaiTro_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("NhaTaiTroId", typeof(int)),
                        new DataColumn("TenNhaTaiTro", typeof(string)),
                        new DataColumn("MoTa", typeof(string))
                    });

                    var ntts = context.NhaTaiTro.ToList();
                    foreach (var ntt in ntts)
                    {
                        table.Rows.Add(ntt.NhaTaiTroId, ntt.TenNhaTaiTro, ntt.MoTa);
                    }

                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var sheet = workbook.Worksheets.Add(table, "NhaTaiTro");
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên hoặc mô tả nhà tài trợ để tìm:", "Tìm kiếm", "");

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var ketQua = context.NhaTaiTro
                    .Where(ntt => ntt.TenNhaTaiTro.Contains(keyword)
                               || ntt.MoTa.Contains(keyword))
                    .ToList();

                if (ketQua.Count > 0)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQua;

                    dgvDanhSach.DataSource = bindingSource;

                    txtTenNhaTaiTro.DataBindings.Clear();
                    txtTenNhaTaiTro.DataBindings.Add("Text", bindingSource, "TenNhaTaiTro", false, DataSourceUpdateMode.Never);

                    txtMoTa.DataBindings.Clear();
                    txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmNhaTaiTro_Load(sender, e);
        }
    }
}

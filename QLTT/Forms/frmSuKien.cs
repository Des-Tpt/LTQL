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
using QLTT.Forms;

namespace QLTT
{
    public partial class frmSuKien : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        int id;
        bool xuLyThem = false;

        private frmNavigation _parent;

        public frmSuKien(frmNavigation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void frmSuKien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayNhaTaiTroVaoComboBox();
            dgvDanhSach.AutoGenerateColumns = false;

            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            List<SuKien> sk = new List<SuKien>();
            var danhsachSuKien = context.SuKien
                   .Select(sk => new DanhSachSuKien
                   {
                       SukienId = sk.SukienId,
                       TenSukien = sk.TenSukien,
                       DiaDiem = sk.DiaDiem,
                       NgayToChuc = sk.NgayToChuc,
                       NhaTaiTroId = sk.NhaTaiTroId,
                       TenNhaTaiTro = sk.NhaTaiTro.TenNhaTaiTro,
                   }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhsachSuKien;

            txtTenSuKien.DataBindings.Clear();
            txtTenSuKien.DataBindings.Add("Text", bindingSource, "TenSuKien", false, DataSourceUpdateMode.Never);

            dtpThoiDiem.DataBindings.Clear();
            dtpThoiDiem.DataBindings.Add("Value", bindingSource, "NgayToChuc", false, DataSourceUpdateMode.Never);

            txtDiaDiem.DataBindings.Clear();
            txtDiaDiem.DataBindings.Add("Text", bindingSource, "DiaDiem", false, DataSourceUpdateMode.Never);

            cbNhaTaiTro.DataBindings.Clear();
            cbNhaTaiTro.DataBindings.Add("SelectedItem", bindingSource, "NhaTaiTroId", false, DataSourceUpdateMode.Never);

            dgvDanhSach.DataSource = bindingSource;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtDiaDiem.Enabled = giaTri;
            txtTenSuKien.Enabled = giaTri;
            dtpThoiDiem.Enabled = giaTri;
            cbNhaTaiTro.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayNhaTaiTroVaoComboBox()
        {
            cbNhaTaiTro.DataSource = context.NhaTaiTro.ToList();
            cbNhaTaiTro.ValueMember = "NhaTaiTroId";
            cbNhaTaiTro.DisplayMember = "TenNhaTaiTro";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenSuKien.Clear();
            txtDiaDiem.Clear();
            dtpThoiDiem.Value = DateTime.Today;
            cbNhaTaiTro.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null || dgvDanhSach.CurrentRow.Cells["SukienId"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn một sự kiện để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["SukienId"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sự kiện này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["SukienId"].Value.ToString());
                SuKien suKien = context.SuKien.Find(id);
                if (suKien != null)
                {
                    context.SuKien.Remove(suKien);
                    context.SaveChanges();
                }
                frmSuKien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSuKien.Text) || string.IsNullOrWhiteSpace(txtDiaDiem.Text) || cbNhaTaiTro.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                SuKien sk = new SuKien();
                sk.TenSukien = txtTenSuKien.Text;
                sk.DiaDiem = txtDiaDiem.Text;
                sk.NgayToChuc = dtpThoiDiem.Value;
                sk.NhaTaiTroId = (int)cbNhaTaiTro.SelectedValue;

                context.SuKien.Add(sk);
            }
            else
            {
                SuKien sk = context.SuKien.Find(id);
                if (sk != null)
                {
                    sk.TenSukien = txtTenSuKien.Text;
                    sk.DiaDiem = txtDiaDiem.Text;
                    sk.NgayToChuc = dtpThoiDiem.Value;
                    sk.NhaTaiTroId = (int)cbNhaTaiTro.SelectedValue;
                }
            }

            context.SaveChanges();
            frmSuKien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            frmSuKien_Load(sender, e);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Sự kiện từ XML";
            openFileDialog.Filter = "Tập tin XML|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(openFileDialog.FileName);
                    DataTable dt = ds.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        SuKien sk = new SuKien
                        {
                            TenSukien = row["TenSukien"].ToString(),
                            DiaDiem = row["DiaDiem"].ToString(),
                            NgayToChuc = DateTime.Parse(row["NgayToChuc"].ToString()),
                            NhaTaiTroId = int.Parse(row["NhaTaiTroId"].ToString())
                        };
                        context.SuKien.Add(sk);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Nhập dữ liệu từ XML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSuKien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách sự kiện ra XML";
            saveFileDialog.Filter = "Tập tin XML|*.xml";
            saveFileDialog.FileName = "DanhSachSuKien_" + DateTime.Now.ToString("yyyyMMdd") + ".xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var danhSach = context.SuKien.Select(sk => new
                    {
                        sk.TenSukien,
                        sk.DiaDiem,
                        sk.NgayToChuc,
                        sk.NhaTaiTroId
                    }).ToList();

                    DataTable dt = new DataTable("SuKien");
                    dt.Columns.Add("TenSukien");
                    dt.Columns.Add("DiaDiem");
                    dt.Columns.Add("NgayToChuc");
                    dt.Columns.Add("NhaTaiTroId");

                    foreach (var sk in danhSach)
                    {
                        dt.Rows.Add(sk.TenSukien, sk.DiaDiem, sk.NgayToChuc, sk.NhaTaiTroId);
                    }

                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    ds.WriteXml(saveFileDialog.FileName);

                    MessageBox.Show("Xuất XML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            _parent.LoadForm(new frmNavigation());
        }
    }
}

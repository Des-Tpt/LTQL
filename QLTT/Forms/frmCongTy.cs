using QLTT.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

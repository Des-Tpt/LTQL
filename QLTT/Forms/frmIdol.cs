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
    public partial class frmIdol : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        bool xuLyThem = false;
        int id;

        public frmIdol()
        {
            InitializeComponent();
        }

        private void frmIdol_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<Idol> lid = new List<Idol>();
            lid = context.Idol.ToList();

            dgvDanhSach.AutoGenerateColumns = false;

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lid;

            txtTenIdol.DataBindings.Clear();
            txtTenIdol.DataBindings.Add("Text", DataBindings, "TenIdol", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", DataBindings, "MoTa", false, DataSourceUpdateMode.Never);

            dtpNgayDebut.DataBindings.Clear();
            dtpNgayDebut.DataBindings.Add("Value", DataBindings, "NgayRaMat", false, DataSourceUpdateMode.Never);

            rbtTinhTrangHoatDong.DataBindings.Clear();
            rbtTinhTrangHoatDong.DataBindings.Add("Checked", DataBindings, "DangHoatDong", false, DataSourceUpdateMode.Never);

        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenIdol.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            dtpNgayDebut.Enabled = giaTri;
            rbtTinhTrangHoatDong.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtMoTa.Clear();
            txtTenIdol.Clear();
            dtpNgayDebut.Value = DateTime.Today;
            rbtTinhTrangHoatDong.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["IdolId"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMoTa.Text) || (string.IsNullOrWhiteSpace(txtTenIdol.Text)))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Idol lid = new Idol();
                    lid.TenIdol = txtTenIdol.Text;
                    lid.MoTa = txtMoTa.Text;
                    lid.NgayRaMat = dtpNgayDebut.Value;
                    lid.DangHoatDong = rbtTinhTrangHoatDong.Checked;

                    context.SaveChanges(); ;
                    context.Idol.Add(lid);
                }
                else
                {
                    Idol lid = context.Idol.Find(id);
                    if (lid != null)
                    {
                        lid.TenIdol = txtMoTa.Text;
                        lid.MoTa = txtMoTa.Text;
                        lid.NgayRaMat = dtpNgayDebut.Value;
                        lid.DangHoatDong = rbtTinhTrangHoatDong.Checked;

                        context.Idol.Update(lid);
                        context.SaveChanges();
                    }
                }
                frmIdol_Load(sender, e);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["IdolId"].Value.ToString());
                Idol lid = context.Idol.Find(id);
                if (lid != null)
                {
                    context.Idol.Remove(lid);
                }
                context.SaveChanges();
                frmIdol_Load(sender, e);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmIdol_Load(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using QLTT.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLTT.Forms
{
    public partial class Idol_SuKien : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        int suKienId;
        bool xuLyThem = false;

        frmNavigation _parent;

        public Idol_SuKien(frmNavigation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void Idol_SuKien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayIdolVaoCheckListBox();
            LaySuKienVaoComboBox();
            dgvDanhSach.AutoGenerateColumns = false;

            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var danhSachIdolSuKien = context.IdolSuKien
                    .Include(ids => ids.SuKien)
                    .Include(ids => ids.Idol)
                    .GroupBy(ids => ids.SuKienID)
                   .Select(g => new DanhSachSuKienIdol
                   {
                       SuKienId = g.Key,
                       TenSuKien = g.FirstOrDefault().SuKien.TenSukien,
                       DiaDiem = g.FirstOrDefault().SuKien.DiaDiem,
                       NgayToChuc = g.FirstOrDefault().SuKien.NgayToChuc,
                       NguoiThamGia = string.Join(" - ", g.Select(ids => ids.Idol.TenIdol))
                   }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhSachIdolSuKien;
            dgvDanhSach.DataSource = bindingSource;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            cbTenSuKien.Enabled = giaTri;
            clbIdolThamGia.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LaySuKienVaoComboBox()
        {
            cbTenSuKien.DataSource = context.SuKien.ToList();
            cbTenSuKien.ValueMember = "SuKienId";
            cbTenSuKien.DisplayMember = "TenSuKien";
        }

        public void LayIdolVaoCheckListBox()
        {
            clbIdolThamGia.Items.Clear();
            var idols = context.Idol.ToList();

            foreach (var idol in idols)
            {
                clbIdolThamGia.Items.Add(idol, false);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cbTenSuKien.SelectedIndex = -1;
            for (int i = 0; i < clbIdolThamGia.Items.Count; i++)
                clbIdolThamGia.SetItemChecked(i, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbTenSuKien.SelectedIndex == -1 || clbIdolThamGia.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sự kiện và ít nhất một idol!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedSuKienId = (int)cbTenSuKien.SelectedValue;

            if (xuLyThem)
            {
                // Phần này là nút lưu của phần thêm, tức là nếu kiểm tra mà thấy đã có cái SuKienId rồi, thì không thêm được.
                if (context.IdolSuKien.Any(x => x.SuKienID == selectedSuKienId))
                {
                    MessageBox.Show("Sự kiện này đã có idol tham gia. Không thể thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                //Phần này là nút lưu của phần sửa. Chỉ là xóa cái cũ và thay bằng cái mới.
                //về cơ bản là List hết mấy dòng có liên quan đến SuKienId vào dsCu, sau đó dựa theo nó mà xóa hết trong sql.

                var dsCu = context.IdolSuKien.Where(x => x.SuKienID == selectedSuKienId).ToList();
                context.IdolSuKien.RemoveRange(dsCu);
            }

            foreach (var item in clbIdolThamGia.CheckedItems)
            {
                Idol idol = item as Idol;
                context.IdolSuKien.Add(new IdolSuKien
                {
                    SuKienID = selectedSuKienId,
                    IdolId = idol.IdolId
                });
            }

            context.SaveChanges();
            Idol_SuKien_Load(sender, e);
            BatTatChucNang(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);
            suKienId = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["SuKienId"].Value);
            cbTenSuKien.SelectedValue = suKienId;

            var idolIds = context.IdolSuKien
                .Where(x => x.SuKienID == suKienId)
                .Select(x => x.IdolId)
                .ToList();

            for (int i = 0; i < clbIdolThamGia.Items.Count; i++)
            {
                Idol idol = clbIdolThamGia.Items[i] as Idol;
                clbIdolThamGia.SetItemChecked(i, idolIds.Contains(idol.IdolId));
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa kế hoạch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedSuKienId = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["SuKienId"].Value);
                var dsXoa = context.IdolSuKien.Where(x => x.SuKienID == selectedSuKienId).ToList();
                context.IdolSuKien.RemoveRange(dsXoa);
                context.SaveChanges();
                Idol_SuKien_Load(sender, e);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên sự kiện, địa điểm hoặc tên idol để tìm:", "Tìm kiếm", "");

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var ketQua = context.IdolSuKien
                    .Include(ids => ids.SuKien)
                    .Include(ids => ids.Idol)
                    .GroupBy(ids => ids.SuKienID)
                    .Select(g => new DanhSachSuKienIdol
                    {
                        SuKienId = g.Key,
                        TenSuKien = g.FirstOrDefault().SuKien.TenSukien,
                        DiaDiem = g.FirstOrDefault().SuKien.DiaDiem,
                        NgayToChuc = g.FirstOrDefault().SuKien.NgayToChuc,
                        NguoiThamGia = string.Join(" - ", g.Select(ids => ids.Idol.TenIdol))
                    })
                    .AsEnumerable()
                    .Where(item => item.TenSuKien.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                                || item.DiaDiem.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                                || item.NguoiThamGia.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (ketQua.Count > 0)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQua;
                    dgvDanhSach.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Idol_SuKien_Load(sender, e);

        }
    }
}



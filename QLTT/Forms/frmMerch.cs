﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTT.Data;
using QLTT.Reports;

namespace QLTT.Forms
{
    public partial class frmMerch : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        int id;
        bool xuLyThem = false;
        string selectedImagePath = "";

        private frmNavigation _parent;

        public frmMerch(frmNavigation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            txtTenHangHoa.Enabled = giaTri;
            cbIdol.Enabled = giaTri;
            nudGiaBan.Enabled = giaTri;
            dtpNgayBan.Enabled = giaTri;
            btnChonAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        public void LayIdolVaoComboBox()
        {
            cbIdol.DataSource = context.Idol.ToList();
            cbIdol.ValueMember = "IdolId";
            cbIdol.DisplayMember = "TenIdol";
        }

        private void frmMerch_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayIdolVaoComboBox();
            dgvDanhSach.AutoGenerateColumns = false;

            ((DataGridViewImageColumn)dgvDanhSach.Columns["HinhAnh"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDanhSach.RowTemplate.Height = 70;


            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            List<Merch> merch = new List<Merch>();
            var danhsachMerch = context.Merch
                   .Select(m => new DanhSachMerch
                   {
                       MerchId = m.MerchId,
                       TenMerch = m.TenMerch,
                       GiaBan = m.GiaBan,
                       SoLuong = m.SoLuong,
                       HinhAnh = m.HinhAnh,
                       NgayPhatHanh = m.NgayPhatHanh,
                       IdolId = m.IdolId,
                       TenIdol = m.Idol.TenIdol
                   }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = danhsachMerch;

            txtTenHangHoa.DataBindings.Clear();
            txtTenHangHoa.DataBindings.Add("Text", bindingSource, "TenMerch", false, DataSourceUpdateMode.Never);

            dtpNgayBan.DataBindings.Clear();
            dtpNgayBan.DataBindings.Add("Value", bindingSource, "NgayPhatHanh", false, DataSourceUpdateMode.Never);

            nudGiaBan.DataBindings.Clear();
            nudGiaBan.DataBindings.Add("Value", bindingSource, "GiaBan", false, DataSourceUpdateMode.Never);

            nudSoLuong.DataBindings.Clear();
            nudSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            cbIdol.DataBindings.Clear();
            cbIdol.DataBindings.Add("SelectedItem", bindingSource, "IdolId", false, DataSourceUpdateMode.Never);

            dgvDanhSach.CellFormatting += dgvDanhSach_CellFormatting;

            dgvDanhSach.DataSource = bindingSource;
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh merch";
                ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                //Dùng để mở thư mục Image bên trong thư mục QLTT
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string imageDirectory = Path.Combine(appDirectory, "Image");

                //Còn nếu ko tìm thấy, thì mở thư mục chứa project
                if (!Directory.Exists(imageDirectory))
                {
                    imageDirectory = appDirectory;
                }

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (pcHinhAnh.Image != null)
                        {
                            pcHinhAnh.Image.Dispose(); //Kiểm tra xem là đã có ảnh bên trong pcHinhAnh chưa.
                            pcHinhAnh.Image = null; //Nếu chưa phải xóa, để giảm dung lượng bộ nhớ sử dụng.
                        }

                        selectedImagePath = ofd.FileName;

                        Image img;
                        using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read)) //Đọc nội dung file ảnh.
                        using (MemoryStream ms = new MemoryStream()) //Sau đó copy qua MemoryStream.
                        {
                            fs.CopyTo(ms);
                            ms.Position = 0;
                            img = Image.FromStream(ms);  //Xong mới tạo ảnh từ Stream, mục đích là để tránh lỗi "file đang bị chiếm dụng" nếu copy trực tiếp qua fileStream.
                        }

                        int maxWidth = 800;
                        int maxHeight = 800;

                        //Đặt kích thước tối đa là 800 x 800 px.

                        if (img.Width > maxWidth || img.Height > maxHeight) //Nếu lớn hơn mẫu sẳn.
                        {
                            float ratioX = (float)maxWidth / img.Width;
                            float ratioY = (float)maxHeight / img.Height;
                            float ratio = Math.Min(ratioX, ratioY);
                            int newWidth = (int)(img.Width * ratio);
                            int newHeight = (int)(img.Height * ratio); //Giảm chiều cao lại theo tỉ lệ.

                            Image resizedImg = new Bitmap(img, newWidth, newHeight); //Co ảnh lại.
                            img.Dispose();
                            img = resizedImg; //Gán lại ảnh mới.
                        }

                        pcHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                        pcHinhAnh.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvDanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDanhSach.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                var merch = dgvDanhSach.Rows[e.RowIndex].DataBoundItem as DanhSachMerch;
                if (merch != null && !string.IsNullOrEmpty(merch.HinhAnh) && File.Exists(merch.HinhAnh))
                {
                    Image img = Image.FromFile(merch.HinhAnh);

                    int maxDim = 100;
                    if (img.Width > maxDim || img.Height > maxDim)
                    {
                        var ratio = Math.Min((float)maxDim / img.Width, (float)maxDim / img.Height);
                        img = new Bitmap(img, (int)(img.Width * ratio), (int)(img.Height * ratio));
                    }

                    e.Value = img;
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = null;
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangHoa.Clear();
            dtpNgayBan.Value = DateTime.Today;
            nudGiaBan.Value = 0;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHangHoa.Text) || nudGiaBan.Value <= 0 || cbIdol.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                Merch merch = new Merch();
                merch.TenMerch = txtTenHangHoa.Text;
                merch.GiaBan = (int)nudGiaBan.Value;
                merch.SoLuong = (int)nudSoLuong.Value;
                merch.NgayPhatHanh = dtpNgayBan.Value;
                merch.IdolId = (int)cbIdol.SelectedValue;

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    merch.HinhAnh = selectedImagePath;
                }

                context.Merch.Add(merch);
                context.SaveChanges();
            }
            else
            {
                Merch merch = context.Merch.Find(id);
                if (merch != null)
                {
                    merch.TenMerch = txtTenHangHoa.Text;
                    merch.GiaBan = (int)nudGiaBan.Value;
                    merch.SoLuong = (int)nudSoLuong.Value;
                    merch.NgayPhatHanh = dtpNgayBan.Value;
                    merch.IdolId = (int)cbIdol.SelectedValue;

                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        merch.HinhAnh = selectedImagePath;
                    }

                    context.SaveChanges();
                }
            }

            frmMerch_Load(sender, e);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa idol?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MerchId"].Value.ToString());
                Merch merch = context.Merch.Find(id);
                if (merch != null)
                {
                    context.Merch.Remove(merch);
                }
                context.SaveChanges();
                frmMerch_Load(sender, e);
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
            id = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MerchId"].Value.ToString());

            string path = dgvDanhSach.CurrentRow.Cells["HinhAnh"].Value?.ToString();
            selectedImagePath = path; // giữ lại nếu cần lưu về sau

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    if (pcHinhAnh.Image != null)
                    {
                        pcHinhAnh.Image.Dispose();
                        pcHinhAnh.Image = null;
                    }

                    Image img;
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        img = Image.FromStream(ms);
                    }

                    pcHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                    pcHinhAnh.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                pcHinhAnh.Image = null;
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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var thongKeForm = new frmThongKeMerch();
            thongKeForm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên merch hoặc idol để tìm:", "Tìm kiếm", "");

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var ketQua = context.Merch
                    .Where(m => m.TenMerch.Contains(keyword) || m.Idol.TenIdol.Contains(keyword))
                    .Select(m => new DanhSachMerch
                    {
                        MerchId = m.MerchId,
                        TenMerch = m.TenMerch,
                        GiaBan = m.GiaBan,
                        SoLuong = m.SoLuong,
                        HinhAnh = m.HinhAnh,
                        NgayPhatHanh = m.NgayPhatHanh,
                        IdolId = m.IdolId,
                        TenIdol = m.Idol.TenIdol
                    })
                    .ToList();

                if (ketQua.Count > 0)
                {
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQua;
                    dgvDanhSach.DataSource = bindingSource;

                    txtTenHangHoa.DataBindings.Clear();
                    txtTenHangHoa.DataBindings.Add("Text", bindingSource, "TenMerch", false, DataSourceUpdateMode.Never);

                    dtpNgayBan.DataBindings.Clear();
                    dtpNgayBan.DataBindings.Add("Value", bindingSource, "NgayPhatHanh", false, DataSourceUpdateMode.Never);

                    nudGiaBan.DataBindings.Clear();
                    nudGiaBan.DataBindings.Add("Value", bindingSource, "GiaBan", false, DataSourceUpdateMode.Never);

                    nudSoLuong.DataBindings.Clear();
                    nudSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

                    cbIdol.DataBindings.Clear();
                    cbIdol.DataBindings.Add("SelectedValue", bindingSource, "IdolId", false, DataSourceUpdateMode.Never);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            frmMerch_Load(sender, e);
        }
    }
}

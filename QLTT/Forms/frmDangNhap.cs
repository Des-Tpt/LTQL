using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLTT.Data;

namespace QLTT.Forms
{
    public partial class frmDangNhap : Form
    {
        QLTTDbContext context = new QLTTDbContext();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            var nguoiDung = context.NguoiDung
            .FirstOrDefault(nd => nd.TenDangNhap == tenDangNhap && nd.MatKhau == matKhau);

            if (nguoiDung != null)
            {
                Session.NguoiDungHienTai = nguoiDung;

                MessageBox.Show("Đăng nhập thành công!");

                this.Hide();
                var mainForm = new frmMenu();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !cbHienMatKhau.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

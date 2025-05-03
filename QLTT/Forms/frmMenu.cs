using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTT.Data;

namespace QLTT.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            KiemTraQuyen();
            loadForm(new frmLich());
        }

        public void loadForm(Form con)
        {
            pnMain.Controls.Clear();
            con.TopLevel = false;
            con.FormBorderStyle = FormBorderStyle.None;
            con.Dock = DockStyle.Fill;

            pnMain.Controls.Add(con);
            con.Show();
        }

        private void KiemTraQuyen()
        {
            var nguoiDung = Session.NguoiDungHienTai;

            if (nguoiDung == null || nguoiDung.PhanQuyen != "Admin")
            {
                btnDanhSach.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            loadForm(new frmNavigation());
        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            loadForm(new frmLich());
        }
    }
}

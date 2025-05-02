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
    public partial class frmNavigation : Form
    {
        public frmNavigation()
        {
            InitializeComponent();
        }
        public void LoadForm(Form childForm)
        {
            pnMain.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnIdol_Click(object sender, EventArgs e)
        {
            LoadForm(new frmIdol(this));
        }

        private void btnDanhTinh_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDanhTinh(this));
        }

        private void btnCongTy_Click(object sender, EventArgs e)
        {
            LoadForm(new frmCongTy(this));
        }

        private void btnKenh_Click(object sender, EventArgs e)
        {
            LoadForm(new frmKenh(this));
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
            LoadForm(new frmSuKien(this));
        }

        private void btnMerch_Click(object sender, EventArgs e)
        {
            LoadForm(new frmMerch(this));
        }

        private void btnNhaTaiTro_Click(object sender, EventArgs e)
        {
            LoadForm(new frmNhaTaiTro(this));
        }

        private void btnKeHoach_Click(object sender, EventArgs e)
        {
            LoadForm(new Idol_SuKien(this));
        }
    }
}

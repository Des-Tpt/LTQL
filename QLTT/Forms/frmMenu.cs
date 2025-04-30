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

namespace QLTT.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            loadForm(new frmIdol());
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
    }
}

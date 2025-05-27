using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;
using QLTT.Data;

namespace QLTT.Forms
{
    public partial class ucNgay : UserControl
    {
        string _day, date, weekday;
        DateTime? ngay;

        public ucNgay(string day, string? suKien = null, DateTime? ngayObj = null)
        {
            InitializeComponent();
            _day = day;
            lblNgay.Text = day;

            if (!string.IsNullOrEmpty(suKien))
            {
                lblSuKien.Text = suKien;
                lblSuKien.Visible = true;

                Color[] colors = new Color[]
                {
                    Color.BlanchedAlmond,
                    Color.LightBlue,
                    Color.LightGreen,
                    Color.LightSalmon,
                    Color.MistyRose,
                    Color.PaleTurquoise,
                    Color.LavenderBlush
                };

                Random rand = new Random();
                int index = rand.Next(colors.Length);
                panel1.BackColor = colors[index];
            }
            else
            {
                lblSuKien.Visible = false;
            }

            ngay = ngayObj;
        }

        private void ucNgay_Load(object sender, EventArgs e)
        {
            if (ngay.HasValue && ngay.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                lblNgay.ForeColor = Color.Red;
            }
            else
            {
                lblNgay.ForeColor = Color.Black;
            }
        }
    }
}

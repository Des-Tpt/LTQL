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
using System.Globalization;

namespace QLTT.Forms
{
    public partial class frmLich : Form
    {
        public static int _month, _year;
        public frmLich()
        {
            InitializeComponent();
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        public void ShowDays(int month, int year)
        {
            flpLich.Controls.Clear();

            _month = month;
            _year = year;

            string TenThang = new DateTime(year, month, 1)
                .ToString("MMMM", new CultureInfo("vi-VN"));

            lblThang.Text = TenThang;

            DateTime ngaydauthang = new DateTime(year, month, 1);
            int thumay = (int)ngaydauthang.DayOfWeek;

            for (int i = 0; i < thumay; i++)
            {
                flpLich.Controls.Add(new ucNgay(""));
            }

            int songaytrongthang = DateTime.DaysInMonth(year, month);

            using (var context = new QLTTDbContext())
            {
                var skTheoThang = context.SuKien
                    .Where(s => s.NgayToChuc.Month == month && s.NgayToChuc.Year == year)
                    .Select(s => new DanhSachSuKienIdol
                    {
                        TenSuKien = s.TenSukien,
                        DiaDiem = s.DiaDiem,
                        NgayToChuc = s.NgayToChuc,
                        IdolId = s.IdolSukien.FirstOrDefault().IdolId,
                        NguoiThamGia = s.IdolSukien.FirstOrDefault().Idol.TenIdol
                    })
                    .ToList();

                for (int day = 1; day <= songaytrongthang; day++)
                {
                    string? tenSuKien = null;
                    var ngayHienTai = new DateTime(year, month, day);

                    var sk = skTheoThang.FirstOrDefault(s => s.NgayToChuc.Day == day);
                    if (sk != null)
                    {
                        tenSuKien = sk.TenSuKien;
                    }

                    flpLich.Controls.Add(new ucNgay(day.ToString(), tenSuKien, ngayHienTai));
                }
            }
        }

        private void pcRight_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12) 
            {
                _month = 1;
                _year += 1;
            }
            ShowDays(_month,_year);
        }

        private void pcLeft_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            ShowDays(_month, _year);
        }
    }
}

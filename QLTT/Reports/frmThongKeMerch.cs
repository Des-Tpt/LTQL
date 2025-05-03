using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QLTT.Data;

namespace QLTT.Reports
{
    public partial class frmThongKeMerch : Form
    {
        QLTTDbContext context = new QLTTDbContext();
        QLMDataSet.DanhSachMerchDataTable merchDataTable = new QLMDataSet.DanhSachMerchDataTable();
        string reportsFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\Reports"));

        public frmThongKeMerch()
        {
            InitializeComponent();
        }

        private void frmThongKeMerch_Load(object sender, EventArgs e)
        {
            var danhSachMerch = context.Merch.Select(m => new DanhSachMerch
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

            merchDataTable.Clear();
            foreach (var merch in danhSachMerch)
            {
                merchDataTable.AddDanhSachMerchRow(
                    merch.MerchId,
                    merch.TenMerch,
                    merch.GiaBan,
                    merch.SoLuong,
                    merch.HinhAnh,
                    merch.NgayPhatHanh,
                    merch.IdolId,
                    merch.TenIdol
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachMerch";
            reportDataSource.Value = merchDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeMerch.rdlc");

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }
    }
}

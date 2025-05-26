using QLTT.Data;
using QLTT.Forms;

namespace QLTT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new QLTTDbContext())
                if (!context.NguoiDung.Any())
                {
                    context.NguoiDung.Add(new NguoiDung { TenDangNhap = "Admin", MatKhau = "123456", PhanQuyen = "Admin" });
                    context.NguoiDung.Add(new NguoiDung { TenDangNhap = "User", MatKhau = "123456", PhanQuyen = "User" });

                    context.SaveChanges();
                }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmDangNhap());
        }
    }
}
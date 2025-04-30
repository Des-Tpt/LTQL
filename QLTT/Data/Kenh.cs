using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QLTT.Data
{
    internal class Kenh
    {
        [Key]
        public int KenhId { get; set; }
        public string TenKenh { get; set; }
        public string NenTang { get; set; } = string.Empty;
        public string UrlKenh { get; set; } = string.Empty;
        public string TinhTrangKenh { get; set; } = string.Empty;
        public int SoLuongNguoiDangKy { get; set; }
        public int TongLuotXem { get; set; }
        public int IdolId { get; set; }
        public virtual Idol Idol { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachKenh
    {
        public int KenhId { get; set; }
        public string TenKenh { get; set; } = string.Empty;
        public string NenTang { get; set; } = string.Empty;
        public string UrlKenh { get; set; } = string.Empty;
        public string TinhTrangKenh { get; set; } = string.Empty;
        public int SoLuongNguoiDangKy { get; set; }
        public int TongLuotXem { get; set; }
        public int IdolId { get; set; }
        public string TenIdol { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class DanhTinh
    {
        [Key]
        public int DanhTinhId { get; set; } 
        public string HoTenThat { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public int IdolId { get; set; }
        public virtual Idol Idol { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachDanhTinh
    {
        public int DanhTinhId { get; set; }
        public string HoTenThat { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = string.Empty;
        public string SoDienThoai { get; set; } = string.Empty;
        public int IdolId { get; set; }
        public string TenIdol { get; set; } = string.Empty;
    }
}

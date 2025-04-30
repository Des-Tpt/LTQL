using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class Merch
    {
        [Key]
        public int MerchId { get; set; }
        public string TenMerch { get; set; } = string.Empty;
        public int GiaBan { get; set; }
        public string HinhAnh { get; set; } = "";
        public DateTime NgayPhatHanh { get; set; }
        public int IdolId { get; set; }
        public virtual Idol Idol { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachMerch
    {
        public int MerchId { get; set; }
        public string TenMerch { get; set; } = string.Empty;
        public int GiaBan { get; set; }
        public string HinhAnh { get; set; } = "";
        public DateTime NgayPhatHanh { get; set; }
        public int IdolId { get; set; }
        public string TenIdol { get; set; }
    }
}

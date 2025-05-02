using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class IdolSuKien
    {
        public int IdolId { get; set; }
        public virtual Idol Idol { get; set; } = null!;

        public int SuKienID { get; set; }
        public virtual SuKien SuKien { get; set; } = null!;
    }

    public class DanhSachSuKienIdol
    {
        public int SuKienId { get; set; }
        public string TenSuKien { get; set; } = string.Empty;
        public string DiaDiem { get; set; } = string.Empty;
        public DateTime NgayToChuc { get; set; }
        public int IdolId { get; set; }
        public string NguoiThamGia { get; set; } = string.Empty;
    }
}

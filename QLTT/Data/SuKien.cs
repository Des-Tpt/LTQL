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
    internal class SuKien
    {
        [Key]
        public int SukienId { get; set; }
        public string TenSukien { get; set; } = string.Empty;
        public DateTime NgayToChuc { get; set; }
        public string DiaDiem { get; set; } = string.Empty;
        public int NhaTaiTroId { get; set; }
        public NhaTaiTro NhaTaiTro { get; set; } = null;
        public virtual ObservableCollectionListSource<IdolSuKien> IdolSukien { get; } = new();
    }

    [NotMapped]
    public class DanhSachSuKien
    {
        public int SukienId { get; set; }
        public string TenSukien { get; set; } = string.Empty;
        public DateTime NgayToChuc { get; set; }
        public string DiaDiem { get; set; } = string.Empty;
        public int NhaTaiTroId { get; set; }
        public string TenNhaTaiTro { get; set; } = string.Empty;
    }
}

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class SuKien
    {
        [Key]
        public int SukienId { get; set; }
        public string TenSukien { get; set; } = string.Empty;
        public DateTime NgayToChuc { get; set; }
        public string DiaDiem { get; set; } = string.Empty;
        public virtual ObservableCollectionListSource<IdolSuKien> IdolSukien { get; } = new();
        public virtual ObservableCollectionListSource<NhaTaiTro> NhaTaiTro { get; } = new();
    }
}

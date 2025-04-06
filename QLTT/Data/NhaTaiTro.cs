using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class NhaTaiTro
    {
        [Key]
        public int NhaTaiTroId { get; set; }
        public string TenNhaTaiTro { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public int SuKienId { get; set; }
        public virtual SuKien SuKien { get; set; } = null!;
    }
}

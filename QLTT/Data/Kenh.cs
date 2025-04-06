using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class Kenh
    {
        [Key]
        public int KenhId { get; set; }
        public string TenKenh { get; set; }
        public string NenTang { get; set; } = string.Empty;
        public string UrlKenh { get; set; } = string.Empty;
        public int SoLuongNguoiDangKy { get; set; }
        public int TongLuotXem { get; set; }
        public int IdolId { get; set; }
        public virtual Idol Idol { get; set; } = null!;
        public virtual ObservableCollectionListSource<BuoiPhatSong> BuoiPhatSong { get; } = new();

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class BuoiPhatSong
    {
        [Key]
        public int BuoiPhatSongId { get; set; }
        public string TieuDe { get; set; } = string.Empty;
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int LuotXem { get; set; }

        public int KenhId { get; set; }
        public virtual Kenh Kenh { get; set; } = null!;
    }
}

using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class Idol
    {
        [Key]
        public int IdolId { get; set; }
        public string TenIdol { get; set; } = string.Empty;
        public DateTime NgayRaMat { get; set; }
        public string MoTa { get; set; } = string.Empty;
        public bool DangHoatDong { get; set; }

        public int CongTyId { get; set; }
        public virtual CongTy CongTy { get; set; } = null!;


        public virtual DanhTinh? DanhTinh { get; set; }

        public virtual ObservableCollectionListSource<Kenh> Kenh { get; } = new();
        public virtual ObservableCollectionListSource<BuoiPhatSong> BuoiPhatSong { get; } = new();
        public virtual ObservableCollectionListSource<Merch> Merch { get; } = new();
        public virtual ObservableCollectionListSource<IdolSuKien> IdolSuKien { get; } = new();
    }
}

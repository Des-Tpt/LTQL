using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string DangHoatDong { get; set; } = string.Empty;
        public int CongTyId { get; set; }

        public override string ToString()
        {
            return TenIdol;
        }

        public virtual CongTy CongTy { get; set; } = null!;
        public virtual ObservableCollectionListSource<Merch> Merch { get; } = new();
        public virtual ObservableCollectionListSource<IdolSuKien> IdolSuKien { get; } = new();
    }

    [NotMapped]
    public class DanhSachIdol
    {
        public int IdolId { get; set; }
        public string TenIdol { get; set; } = string.Empty;
        public DateTime NgayRaMat { get; set; }
        public string MoTa { get; set; } = string.Empty;
        public string DangHoatDong { get; set; } = string.Empty;
        public int CongTyId { get; set; }
        public string TenCongTy { get; set; }
    }
}
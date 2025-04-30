using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTT.Data
{
    internal class CongTy
    {
        [Key]
        public int CongTyId { get; set; }
        public string TenCongTy { get; set; } = string.Empty;
        public string QuocGia { get; set; } = string.Empty;
        public DateTime NgayThanhLap { get; set; }
        public string MoTa { get; set; } = string.Empty;
        public virtual ObservableCollectionListSource<Idol> Idol { get; } = new();
    }
}
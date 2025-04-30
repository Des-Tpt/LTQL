using System;
using System.Collections.Generic;
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
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CWeekhours
    {
        public CWeekhours()
        {
            BdHorarioWeekhour = new HashSet<BdHorarioWeekhour>();
        }

        public int IdWeekhour { get; set; }
        public string DescWeekhour { get; set; }
        public int? Weekday { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdHorarioWeekhour> BdHorarioWeekhour { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CReporteMovInventario
    {
        public CReporteMovInventario()
        {
            BdReporteMovInventario = new HashSet<BdReporteMovInventario>();
        }

        public int IdReporteMovInventario { get; set; }
        public DateTime? FecIni { get; set; }
        public DateTime? FecFin { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdReporteMovInventario> BdReporteMovInventario { get; set; }
    }
}

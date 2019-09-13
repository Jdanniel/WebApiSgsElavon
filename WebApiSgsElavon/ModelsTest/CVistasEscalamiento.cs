using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CVistasEscalamiento
    {
        public CVistasEscalamiento()
        {
            BdUsuarioVistaEscalamiento = new HashSet<BdUsuarioVistaEscalamiento>();
            BdVistaEscalamientoStatusAr = new HashSet<BdVistaEscalamientoStatusAr>();
        }

        public int IdVistaEscalamiento { get; set; }
        public string DescVistaEscalamiento { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual ICollection<BdUsuarioVistaEscalamiento> BdUsuarioVistaEscalamiento { get; set; }
        public virtual ICollection<BdVistaEscalamientoStatusAr> BdVistaEscalamientoStatusAr { get; set; }
    }
}

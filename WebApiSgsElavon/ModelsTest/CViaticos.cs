using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CViaticos
    {
        public CViaticos()
        {
            BdArViatico = new HashSet<BdArViatico>();
            BdSolicitudesViaticosConceptos = new HashSet<BdSolicitudesViaticosConceptos>();
        }

        public int IdViatico { get; set; }
        public string DescViatico { get; set; }
        public string Descripcion { get; set; }
        public int? IsAr { get; set; }
        public int? IsNotAr { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual ICollection<BdArViatico> BdArViatico { get; set; }
        public virtual ICollection<BdSolicitudesViaticosConceptos> BdSolicitudesViaticosConceptos { get; set; }
    }
}

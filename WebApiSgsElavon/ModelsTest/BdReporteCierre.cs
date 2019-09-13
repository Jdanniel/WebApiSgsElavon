using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReporteCierre
    {
        public BdReporteCierre()
        {
            BdReporteCierreAr = new HashSet<BdReporteCierreAr>();
        }

        public int IdReporteCierre { get; set; }
        public int IdCliente { get; set; }
        public string Report { get; set; }
        public int? NumArs { get; set; }
        public int? IdStatusReporteCierre { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string Status { get; set; }

        public virtual CClientes IdClienteNavigation { get; set; }
        public virtual CStatusReporteCierre IdStatusReporteCierreNavigation { get; set; }
        public virtual ICollection<BdReporteCierreAr> BdReporteCierreAr { get; set; }
    }
}

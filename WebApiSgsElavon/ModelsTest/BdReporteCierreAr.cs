using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReporteCierreAr
    {
        public int IdReporteCierreAr { get; set; }
        public int IdReporteCierre { get; set; }
        public int IdCliente { get; set; }
        public int IdAr { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CClientes IdClienteNavigation { get; set; }
        public virtual BdReporteCierre IdReporteCierreNavigation { get; set; }
    }
}

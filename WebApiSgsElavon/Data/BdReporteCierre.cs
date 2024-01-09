using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdReporteCierre
{
    public int IdReporteCierre { get; set; }

    public int IdCliente { get; set; }

    public string Report { get; set; }

    public int? NumArs { get; set; }

    public int? IdStatusReporteCierre { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdReporteCierreAr> BdReporteCierreArs { get; set; } = new List<BdReporteCierreAr>();

    public virtual CCliente IdClienteNavigation { get; set; }

    public virtual CStatusReporteCierre IdStatusReporteCierreNavigation { get; set; }
}

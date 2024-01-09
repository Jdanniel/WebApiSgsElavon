using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArVisita
{
    public int IdArVisita { get; set; }

    public int? IdAr { get; set; }

    public int? IdTecnico { get; set; }

    public int? IdTipoPrecio { get; set; }

    public int? IdMoneda { get; set; }

    public int? IdTipoCobro { get; set; }

    public int? IsCobrable { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FecVisita { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecStatus { get; set; }

    public int? IdUsuarioStatus { get; set; }

    public string Status { get; set; }

    public virtual CTipoCobro IdTipoCobroNavigation { get; set; }
}

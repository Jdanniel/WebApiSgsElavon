using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraInsumo
{
    public int IdBitacoraInsumo { get; set; }

    public int IdInsumo { get; set; }

    public int? IdStatusInsumoIni { get; set; }

    public int? IdStatusInsumoFin { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CStatusInsumo IdStatusInsumoFinNavigation { get; set; }

    public virtual CStatusInsumo IdStatusInsumoIniNavigation { get; set; }

    public virtual CTipoResponsable IdTipoResponsableNavigation { get; set; }
}

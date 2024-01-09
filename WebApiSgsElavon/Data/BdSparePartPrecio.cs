using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSparePartPrecio
{
    public int IdSparePartPrecio { get; set; }

    public int IdSparePart { get; set; }

    public int IdCliente { get; set; }

    public int? IdMoneda { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual CCliente IdClienteNavigation { get; set; }

    public virtual CMoneda IdMonedaNavigation { get; set; }

    public virtual CSparePart IdSparePartNavigation { get; set; }
}

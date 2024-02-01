using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdModeloPrecio
{
    public int IdModeloPrecio { get; set; }

    public int IdModelo { get; set; }

    public int IdCliente { get; set; }

    public int? IdMoneda { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual CCliente IdClienteNavigation { get; set; }

    public virtual CModelo IdModeloNavigation { get; set; }

    public virtual CMoneda IdMonedaNavigation { get; set; }
}

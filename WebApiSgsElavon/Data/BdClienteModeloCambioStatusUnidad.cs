using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdClienteModeloCambioStatusUnidad
{
    public int IdClienteModeloCambioStatusUnidad { get; set; }

    public int? IdCliente { get; set; }

    public int? IdModelo { get; set; }

    public int? IdStatusUnidadFrom { get; set; }

    public int? IdStatusUnidadTo { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}

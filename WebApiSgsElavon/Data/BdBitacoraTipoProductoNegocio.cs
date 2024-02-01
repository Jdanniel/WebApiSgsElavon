using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraTipoProductoNegocio
{
    public int IdBitacoraTipoProductoNegocio { get; set; }

    public int? IdProductoNegocio { get; set; }

    public string DescProductoNegocioAnterior { get; set; }

    public string DescProductoNegocioActual { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusActual { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? UsuarioAlta { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTipoPlazaCliente
{
    public int IdTipoPlazaCliente { get; set; }

    public int IdCliente { get; set; }

    public string DescTipoPlazaCliente { get; set; }

    public string Descripcion { get; set; }

    public int? IsDefault { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? Dias { get; set; }
}

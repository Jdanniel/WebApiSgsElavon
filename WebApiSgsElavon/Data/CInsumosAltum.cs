using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CInsumosAltum
{
    public int IdInsumo { get; set; }

    public string DescInsumo { get; set; }

    public string Descripcion { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Precio { get; set; }

    public int? IdCliente { get; set; }

    public int? IdTipoInsumo { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}

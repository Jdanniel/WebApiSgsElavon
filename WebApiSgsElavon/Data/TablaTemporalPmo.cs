using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TablaTemporalPmo
{
    public int? IdCliente { get; set; }

    public string Cliente { get; set; }

    public int? IdRegion { get; set; }

    public string DescRegion { get; set; }

    public int? IdProdcuto { get; set; }

    public string Producto { get; set; }

    public int? EventosSinCosto { get; set; }

    public decimal? MontoEventosSinCosto { get; set; }

    public int? EventosConCosto { get; set; }

    public decimal? MontoEventosConCosto { get; set; }

    public int? EventosSinHojaCobrable { get; set; }

    public decimal? MontoEventosSinHojaCobrable { get; set; }

    public int? TotalEventosSinHoja { get; set; }

    public decimal? MontoTotalEventosSinHoja { get; set; }

    public int? EventoSinPrecio { get; set; }

    public int? TotalEventos { get; set; }
}

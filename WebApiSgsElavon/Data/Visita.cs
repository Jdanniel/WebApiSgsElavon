using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Visita
{
    public int IdBitacoraAr { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public int IdAr { get; set; }

    public int? IdProducto { get; set; }

    public string DescProducto { get; set; }

    public int IdCliente { get; set; }

    public string DescCliente { get; set; }

    public int? IdTipoServicio { get; set; }

    public string DescTipoServicio { get; set; }

    public int? Visitas { get; set; }

    public int? DuracionVisita { get; set; }
}

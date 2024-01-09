using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TiempoAltaCau
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public string DescRegion { get; set; }

    public string DescZona { get; set; }

    public string NoAr { get; set; }

    public string DescProducto { get; set; }

    public string DescCliente { get; set; }

    public string DescTipoServicio { get; set; }

    public DateTime? FechaCargaTicket { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime FecInicio { get; set; }

    public int? Minutos { get; set; }
}

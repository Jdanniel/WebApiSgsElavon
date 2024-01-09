using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TiempoPrimerAsCdo
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public string IdIngeniero { get; set; }

    public string Nombre { get; set; }

    public string ApellidoPaterno { get; set; }

    public string ApellidoMaterno { get; set; }

    public int IdAr { get; set; }

    public string NoAr { get; set; }

    public string DescProducto { get; set; }

    public string DescCliente { get; set; }

    public DateTime? FechaAxc { get; set; }

    public DateTime? FechaAcdo { get; set; }

    public string Tiempo { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraReparacion
{
    public int IdBitacoraReparacion { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdReparacionUnidad { get; set; }

    public int? IdStatusUnidadAnterior { get; set; }

    public int? IdStatusUnidadActual { get; set; }

    public int? IdUsuarioAnterior { get; set; }

    public int? IdUsuarioAsignado { get; set; }

    public int? IdUsuarioCambio { get; set; }

    public string Comentario { get; set; }

    public DateTime? Fecha { get; set; }
}

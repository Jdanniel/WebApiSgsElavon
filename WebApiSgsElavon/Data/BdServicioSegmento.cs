using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdServicioSegmento
{
    public int IdServicioSegmento { get; set; }

    public int IdServicio { get; set; }

    public int IdSegmento { get; set; }

    public int? IdTipoPlaza { get; set; }

    public int? HorasGarantia { get; set; }

    public decimal? PrecioExito { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? CourtScheduleHours { get; set; }

    public int? CourtScheduleMinutes { get; set; }

    public int? Tr { get; set; }

    public int? Ts { get; set; }

    public int? Ta { get; set; }
}

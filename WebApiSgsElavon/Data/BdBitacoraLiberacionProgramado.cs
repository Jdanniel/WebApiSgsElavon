using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraLiberacionProgramado
{
    public int IdBitacoraLiberacionProgramado { get; set; }

    public int? IdAr { get; set; }

    public DateTime? FecInicioAnterior { get; set; }

    public DateTime? FecInicioFin { get; set; }

    public DateTime? FecAltaInicio { get; set; }

    public DateTime? FecAltaFin { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdUsuarioAlta { get; set; }
}

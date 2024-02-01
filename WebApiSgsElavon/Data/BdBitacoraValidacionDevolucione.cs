using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraValidacionDevolucione
{
    public int IdBitacoraValidacionDevoluciones { get; set; }

    public int? IdSolicitudDevolucion { get; set; }

    public int? IdStatusIni { get; set; }

    public int? IdStatusFin { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Documento { get; set; }

    public string Comentario { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BitacoraAActualizar
{
    public int IdBitacoraUnidad { get; set; }

    public int IdUnidad { get; set; }

    public int? IdStatusUnidadIni { get; set; }

    public int? IdStatusUnidadFin { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Comentario { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BitacoraSolucionErroresLeberacion
{
    public int IdBitacoraSolucion { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Comentario { get; set; }
}

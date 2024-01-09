using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraDiasFestivo
{
    public int IdBitacoraDiasFestivos { get; set; }

    public int? IdFestivos { get; set; }

    public string Comentario { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}

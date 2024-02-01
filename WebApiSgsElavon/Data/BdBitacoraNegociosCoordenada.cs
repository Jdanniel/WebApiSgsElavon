using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraNegociosCoordenada
{
    public int IdBitcoraNegocioCoordenada { get; set; }

    public int? IdNegocio { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdAr { get; set; }

    public int? IdStatusAr { get; set; }
}

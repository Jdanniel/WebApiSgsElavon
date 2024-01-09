using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraNoInsumoAr
{
    public int IdBitacoraNoInsumoAr { get; set; }

    public int? IdAr { get; set; }

    public int? IdInsumo { get; set; }

    public int? IdTecnico { get; set; }

    public string Causa { get; set; }

    public DateTime? FecAlta { get; set; }
}

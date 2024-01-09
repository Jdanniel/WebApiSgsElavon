using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraCostosMensajeria
{
    public int IdBitacoraCostoFiull { get; set; }

    public int? IdTabla { get; set; }

    public decimal? CostoAnterior { get; set; }

    public decimal? CostoActual { get; set; }

    public int? IdUsuario { get; set; }

    public string TablaModificada { get; set; }

    public DateTime? FechaAlta { get; set; }
}

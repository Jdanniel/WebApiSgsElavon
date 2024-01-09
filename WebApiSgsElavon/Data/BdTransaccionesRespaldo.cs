using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdTransaccionesRespaldo
{
    public int IdTransaccionRespaldo { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public int? NoAfiliacion { get; set; }

    public int? ApprovedcCount { get; set; }

    public int? Declinedcount { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdUsuario { get; set; }
}

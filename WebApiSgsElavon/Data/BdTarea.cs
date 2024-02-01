using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTarea
{
    public int IdTarea { get; set; }

    public int IdAr { get; set; }

    public int IdServicioTarea { get; set; }

    public string DescTrabajo { get; set; }

    public string Folio { get; set; }

    public string IdAttatch { get; set; }

    public int? IdTipoCierreTarea { get; set; }

    public DateTime FecAlta { get; set; }

    public int IdAlta { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string Status { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdNegociosMigradosLog
{
    public int IdNegociosMigradosLog { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdBitacoraNegocioMigracion { get; set; }

    public string Status { get; set; }

    public string Comentario { get; set; }
}

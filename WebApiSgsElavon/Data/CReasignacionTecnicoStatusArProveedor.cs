using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CReasignacionTecnicoStatusArProveedor
{
    public int IdReasignacionTecnicoStatusArProveedor { get; set; }

    public int? IdStatusAr { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }
}

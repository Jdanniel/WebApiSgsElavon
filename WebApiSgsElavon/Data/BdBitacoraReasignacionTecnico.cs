using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraReasignacionTecnico
{
    public int IdBitacora { get; set; }

    public int? IdReparacionUnidad { get; set; }

    public int? IdUsuarioAnterior { get; set; }

    public int? IdUsuarioAsignado { get; set; }

    public int? IdUsuarioCambio { get; set; }

    public string Status { get; set; }

    public DateTime? Fecha { get; set; }
}

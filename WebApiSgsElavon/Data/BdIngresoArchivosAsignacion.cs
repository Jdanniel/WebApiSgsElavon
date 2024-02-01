using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdIngresoArchivosAsignacion
{
    public int IdArchivoMasivo { get; set; }

    public int? IdArchivo { get; set; }

    public int? IdAr { get; set; }

    public DateTime? FecAtencion { get; set; }

    public string HoraAtencion { get; set; }

    public int? IdTecnico { get; set; }

    public int? IdDispatcher { get; set; }

    public string StatusArchivo { get; set; }

    public int? IdUsuarioAltaArchivo { get; set; }

    public DateTime? FechaAltaArchivo { get; set; }

    public string DescError { get; set; }
}

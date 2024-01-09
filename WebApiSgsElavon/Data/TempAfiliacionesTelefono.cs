using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempAfiliacionesTelefono
{
    public int? IdAr { get; set; }

    public string Odt { get; set; }

    public string Afiliacion { get; set; }

    public string Telefono { get; set; }

    public DateTime? FechaCierreSistema { get; set; }

    public DateTime? FechaAltaSistema { get; set; }

    public string DescTipoCarga { get; set; }

    public string DescSolucion { get; set; }

    public string DescZona { get; set; }

    public string TipoServicio { get; set; }

    public string EstatusServicio { get; set; }

    public int? Zona { get; set; }

    public int? TipoCarga { get; set; }

    public int? IdServicio { get; set; }

    public int? IdStatusAr { get; set; }

    public int? IdUsuario { get; set; }

    public int? TipoAtencion { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdNegociosAltum
{
    public int IdNegocioAlta { get; set; }

    public int? IdCliente { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdSegmento { get; set; }

    public string DescNegocio { get; set; }

    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public int? IdEstado { get; set; }

    public string Cp { get; set; }

    public int? IdHorarioUptime { get; set; }

    public int? IdHorarioAcceso { get; set; }

    public int? IsCpIncorrecto { get; set; }

    public int? IsRegionIncorrecto { get; set; }

    public int? IsZonaIncorrecto { get; set; }

    public int? IsIdEstadoIncorrecto { get; set; }

    public int? IsNoAfiliacionDuplicado { get; set; }

    public int? IsProcesado { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual CCliente IdClienteNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Informe
{
    public int IdAr { get; set; }

    public string Odt { get; set; }

    public string Estado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string TipoComercio { get; set; }

    public string Nivel { get; set; }

    public string TipoServicio { get; set; }

    public string IdTecnico { get; set; }

    public string Proveedor { get; set; }

    public string EstatusServicio { get; set; }

    public string EstatusServicio1 { get; set; }

    public DateTime? FechaAtencionProveedor { get; set; }

    public DateTime? FechaCierreSistema { get; set; }

    public DateTime FechaAltaSistema { get; set; }

    public string SlaFijo { get; set; }

    public string NivelSla { get; set; }

    public string TipoComercio2 { get; set; }

    public string Producto { get; set; }

    public string Zona { get; set; }

    public string TieneAmex { get; set; }

    public string AreaCarga { get; set; }

    public string AltaPor { get; set; }

    public string TipoCarga { get; set; }

    public string CerradoPor { get; set; }
}

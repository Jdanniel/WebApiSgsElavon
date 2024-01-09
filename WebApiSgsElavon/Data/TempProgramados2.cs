using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempProgramados2
{
    public int IdAr { get; set; }

    public string Odt { get; set; }

    public string NoAfiliacion { get; set; }

    public string Comercio { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Ciudad { get; set; }

    public string Estado { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string Descripcion { get; set; }

    public string Observaciones { get; set; }

    public string Telefono { get; set; }

    public string TipoComercio { get; set; }

    public string Nivel { get; set; }

    public string TipoServicio { get; set; }

    public string SubTipoServicio { get; set; }

    public string Proveedor { get; set; }

    public string EstatusServicio { get; set; }

    public DateTime? FechaAtencionProveedor { get; set; }

    public DateTime? FechaCierreSistema { get; set; }

    public DateTime? FechaAltaSistema { get; set; }

    public string CodigoPostal { get; set; }

    public string Conclusiones { get; set; }

    public int? SlaFijo { get; set; }

    public string MotivoRechazo { get; set; }

    public string Zona { get; set; }

    public string Rechazo { get; set; }

    public string AreaCarga { get; set; }

    public string AltaPor { get; set; }

    public string TipoCarga { get; set; }

    public string CerradoPor { get; set; }

    public string AreaCierra { get; set; }

    public string OdtSalesforce { get; set; }

    public DateTime? FecProgramado { get; set; }

    public DateTime? FecAbierta { get; set; }

    public int? IdUsuarioProgramado { get; set; }

    public DateTime? FechaInicioBitacora { get; set; }

    public DateTime? FechaFinBitacora { get; set; }

    public int Usuario { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class LogBdNegocio
{
    public int IdNegocio { get; set; }

    public int IdCliente { get; set; }

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

    public int? IdCargaAlta { get; set; }

    public int? IdCargaStatus { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public decimal? GradoError { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioUpdate { get; set; }

    public DateTime? FecUpdate { get; set; }

    public string Status { get; set; }

    public decimal? Precio { get; set; }

    public int? IdTipoCobroNegocio { get; set; }

    public int? IdMoneda { get; set; }

    public string RazonSocial { get; set; }

    public string NombreFiscal { get; set; }

    public string RfcFiscal { get; set; }

    public string CalleNumFiscal { get; set; }

    public string CpFiscal { get; set; }

    public string ColoniaFiscal { get; set; }

    public string PoblacionFiscal { get; set; }

    public string IdEstadoFiscal { get; set; }

    public DateTime? FecAltaIguala { get; set; }

    public DateTime? FecBajaIguala { get; set; }

    public int? Aproximado { get; set; }

    public string CorreoEjecutivo { get; set; }
}

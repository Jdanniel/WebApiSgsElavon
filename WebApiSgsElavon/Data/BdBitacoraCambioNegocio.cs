using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCambioNegocio
{
    public int IdBitacoraCambioNegocio { get; set; }

    public int? IdNegocio { get; set; }

    public int? IdRegionAnterior { get; set; }

    public int? IdRegioActual { get; set; }

    public int? IdZonaAnterior { get; set; }

    public int? IdZonaActual { get; set; }

    public int? IdSegmentoAnterior { get; set; }

    public int? IdSegmentoActual { get; set; }

    public string DescNegocioAnterior { get; set; }

    public string DescNegocioActual { get; set; }

    public string TelefonoAnterior { get; set; }

    public string TelefonoActual { get; set; }

    public string DireccionAnterior { get; set; }

    public string DireccionActual { get; set; }

    public string ColoniaAnterior { get; set; }

    public string ColoniaActual { get; set; }

    public string PoblacionAnterior { get; set; }

    public string PoblacionActual { get; set; }

    public string EstadoAnterior { get; set; }

    public string EstadoActual { get; set; }

    public int? IdEstadoAnterior { get; set; }

    public int? IdEstadoActual { get; set; }

    public string CpAnterior { get; set; }

    public string CpActual { get; set; }

    public int? IdCargaStatusAnterior { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdCarga { get; set; }

    public string RfcFiscalAnterior { get; set; }

    public string RfcFiscalActual { get; set; }

    public string RazonSocialAnterior { get; set; }

    public string RazonSocialActual { get; set; }

    public string CorreoEjecutivoAnterior { get; set; }

    public string CorreoEjecutivoActual { get; set; }
}

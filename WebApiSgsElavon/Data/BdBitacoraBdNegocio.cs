using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraBdNegocio
{
    public int IdBitacoraBdNegocios { get; set; }

    public int? IdNegocio { get; set; }

    public string NoAfiliacionAnterior { get; set; }

    public string NoAfiliacionActual { get; set; }

    public int? IdZonaAnterior { get; set; }

    public int? IdZonaActual { get; set; }

    public int? IdRegionAnterior { get; set; }

    public int? IdRegionActual { get; set; }

    public int? IdClienteAnterior { get; set; }

    public int? IdClienteActual { get; set; }

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

    public string CpAnterior { get; set; }

    public string CpActual { get; set; }

    public int? IdEstadoAnterior { get; set; }

    public int? IdEstadoActual { get; set; }

    public string LatitudAnterior { get; set; }

    public string LatitudActual { get; set; }

    public string LongitudAnterior { get; set; }

    public string LongitudActual { get; set; }

    public int? IdHorarioUptimeAnterior { get; set; }

    public int? IdHorarioUptimeActual { get; set; }

    public int? IdHorarioAccesoAnterior { get; set; }

    public int? IdHorarioAccesoActual { get; set; }

    public int? IdTipoCobroNegocioAnterior { get; set; }

    public int? IdTipoCobroNegocioActual { get; set; }

    public int? IdMonedaAnterior { get; set; }

    public int? IdMonedaActual { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusActual { get; set; }

    public string PrecioAnterior { get; set; }

    public string PrecioActual { get; set; }

    public DateTime? FecAltaIgualaAnterior { get; set; }

    public DateTime? FecAltaIgualaActual { get; set; }

    public DateTime? FecBajaIgualaAnterior { get; set; }

    public DateTime? FecBajaIgualaActual { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}

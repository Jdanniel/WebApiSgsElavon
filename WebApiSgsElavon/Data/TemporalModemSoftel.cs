using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TemporalModemSoftel
{
    public DateTime? FecAltaWincor { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? TiempoDeCarga { get; set; }

    public string EfectividadCarga { get; set; }

    public DateTime? FecAtencion { get; set; }

    public DateTime? FecGarantia { get; set; }

    public string EfectividadCita { get; set; }

    public DateTime? FechaPrimerStatusAsignacionPorConfirmar { get; set; }

    public int? EfectividadAsignacionDif { get; set; }

    public string EfectividadAsignacion { get; set; }

    public DateTime? FecLlegada { get; set; }

    public int? TiempoDeLlegada { get; set; }

    public string EfectividadLlegada { get; set; }

    public DateTime? FecCierre { get; set; }

    public DateTime? FechaPrimerStatusAtendidoORechazado { get; set; }

    public int? EfectividadTiempoCierreDif { get; set; }

    public string EfectividadTiempoCierre { get; set; }

    public DateTime? FecIniIngeniero { get; set; }

    public DateTime? FecFinIngeniero { get; set; }

    public int? TiempoSolucionMin { get; set; }

    public int IdCliente { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int IdAr { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime? FecBitacora { get; set; }

    public int? StatusFinAr { get; set; }
}

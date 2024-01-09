using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempOkiServiciosCorrectivo
{
    public string Cliente { get; set; }

    public string Servicio { get; set; }

    public int IdAr { get; set; }

    public string NoAr { get; set; }

    public string NoAfiliacion { get; set; }

    public string Region { get; set; }

    public string Zona { get; set; }

    public string TiempoDeArribo { get; set; }

    public string Cajero { get; set; }

    public string CodigoIntervencion { get; set; }

    public string Cod0 { get; set; }

    public string Cod1 { get; set; }

    public string Cod2 { get; set; }

    public string ExitoRechazo { get; set; }

    public string CausaRechazo { get; set; }

    public string FechaInterfaz { get; set; }

    public string HoraInterfaz { get; set; }

    public string FechaCarga { get; set; }

    public string HoraCarga { get; set; }

    public int? TiempoDeCarga { get; set; }

    public string EfectividadCarga { get; set; }

    public string FechaIncio { get; set; }

    public string HoraInicio { get; set; }

    public string FechaGarantia { get; set; }

    public string HoraGarantia { get; set; }

    public string EfectividadCita { get; set; }

    public string PrimeroAsignado { get; set; }

    public string EfectividadAsignacion { get; set; }

    public string FechaCita { get; set; }

    public string HoraCita { get; set; }

    public string FechaLlegada { get; set; }

    public string HoraLlegada { get; set; }

    public int? TiempoDeLlegada { get; set; }

    public string EfectividadLlegada { get; set; }

    public string FechaInicioIng { get; set; }

    public string HoraInicioIng { get; set; }

    public string FechaFinIng { get; set; }

    public string HoraFinIng { get; set; }

    public int? TiempoSolucionMin { get; set; }

    public string FechaCierre { get; set; }

    public string HoraCierre { get; set; }

    public string PrimerAtendido { get; set; }

    public string EfectividadTiempoCierre { get; set; }

    public string IngenieroDeCampo { get; set; }

    public string Solucion { get; set; }

    public string EspecificacionSolucion { get; set; }

    public string Cierre { get; set; }

    public string Retipificado { get; set; }

    public string MotivoRetipificado { get; set; }

    public DateTime? FecConsulta { get; set; }
}

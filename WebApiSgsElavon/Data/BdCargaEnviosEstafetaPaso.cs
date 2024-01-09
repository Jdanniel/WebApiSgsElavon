using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCargaEnviosEstafetaPaso
{
    public int IdCargaEnvioEstafetaPaso { get; set; }

    public int? IdCarga { get; set; }

    public string Guia { get; set; }

    public DateTime? Fecha { get; set; }

    public string Orig { get; set; }

    public string Dest { get; set; }

    public int? Zona { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Sobrepeso { get; set; }

    public decimal? DifKilos { get; set; }

    public decimal? PesoFactura { get; set; }

    public int? LargoCm { get; set; }

    public int? AnchoCm { get; set; }

    public int? AltoCm { get; set; }

    public string VolReal { get; set; }

    public decimal? MtoServ { get; set; }

    public decimal? MontoSp { get; set; }

    public decimal? MtoCbServ { get; set; }

    public DateTime? FecEntrega { get; set; }

    public int? TiempoEntrega { get; set; }

    public string Recibe { get; set; }

    public string TipoEmpaque { get; set; }

    public string Referencia { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsProcesado { get; set; }
}

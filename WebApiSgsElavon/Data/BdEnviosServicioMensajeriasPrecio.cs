using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEnviosServicioMensajeriasPrecio
{
    public int IdServicioMensajeriasPrecio { get; set; }

    public string Mensajeria { get; set; }

    public int? Zona { get; set; }

    public decimal? Costo { get; set; }

    public string Urgencia { get; set; }

    public string Servicio { get; set; }

    public int? KgSolicitados { get; set; }

    public decimal? PrecioAddicionalPorKg { get; set; }

    public decimal? PrecioTotal { get; set; }

    public int? Solicitud { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IdEnvio { get; set; }

    public string NoGuia { get; set; }

    public int? IdServicioMensajeria { get; set; }

    public int? KgFinal { get; set; }

    public decimal? PrecioFinal { get; set; }

    public int? IdMensajeriaFinal { get; set; }
}

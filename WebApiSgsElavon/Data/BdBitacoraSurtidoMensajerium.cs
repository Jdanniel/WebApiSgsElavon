using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraSurtidoMensajerium
{
    public int IdSurtidoMensajeria { get; set; }

    public int? IdEnvio { get; set; }

    public int? IdSolicitudAlmacen { get; set; }

    public int? Mensajeria { get; set; }

    public int? Servicio { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Costo { get; set; }

    public int? Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }
}

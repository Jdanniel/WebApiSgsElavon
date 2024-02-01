using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraEmbarquesMensajerium
{
    public int IdEmbarqueMensajeria { get; set; }

    public int? IdEnvio { get; set; }

    public int? IdSolicitudAlmacen { get; set; }

    public int? Mensajeria { get; set; }

    public string NoGuia { get; set; }

    public DateTime? HoraEntrega { get; set; }

    public int? IdChofer { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? Status { get; set; }
}

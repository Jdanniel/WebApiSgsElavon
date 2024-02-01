using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdSolicitudesViatico
{
    public int IdSolicitudViaticos { get; set; }

    public int IdStatusSolicitudViaticos { get; set; }

    public int? IdAr { get; set; }

    public string Destino { get; set; }

    public string ComentarioSolicitante { get; set; }

    public string ComentarioAutorizador { get; set; }

    public string ComentarioConfirmador { get; set; }

    public int? IdCuentaBancaria { get; set; }

    public string NumConfirmacion { get; set; }

    public DateTime? FecConfirmacion { get; set; }

    public int? IdUsuarioSolicitado { get; set; }

    public int? IdComprobacionSolicitudesViaticos { get; set; }

    public int? IdCliente { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public int? FromAutomatizacion { get; set; }
    public virtual ICollection<BdBitacoraSolicitudesViatico> BdBitacoraSolicitudesViaticos { get; set; } = new List<BdBitacoraSolicitudesViatico>();
    public virtual CStatusSolicitudViatico IdStatusSolicitudViaticosNavigation { get; set; }
}

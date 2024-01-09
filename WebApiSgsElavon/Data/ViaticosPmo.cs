using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ViaticosPmo
{
    public int? IdCliente { get; set; }

    public int? IdUsuarioSolicitado { get; set; }

    public int? IdRegion { get; set; }

    public string Producto { get; set; }

    public string Tipo { get; set; }

    public DateTime? FecConfirmacion { get; set; }

    public decimal CantidadAutorizada { get; set; }

    public int? IdConceptoPmo { get; set; }

    public int IdViatico { get; set; }

    public int IdSolicitudViaticos { get; set; }
}

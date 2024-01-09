using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdAccesoriosRefaccionReparacion
{
    public int IdAccesoriosRefaccionReparacion { get; set; }

    public int? IdAccesorioRefaccion { get; set; }

    public string TipoAccesorioRefaccion { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdReparacionUnidad { get; set; }

    public int? Cantidad { get; set; }

    public int? CantidadInstalacion { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdUsuario { get; set; }

    public string Tipo { get; set; }

    public string Status { get; set; }
}

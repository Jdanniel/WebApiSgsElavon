using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdDireccionesRelacione
{
    public int IdDireccionRelacion { get; set; }

    public int IdDireccion { get; set; }

    public int IdTipoResponsable { get; set; }

    public int IdResponsable { get; set; }

    public DateTime FecAlta { get; set; }

    public int IdUsuarioAlta { get; set; }

    public int? IsDefault { get; set; }
}

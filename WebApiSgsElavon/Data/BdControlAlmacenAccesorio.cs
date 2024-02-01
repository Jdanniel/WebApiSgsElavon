using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdControlAlmacenAccesorio
{
    public int IdControlAlmacenInsumos { get; set; }

    public int? IdAccesorio { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? Entrada { get; set; }

    public int? Salida { get; set; }

    public int? Total { get; set; }
}

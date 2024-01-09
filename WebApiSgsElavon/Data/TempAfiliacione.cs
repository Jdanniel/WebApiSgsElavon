using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempAfiliacione
{
    public int IdTempAfilacion { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdCliente { get; set; }

    public string IdResponsable { get; set; }
}

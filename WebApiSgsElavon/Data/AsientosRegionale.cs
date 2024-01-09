using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class AsientosRegionale
{
    public int Id { get; set; }

    public DateOnly? Fecha { get; set; }

    public string Poliza { get; set; }

    public string Cuenta { get; set; }

    public string Nombre { get; set; }

    public double? Importe { get; set; }

    public string Descripcion { get; set; }

    public string Region { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class RefaccionesInstalada
{
    public int Id { get; set; }

    public string Region { get; set; }

    public string Producto { get; set; }

    public DateOnly? Fecha { get; set; }

    public double? Importe { get; set; }
}

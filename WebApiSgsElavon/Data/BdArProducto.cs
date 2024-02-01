using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArProducto
{
    public int IdArProducto { get; set; }

    public int? IdAr { get; set; }

    public string Producto { get; set; }

    public int? IdCarga { get; set; }

    public int? IsProducto { get; set; }
}

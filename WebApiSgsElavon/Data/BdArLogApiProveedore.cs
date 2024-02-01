using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArLogApiProveedore
{
    public int IdArLogApiProveedor { get; set; }

    public int? IdAr { get; set; }

    public string NoAr { get; set; }

    public string Estado { get; set; }

    public int? IdProveedorAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Jsonp { get; set; }
}

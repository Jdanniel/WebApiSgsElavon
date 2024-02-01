using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArSparePart
{
    public int IdArSparePart { get; set; }

    public int IdAr { get; set; }

    public int IdSparePart { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal PrecioTotal { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual CSparePart IdSparePartNavigation { get; set; }
}

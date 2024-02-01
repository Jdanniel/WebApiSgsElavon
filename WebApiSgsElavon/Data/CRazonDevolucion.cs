using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CRazonDevolucion
{
    public int IdRazonDevolucion { get; set; }

    public string DescRazonDevolucion { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdDevolucione> BdDevoluciones { get; set; } = new List<BdDevolucione>();
}

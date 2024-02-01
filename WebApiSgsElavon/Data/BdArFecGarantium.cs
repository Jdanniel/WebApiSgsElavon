using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArFecGarantium
{
    public int IdArFecGarantia { get; set; }

    public int? IdAr { get; set; }

    public string Status { get; set; }

    public string Error { get; set; }
}

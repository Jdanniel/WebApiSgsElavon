using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArNegotiationType
{
    public int IdArTipoNegociacion { get; set; }

    public int? IdAr { get; set; }

    public string NegotiationType { get; set; }
}

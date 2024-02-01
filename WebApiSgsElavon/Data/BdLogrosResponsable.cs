using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdLogrosResponsable
{
    public int IdLogrosResponsables { get; set; }

    public int? IdLogro { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdArea { get; set; }
}

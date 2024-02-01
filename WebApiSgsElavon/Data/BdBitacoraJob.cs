using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraJob
{
    public int IdBitacoraJob { get; set; }

    public string JobName { get; set; }

    public DateTime? Fecha { get; set; }

    public string Status { get; set; }
}

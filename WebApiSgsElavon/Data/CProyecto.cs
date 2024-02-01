using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CProyecto
{
    public int IdProyecto { get; set; }

    public int? IdCliente { get; set; }

    public string DescProyecto { get; set; }

    public string Descripcion { get; set; }

    public int? NumUnidades { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? FecGarantia { get; set; }

    public string Status { get; set; }
}

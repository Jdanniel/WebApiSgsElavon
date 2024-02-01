using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CModelosValidosEglobal
{
    public int? IdModelo { get; set; }

    public int? IdCliente { get; set; }

    public string Tecnologia { get; set; }

    public string Aplicacion { get; set; }

    public string Modelo { get; set; }

    public string Sim { get; set; }

    public string Reporte { get; set; }
}

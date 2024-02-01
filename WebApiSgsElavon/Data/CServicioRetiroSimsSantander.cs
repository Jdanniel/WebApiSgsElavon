using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CServicioRetiroSimsSantander
{
    public int? IdServicio { get; set; }

    public int? IdCliente { get; set; }

    public string DescServicio { get; set; }

    public string DescServicioSantander { get; set; }
}

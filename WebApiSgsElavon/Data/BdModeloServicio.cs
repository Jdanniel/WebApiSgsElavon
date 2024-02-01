using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdModeloServicio
{
    public int IdModeloServicio { get; set; }

    public int IdModelo { get; set; }

    public int IdServicio { get; set; }

    public int IdCliente { get; set; }

    public int? IsInstalacion { get; set; }

    public int? IsSustitucion { get; set; }

    public int? IsRetiro { get; set; }

    public string IsChecked { get; set; }
}

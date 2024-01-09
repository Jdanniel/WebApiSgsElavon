using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdModeloSku
{
    public int IdModeloSku { get; set; }

    public int IdModelo { get; set; }

    public int IdCliente { get; set; }

    public string Sku { get; set; }

    public decimal? Precio { get; set; }

    public DateTime FecAlta { get; set; }

    public int IdUsuarioAlta { get; set; }

    public virtual CCliente IdClienteNavigation { get; set; }

    public virtual CModelo IdModeloNavigation { get; set; }
}

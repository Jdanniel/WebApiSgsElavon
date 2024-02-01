using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdModeloInsumo
{
    public int IdModeloInsumo { get; set; }

    public int? IdModelo { get; set; }

    public int? IdInsumo { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
    public virtual CModelo IdModeloNavigation { get; set; }
}

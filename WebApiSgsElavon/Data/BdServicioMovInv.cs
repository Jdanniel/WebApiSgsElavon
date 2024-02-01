using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdServicioMovInv
{
    public int IdServicioMovInv { get; set; }

    public int? IdCliente { get; set; }

    public int IdServicio { get; set; }

    public int IdMovInv { get; set; }

    public int? IsRequired { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual CMovInv IdMovInvNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdModeloAccesorio
{
    public int IdModeloAccesorio { get; set; }

    public int? IdModelo { get; set; }

    public int? IdAccesorio { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CAccesorio IdAccesorioNavigation { get; set; }

    public virtual CModelo IdModeloNavigation { get; set; }
}

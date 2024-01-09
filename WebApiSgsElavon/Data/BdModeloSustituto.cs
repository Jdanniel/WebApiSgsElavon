using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdModeloSustituto
{
    public int Id { get; set; }

    public int? IdModelo { get; set; }

    public int? IdModeloSustituto { get; set; }

    public int? IdSoftware { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual CModelo IdModeloNavigation { get; set; }

    public virtual CModelo IdModeloSustitutoNavigation { get; set; }

    public virtual CSoftware IdSoftwareNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdSolicitudesDevolucionModelo
{
    public int IdSolicitudDevolucionModelo { get; set; }

    public int? IdSolicitudDevolucion { get; set; }

    public int? IdModelo { get; set; }

    public int? NoUnidades { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CModelo IdModeloNavigation { get; set; }

    public virtual CUsuario IdUsuarioAltaNavigation { get; set; }
}

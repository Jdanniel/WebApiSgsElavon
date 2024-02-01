using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdInstalacione
{
    public int IdInstalacion { get; set; }

    public int IdAr { get; set; }

    public int IdNegocio { get; set; }

    public int? IdTecnico { get; set; }

    public int IdUnidad { get; set; }

    public int? IsNueva { get; set; }

    public int? IdParent { get; set; }

    public int? IdClienteIni { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Tipo { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdAplicativo { get; set; }

    public virtual CCliente IdClienteIniNavigation { get; set; }

    public virtual BdNegocio IdNegocioNavigation { get; set; }

    public virtual BdUnidade IdParentNavigation { get; set; }

    public virtual CUsuario IdTecnicoNavigation { get; set; }

    public virtual BdUnidade IdUnidadNavigation { get; set; }
}

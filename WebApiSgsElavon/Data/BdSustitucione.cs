using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSustitucione
{
    public int IdSustitucion { get; set; }

    public int IdAr { get; set; }

    public int IdNegocio { get; set; }

    public int? IdTecnico { get; set; }

    public int? IdParent { get; set; }

    public int IdUnidadEntrada { get; set; }

    public string NoEquipoEntrada { get; set; }

    public int IdUnidadSalida { get; set; }

    public string NoEquipoSalida { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual BdNegocio IdNegocioNavigation { get; set; }

    public virtual CUsuario IdTecnicoNavigation { get; set; }

    public virtual BdUnidade IdUnidadEntradaNavigation { get; set; }

    public virtual BdUnidade IdUnidadSalidaNavigation { get; set; }
}

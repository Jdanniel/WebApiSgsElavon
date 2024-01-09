using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraModeloUnidad
{
    public int IdBitacoraModeloUnidad { get; set; }

    public int IdUnidad { get; set; }

    public int IdModeloViejo { get; set; }

    public int IdModeloNuevo { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FechaAlta { get; set; }

    public virtual CModelo IdModeloNuevoNavigation { get; set; }

    public virtual CModelo IdModeloViejoNavigation { get; set; }

    public virtual BdUnidade IdUnidadNavigation { get; set; }

    public virtual CUsuario IdUsuarioAltaNavigation { get; set; }
}

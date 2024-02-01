using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdModeloModulo
{
    public int Id { get; set; }

    public int IdModelo { get; set; }

    public int IdProductoModulo { get; set; }

    public int IdMarcaModulo { get; set; }

    public int IdModeloModulo { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CMarca IdMarcaModuloNavigation { get; set; }

    public virtual CModelo IdModeloModuloNavigation { get; set; }

    public virtual CModelo IdModeloNavigation { get; set; }

    public virtual CProducto IdProductoModuloNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CProsaAbc
{
    public int IdProsaAbc { get; set; }

    public int? IdFalla { get; set; }

    public int? IdServicio { get; set; }

    public int? IdProductoNegocio { get; set; }

    public string DescProsaAbc { get; set; }

    public int? OdtProveedor { get; set; }

    public int? OdtProsa { get; set; }

    public int? OrdenProveedor { get; set; }

    public int? OrdenProsa { get; set; }

    public int? IdStatusArProveedor { get; set; }

    public int? IdStatusArProsa { get; set; }

    public int? IsUnique { get; set; }
}

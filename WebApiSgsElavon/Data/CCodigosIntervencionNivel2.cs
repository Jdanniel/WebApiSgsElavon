using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CCodigosIntervencionNivel2
{
    public int IdCodigoNivel2 { get; set; }

    public string ClaveCodigo { get; set; }

    public string DescCodigo { get; set; }

    public int? IdCliente { get; set; }

    public string Status { get; set; }

    public int? IdParentNivel1 { get; set; }

    public int? IdParentNivel0 { get; set; }
}

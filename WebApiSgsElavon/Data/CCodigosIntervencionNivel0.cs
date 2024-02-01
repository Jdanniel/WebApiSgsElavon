using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CCodigosIntervencionNivel0
{
    public int IdCodigoNivel0 { get; set; }

    public string ClaveCodigo { get; set; }

    public string DescCodigo { get; set; }

    public int? IdCliente { get; set; }

    public string Status { get; set; }

    public int? IdTipoMedida { get; set; }

    public int? ReportaInstalacion { get; set; }

    public virtual ICollection<CCodigosIntervencionNivel1> CCodigosIntervencionNivel1s { get; set; } = new List<CCodigosIntervencionNivel1>();
}

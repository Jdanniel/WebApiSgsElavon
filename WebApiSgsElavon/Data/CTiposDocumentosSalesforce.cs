using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTiposDocumentosSalesforce
{
    public int IdTipoDocumentoSalesforce { get; set; }

    public string DescTipoDocumento { get; set; }

    public bool? Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}

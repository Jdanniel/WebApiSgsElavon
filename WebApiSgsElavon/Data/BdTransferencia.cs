using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTransferencia
{
    public int IdTransferencia { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdStatusTransferencia { get; set; }

    public string Status { get; set; }

    public string SystemFilename { get; set; }

    public string UserFilename { get; set; }
}

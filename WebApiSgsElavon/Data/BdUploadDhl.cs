using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdUploadDhl
{
    public int IdUploadDhl { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}

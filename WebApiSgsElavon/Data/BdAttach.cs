using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdAttach
{
    public int IdAttach { get; set; }

    public int? IdTipoArchivo { get; set; }

    public string DescAttach { get; set; }

    public string SystemFilename { get; set; }

    public string UserFilename { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual ICollection<BdFotoAr> BdFotoArs { get; set; } = new List<BdFotoAr>();
}

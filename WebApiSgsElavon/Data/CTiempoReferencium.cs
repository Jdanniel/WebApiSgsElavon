using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTiempoReferencium
{
    public int IdTiempoReferencia { get; set; }

    public string DescTiempoReferencia { get; set; }

    public string Descripcion { get; set; }

    public int? Factor { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdReglasStatusAr> BdReglasStatusArs { get; set; } = new List<BdReglasStatusAr>();
}

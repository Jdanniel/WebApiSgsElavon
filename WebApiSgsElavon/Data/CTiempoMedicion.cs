using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTiempoMedicion
{
    public int IdTiempoMedicion { get; set; }

    public string DescTiempoMedicion { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdReglasStatusAr> BdReglasStatusArs { get; set; } = new List<BdReglasStatusAr>();
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTipoDowntimeTrigger
{
    public int IdTipoDowntimeTrigger { get; set; }

    public string DescTipoDowntimeTrigger { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CStatusAr> CStatusArs { get; set; } = new List<CStatusAr>();
}

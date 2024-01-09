using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdApplicationVersion
{
    public int IdApplicationVersion { get; set; }

    public string Version { get; set; }

    public string BuildNumber { get; set; }

    public DateTime? DischargeDate { get; set; }

    public bool? Status { get; set; }
}

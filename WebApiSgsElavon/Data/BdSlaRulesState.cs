using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSlaRulesState
{
    public int SlaRulesStateId { get; set; }

    public string Cp { get; set; }

    public int? FailId { get; set; }

    public int? ServiceId { get; set; }

    public int? SupplierId { get; set; }

    public int? Days { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateDate { get; set; }
}

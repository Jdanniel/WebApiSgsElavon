using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCdpmitServiceLog
{
    public int CdpmitServiceLogId { get; set; }

    public string NewOdt { get; set; }

    public string OriginalOdt { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateDate { get; set; }
}

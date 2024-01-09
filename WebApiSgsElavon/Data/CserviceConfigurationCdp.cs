using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CserviceConfigurationCdp
{
    public int ServiceConfigurationCdpid { get; set; }

    public int? ServiceId { get; set; }

    public int? FaultId { get; set; }

    public int? ProductId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UserId { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdElavonDispatch
{
    public int IdElavonDispatches { get; set; }

    public int? IdElavonInbox { get; set; }

    public string RequestId { get; set; }

    public string DeviceType { get; set; }

    public string DeviceTypeCategory { get; set; }

    public string ConsumableType { get; set; }

    public string ConsumableAmt { get; set; }

    public string AccessoryType { get; set; }

    public string AccessoryAmt { get; set; }

    public string SoftwareName { get; set; }

    public string SoftwareVersion { get; set; }

    public string SoftwareVendor { get; set; }
}

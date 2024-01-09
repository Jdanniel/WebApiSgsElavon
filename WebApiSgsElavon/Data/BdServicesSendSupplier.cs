using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdServicesSendSupplier
{
    public Guid IdServicesSendSupplier { get; set; }

    public int? IdAr { get; set; }

    public int? SupplierId { get; set; }

    public int? IsSent { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ShipmentDate { get; set; }
}

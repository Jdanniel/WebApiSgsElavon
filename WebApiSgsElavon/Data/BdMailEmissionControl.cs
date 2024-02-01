using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdMailEmissionControl
{
    public int Id { get; set; }

    public int? ReceiverId { get; set; }

    public string Subject { get; set; }

    public long? TemplateId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ShipmentDate { get; set; }
}

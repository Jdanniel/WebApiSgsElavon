using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdClosedServicesSendSf
{
    public int Id { get; set; }

    public int? IdUpload { get; set; }

    public int? IdAr { get; set; }

    public int? IsSent { get; set; }

    public string Error { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? SentDate { get; set; }
}

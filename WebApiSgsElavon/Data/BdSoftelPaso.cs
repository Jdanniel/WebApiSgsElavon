using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdSoftelPaso
{
    public int IdSoftelPaso { get; set; }

    public string Body { get; set; }

    public string From { get; set; }

    public string Subject { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? NumberMsg { get; set; }
}

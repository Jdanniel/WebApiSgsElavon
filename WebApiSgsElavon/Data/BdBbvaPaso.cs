using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBbvaPaso
{
    public int IdBbvaPaso { get; set; }

    public string Body { get; set; }

    public string From { get; set; }

    public string Subject { get; set; }

    public string Status { get; set; }

    public DateTime FecAlta { get; set; }

    public int? NumberMsg { get; set; }
}

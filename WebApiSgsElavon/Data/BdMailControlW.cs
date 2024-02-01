using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdMailControlW
{
    public int IdMailControlWs { get; set; }

    public int? IdAr { get; set; }

    public string MailControlDesc { get; set; }

    public string DestinationEmail { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? IsSent { get; set; }

    public string Error { get; set; }
}

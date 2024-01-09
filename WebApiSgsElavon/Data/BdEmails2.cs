using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEmails2
{
    public int IdEmail { get; set; }

    public int IdCarga { get; set; }

    public string NoAr { get; set; }

    public string DescEmail { get; set; }

    public string EmailFrom { get; set; }

    public int? EmailToUser { get; set; }

    public string EmailTo { get; set; }

    public string EmailSubject { get; set; }

    public string EmailBodytype { get; set; }

    public string EmailBody { get; set; }

    public string Attachment { get; set; }

    public string DescError { get; set; }

    public string Status { get; set; }

    public string IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime? FecEnvio { get; set; }
}

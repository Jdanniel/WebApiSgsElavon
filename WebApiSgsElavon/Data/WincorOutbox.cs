using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class WincorOutbox
{
    public int IdOutbox { get; set; }

    public string Xml { get; set; }

    public string Incident { get; set; }

    public string Helpdesk { get; set; }

    public string Task { get; set; }

    public string Taskid { get; set; }

    public string StatusXml { get; set; }

    public string StatusEnvio { get; set; }

    public int? IdBitacoraAr { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaEnvio { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdMailjetMessage
{
    public int IdMailjetMessage { get; set; }

    public string Messageuuid { get; set; }

    public string Messageid { get; set; }

    public string Emailto { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdCarga { get; set; }

    public int? IsEnviado { get; set; }

    public DateTime? FecAlta { get; set; }
}

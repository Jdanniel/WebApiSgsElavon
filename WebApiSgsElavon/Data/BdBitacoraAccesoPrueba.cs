using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraAccesoPrueba
{
    public int IdBitacora { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? Acceso { get; set; }

    public DateTime? FecStatus { get; set; }

    public string Status { get; set; }

    public string IpCliente { get; set; }

    public string Host { get; set; }
}

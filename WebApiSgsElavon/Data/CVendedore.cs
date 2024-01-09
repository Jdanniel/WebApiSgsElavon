using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CVendedore
{
    public int IdVendedor { get; set; }

    public int? ArcherVendorId { get; set; }

    public string DescVendedor { get; set; }

    public string Rfc { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Ciudad { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }
}

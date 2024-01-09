using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdNegociosOtrosClientesPaso
{
    public int IdNegociosOtrosClientesPaso { get; set; }

    public int? IdCargasNegociosOtrosClientes { get; set; }

    public string Cliente { get; set; }

    public string DescNegocio { get; set; }

    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public string Status { get; set; }

    public string Observaciones { get; set; }

    public string Rfc { get; set; }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraNegocio
{
    public int IdBitacoraNegocios { get; set; }

    public int? IdCliente { get; set; }

    public int? IdSegmento { get; set; }

    public string DescNegocio { get; set; }

    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public string RfcFiscal { get; set; }

    public int? IdOtrosClientesAnterior { get; set; }

    public int? IdOtrosClientesActual { get; set; }

    public string StatusBitacora { get; set; }

    public int? IdUsuarioAltaBitacora { get; set; }

    public int? IsActualizacion { get; set; }
}

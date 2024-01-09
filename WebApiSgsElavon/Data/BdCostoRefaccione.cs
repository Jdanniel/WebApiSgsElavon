using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCostoRefaccione
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Secuencia { get; set; }

    public int? IdInstalacion { get; set; }

    public string FecAlta { get; set; }

    public string DescRegion { get; set; }

    public string DescZona { get; set; }

    public string Curp { get; set; }

    public string Nombre { get; set; }

    public int? IdAr { get; set; }

    public string DescCliente { get; set; }

    public string NoAfiliacion { get; set; }

    public string DescProducto { get; set; }

    public string FecAltaUnidad { get; set; }

    public string NoSerie { get; set; }

    public string Producto { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }

    public string Estado { get; set; }

    public string Propiedad { get; set; }

    public string Sku { get; set; }

    public decimal? CostoMs { get; set; }

    public string UCompraMs { get; set; }

    public decimal? CostoSgs { get; set; }

    public string MonedaSgs { get; set; }
}

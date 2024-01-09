using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class RefaccInstaladas3
{
    public DateTime? FecAlta { get; set; }

    public int IdCliente { get; set; }

    public int IdUnidad { get; set; }

    public int IdAr { get; set; }

    public int IdInstalacion { get; set; }

    public string DescRegion { get; set; }

    public string DescZona { get; set; }

    public string DescNegocio { get; set; }

    public string NoAfiliacion { get; set; }

    public string DescProducto { get; set; }

    public string NoSerie { get; set; }

    public string Producto { get; set; }

    public string DescCliente { get; set; }

    public int IdMarca { get; set; }

    public int IdModelo { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }

    public string OrdenCompra { get; set; }

    public decimal? Costo { get; set; }

    public int? IdMoneda { get; set; }

    public string Tecnico { get; set; }

    public int? IsNueva { get; set; }

    public int? IsPropiedadCliente { get; set; }

    public string Sku { get; set; }

    public string Curp { get; set; }

    public int IdUsuario { get; set; }

    public int? IdServicio { get; set; }

    public int? IdTipoServicio { get; set; }

    public int? IdTipoFallaEncontrada { get; set; }

    public string Conectividad { get; set; }

    public double? CostoMicrosip { get; set; }

    public DateOnly? UCompraMicrosip { get; set; }

    public DateTime? FecAltaUnidad { get; set; }

    public string Cp { get; set; }
}

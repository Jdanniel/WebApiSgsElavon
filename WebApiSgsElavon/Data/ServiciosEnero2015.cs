using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ServiciosEnero2015
{
    public string DescCliente { get; set; }

    public int IdAr { get; set; }

    public string NoAr { get; set; }

    public string NoAfiliacion { get; set; }

    public string Direccion { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string DescZona { get; set; }

    public string DescRegion { get; set; }

    public string DescLocalidad { get; set; }

    public string DescTipoServicio { get; set; }

    public string DescServicio { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime? FecCierre { get; set; }

    public int? Mes { get; set; }

    public int? IsExito { get; set; }

    public string DescCausaRechazo { get; set; }

    public string Curp { get; set; }

    public string Ingeniero { get; set; }

    public double? Fijo { get; set; }

    public double? Variable { get; set; }

    public string Producto { get; set; }

    public double? CostoRefacciones { get; set; }

    public string TipoVehiculo { get; set; }

    public double? RentaVehiculo { get; set; }

    public double? ManttoVehiculo { get; set; }
}

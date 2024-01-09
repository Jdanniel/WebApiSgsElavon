using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class UnidadesNoInstalada
{
    public int IdUnidad { get; set; }

    public string DescCliente { get; set; }

    public string Producto { get; set; }

    public string IsNueva { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }

    public string Sku { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public string DescTipoResponsable { get; set; }

    public string Responsable { get; set; }

    public string IsRetiro { get; set; }

    public string IsDaniada { get; set; }

    public decimal? Costo { get; set; }

    public string Moneda { get; set; }

    public string DescStatusUnidad { get; set; }

    public string IsPropiedadCliente { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }
}

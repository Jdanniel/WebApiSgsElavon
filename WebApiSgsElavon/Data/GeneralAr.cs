using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class GeneralAr
{
    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? IdRegion { get; set; }

    public string DescRegion { get; set; }

    public int? IdZona { get; set; }

    public string DescZona { get; set; }

    public DateTime? FecAlta { get; set; }

    public int IdAr { get; set; }

    public int IdCliente { get; set; }

    public string DescCliente { get; set; }

    public int? IdProducto { get; set; }

    public string DescProducto { get; set; }

    public int? IdTipoServicio { get; set; }

    public string DescTipoServicio { get; set; }

    public decimal TotalViaticos { get; set; }

    public int? SolicitudesNoCanceladas { get; set; }

    public int? Visitas { get; set; }

    public int? SinAccseso { get; set; }

    public int? SinCustodia { get; set; }

    public int? PendienteRefaccion { get; set; }

    public int? SoporteTecnico { get; set; }

    public string CodigoIntervencion { get; set; }

    public string Garantia { get; set; }
}

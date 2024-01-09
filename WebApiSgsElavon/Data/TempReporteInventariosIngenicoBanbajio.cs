using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempReporteInventariosIngenicoBanbajio
{
    public string Cliente { get; set; }

    public int IsNueva { get; set; }

    public int IdUnidad { get; set; }

    public string NoSim { get; set; }

    public string NoImei { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public string DescTipoResponsable { get; set; }

    public string Expr1 { get; set; }

    public string DescZona { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }

    public int? IdAplicativo { get; set; }

    public string Aplicativo { get; set; }

    public int? IdConectividad { get; set; }

    public string Conectividad { get; set; }

    public int? IsRetiro { get; set; }

    public string NoAfiliacion { get; set; }

    public int IsReparada { get; set; }

    public string DescStatusUnidad { get; set; }

    public int? IsDaniada { get; set; }

    public string FecStatus { get; set; }
}

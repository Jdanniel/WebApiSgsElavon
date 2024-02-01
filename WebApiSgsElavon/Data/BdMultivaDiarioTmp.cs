using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdMultivaDiarioTmp
{
    public int IdUnidad { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }

    public string DescConectividad { get; set; }

    public string DescSoftware { get; set; }

    public string ModeloConectividad { get; set; }

    public string NoSerie { get; set; }

    public string Ubicacion { get; set; }

    public string Situacion { get; set; }

    public string FechaEntrada { get; set; }

    public string FechaModificacion { get; set; }

    public string NoAfiliacion { get; set; }

    public string Comercio { get; set; }

    public int? IsDaniada { get; set; }

    public string Asignacion { get; set; }

    public string Observaciones { get; set; }

    public string Status { get; set; }

    public string Proveedor { get; set; }

    public string TipoResponsable { get; set; }

    public string Responsable { get; set; }

    public string Situacion2 { get; set; }
}

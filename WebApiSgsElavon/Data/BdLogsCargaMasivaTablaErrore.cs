using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdLogsCargaMasivaTablaErrore
{
    public int IdLogsCargaMasivaTablaErrores { get; set; }

    public string Odt { get; set; }

    public string DescServicio { get; set; }

    public string DescFalla { get; set; }

    public int? TipoServicio { get; set; }

    public int? TipoFalla { get; set; }

    public int? Segmento { get; set; }

    public string Cp { get; set; }

    public string NoAfiliacion { get; set; }

    public string Producto { get; set; }

    public string Status { get; set; }

    public string Observaciones { get; set; }

    public int? IdAr { get; set; }

    public int? IdCarga { get; set; }
}

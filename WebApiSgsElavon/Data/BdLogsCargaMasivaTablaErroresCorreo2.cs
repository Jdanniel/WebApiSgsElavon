using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdLogsCargaMasivaTablaErroresCorreo2
{
    public int IdLogsCargaMasivaTablaErroresCorreo2 { get; set; }

    public string NoAfiliacion { get; set; }

    public string DescNegocio { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string DescServicio { get; set; }

    public string DescFalla { get; set; }

    public string Errores { get; set; }

    public string Odt { get; set; }

    public int? IdCarga { get; set; }
}

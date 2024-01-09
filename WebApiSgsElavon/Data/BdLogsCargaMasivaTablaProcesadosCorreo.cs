using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdLogsCargaMasivaTablaProcesadosCorreo
{
    public int IdLogsCargaMasivaTablaProcesadosCorreo { get; set; }

    public string Odt { get; set; }

    public int? TipoServicio { get; set; }

    public int? TipoFalla { get; set; }

    public int? Segmento { get; set; }

    public string Cp { get; set; }

    public string NoAfiliacion { get; set; }

    public string Producto { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdSegmento { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? HorasGarantia { get; set; }

    public string PrecioExito { get; set; }

    public int? IdEstado { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdTecnico { get; set; }

    public int? IsArUnico { get; set; }

    public int? CountNoAr { get; set; }

    public int? IdAr { get; set; }

    public int? IdCarga { get; set; }
}

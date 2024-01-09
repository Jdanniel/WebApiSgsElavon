using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class AuditoriasRealizada
{
    public int? IdUsuario { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdTipoInventario { get; set; }

    public int? IdProducto { get; set; }

    public decimal? Efectividad { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdFisico { get; set; }

    public decimal Costo { get; set; }

    public int? IdModelo { get; set; }
}

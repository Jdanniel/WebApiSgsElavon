using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CAccesorio
{
    public int IdAccesorio { get; set; }

    public string DescAccesorio { get; set; }

    public string Descripcion { get; set; }

    public decimal? Costo { get; set; }

    public int? IdProducto { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdModeloAccesorio> BdModeloAccesorios { get; set; } = new List<BdModeloAccesorio>();

    public virtual ICollection<BdUnidadAccesorio> BdUnidadAccesorios { get; set; } = new List<BdUnidadAccesorio>();
}

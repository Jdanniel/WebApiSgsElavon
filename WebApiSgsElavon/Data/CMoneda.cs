using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CMoneda
{
    public int IdMoneda { get; set; }

    public string DescMoneda { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual ICollection<BdModeloPrecio> BdModeloPrecios { get; set; } = new List<BdModeloPrecio>();

    public virtual ICollection<BdSparePartPrecio> BdSparePartPrecios { get; set; } = new List<BdSparePartPrecio>();

    public virtual ICollection<CModelo> CModelos { get; set; } = new List<CModelo>();

    public virtual ICollection<CServicio> CServicios { get; set; } = new List<CServicio>();
}

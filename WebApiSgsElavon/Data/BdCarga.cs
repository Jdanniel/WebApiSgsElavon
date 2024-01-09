using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCarga
{
    public int IdCarga { get; set; }

    public int? IdCliente { get; set; }

    public DateTime Fecha { get; set; }

    public int? IdAttachArchivo1 { get; set; }

    public int IdStatusCarga { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdNegocio> BdNegocioIdCargaAltaNavigations { get; set; } = new List<BdNegocio>();

    public virtual ICollection<BdNegocio> BdNegocioIdCargaStatusNavigations { get; set; } = new List<BdNegocio>();
}

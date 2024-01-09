using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CServicioMensajerium
{
    public int IdServicioMensajeria { get; set; }

    public string DescServicioMensajeria { get; set; }

    public string Descripcion { get; set; }

    public int? IsInterno { get; set; }

    public string PaginaWeb { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsCamion { get; set; }

    public virtual ICollection<BdEnvio> BdEnvios { get; set; } = new List<BdEnvio>();
}

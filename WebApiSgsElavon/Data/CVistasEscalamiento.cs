using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CVistasEscalamiento
{
    public int IdVistaEscalamiento { get; set; }

    public string DescVistaEscalamiento { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdUsuarioVistaEscalamiento> BdUsuarioVistaEscalamientos { get; set; } = new List<BdUsuarioVistaEscalamiento>();

    public virtual ICollection<BdVistaEscalamientoStatusAr> BdVistaEscalamientoStatusArs { get; set; } = new List<BdVistaEscalamientoStatusAr>();
}

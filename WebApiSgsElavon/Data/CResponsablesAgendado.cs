using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CResponsablesAgendado
{
    public int IdResponsableAgendado { get; set; }

    public string DescResponsableAgendado { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdBitacoraAgendado> BdBitacoraAgendados { get; set; } = new List<BdBitacoraAgendado>();
}

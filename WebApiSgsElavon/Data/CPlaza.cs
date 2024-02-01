using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CPlaza
{
    public int IdPlaza { get; set; }

    public string DescPlaza { get; set; }

    public int? IdTipoPlaza { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual ICollection<BdPlazaCp> BdPlazaCps { get; set; } = new List<BdPlazaCp>();

    public virtual CTipoPlaza IdTipoPlazaNavigation { get; set; }
}

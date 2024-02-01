using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoUsuario
{
    public int IdTipoUsuario { get; set; }

    public string DescTipoUsuario { get; set; }

    public int? IsTecnico { get; set; }

    public int? IsSoporte { get; set; }

    public int IsViewAllServicios { get; set; }

    public string Status { get; set; }

    public int? IsTargetChangeSent { get; set; }

    public int? IsChangeUnitStock { get; set; }

    public int? IsSysAdmin { get; set; }

    public int? IsEditFiscal { get; set; }

    public int? IsTechniciansAssignedOnly { get; set; }

    public int? IsAutoAssignTechnicians { get; set; }

    public virtual ICollection<CUsuario> CUsuarios { get; set; } = new List<CUsuario>();
}

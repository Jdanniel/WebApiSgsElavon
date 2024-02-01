using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoSoporteTecnico
{
    public int IdTipoSoporteTecnico { get; set; }

    public string DescTipoSoporteTecnico { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdSoporteTecnico> BdSoporteTecnicos { get; set; } = new List<BdSoporteTecnico>();
}

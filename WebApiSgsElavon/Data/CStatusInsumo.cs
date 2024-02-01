using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusInsumo
{
    public int IdStatusInsumo { get; set; }

    public string DescStatusInsumo { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdBitacoraInsumo> BdBitacoraInsumoIdStatusInsumoFinNavigations { get; set; } = new List<BdBitacoraInsumo>();

    public virtual ICollection<BdBitacoraInsumo> BdBitacoraInsumoIdStatusInsumoIniNavigations { get; set; } = new List<BdBitacoraInsumo>();
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CStatusUnidad
{
    public int IdStatusUnidad { get; set; }

    public string DescStatusUnidad { get; set; }

    public string Status { get; set; }

    public int? IsLab { get; set; }

    public string AssignmentNo { get; set; }

    public string AssignmentNoDanada { get; set; }

    public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidadIdStatusUnidadFinNavigations { get; set; } = new List<BdBitacoraUnidad>();

    public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidadIdStatusUnidadIniNavigations { get; set; } = new List<BdBitacoraUnidad>();

    public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdStatusUnidadAnteriorNavigations { get; set; } = new List<BdReingresoUnidad>();

    public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdStatusUnidadReingresoNavigations { get; set; } = new List<BdReingresoUnidad>();
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusSolicitudDevolucion
{
    public int IdStatusSolicitudDevolucion { get; set; }

    public string DescStatusSolicitudDevolucion { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigations { get; set; } = new List<BdBitacoraSolicitudDevolucion>();

    public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigations { get; set; } = new List<BdBitacoraSolicitudDevolucion>();
}

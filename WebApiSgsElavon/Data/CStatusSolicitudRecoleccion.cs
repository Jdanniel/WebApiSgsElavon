using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CStatusSolicitudRecoleccion
{
    public int IdStatusSolicitudRecoleccion { get; set; }

    public string DescStatusSolicitudRecoleccion { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigations { get; set; } = new List<BdBitacoraSolicitudRecoleccion>();

    public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigations { get; set; } = new List<BdBitacoraSolicitudRecoleccion>();

    public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccions { get; set; } = new List<BdSolicitudRecoleccion>();
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusSolicitudViatico
{
    public int IdStatusSolicitudViaticos { get; set; }

    public string DescStatusSolicitudViaticos { get; set; }

    public int? IsModuleMisSolicitudes { get; set; }

    public int IsSearchModuleChecked { get; set; }

    public int? IsCerrarSolicitudViaticos { get; set; }

    public int? IsHabilitaAr { get; set; }

    public int? IsCancelarSolicitudViaticosAllowed { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdBitacoraSolicitudesViatico> BdBitacoraSolicitudesViaticoIdStatusSolicitudViaticosFinNavigations { get; set; } = new List<BdBitacoraSolicitudesViatico>();

    public virtual ICollection<BdBitacoraSolicitudesViatico> BdBitacoraSolicitudesViaticoIdStatusSolicitudViaticosIniNavigations { get; set; } = new List<BdBitacoraSolicitudesViatico>();

    public virtual ICollection<BdSolicitudesViatico> BdSolicitudesViaticos { get; set; } = new List<BdSolicitudesViatico>();
}

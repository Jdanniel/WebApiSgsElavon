using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CStatusSolicitudViaticos
    {
        public CStatusSolicitudViaticos()
        {
            BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosFinNavigation = new HashSet<BdBitacoraSolicitudesViaticos>();
            BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosIniNavigation = new HashSet<BdBitacoraSolicitudesViaticos>();
            BdSolicitudesViaticos = new HashSet<BdSolicitudesViaticos>();
        }

        public int IdStatusSolicitudViaticos { get; set; }
        public string DescStatusSolicitudViaticos { get; set; }
        public int? IsModuleMisSolicitudes { get; set; }
        public int IsSearchModuleChecked { get; set; }
        public int? IsCerrarSolicitudViaticos { get; set; }
        public int? IsHabilitaAr { get; set; }
        public int? IsCancelarSolicitudViaticosAllowed { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosFinNavigation { get; set; }
        public virtual ICollection<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosIniNavigation { get; set; }
        public virtual ICollection<BdSolicitudesViaticos> BdSolicitudesViaticos { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraSolicitudesViaticos
    {
        public int IdBitacoraSolicitudViaticos { get; set; }
        public int IdSolicitudViaticos { get; set; }
        public int? IdStatusSolicitudViaticosIni { get; set; }
        public int IdStatusSolicitudViaticosFin { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }

        public virtual BdSolicitudesViaticos IdSolicitudViaticosNavigation { get; set; }
        public virtual CStatusSolicitudViaticos IdStatusSolicitudViaticosFinNavigation { get; set; }
        public virtual CStatusSolicitudViaticos IdStatusSolicitudViaticosIniNavigation { get; set; }
    }
}

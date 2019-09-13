using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CStatusSolicitudDevolucion
    {
        public CStatusSolicitudDevolucion()
        {
            BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigation = new HashSet<BdBitacoraSolicitudDevolucion>();
            BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigation = new HashSet<BdBitacoraSolicitudDevolucion>();
        }

        public int IdStatusSolicitudDevolucion { get; set; }
        public string DescStatusSolicitudDevolucion { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigation { get; set; }
        public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CStatusSolicitudRecoleccion
    {
        public CStatusSolicitudRecoleccion()
        {
            BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigation = new HashSet<BdBitacoraSolicitudRecoleccion>();
            BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigation = new HashSet<BdBitacoraSolicitudRecoleccion>();
            BdSolicitudRecoleccion = new HashSet<BdSolicitudRecoleccion>();
        }

        public int IdStatusSolicitudRecoleccion { get; set; }
        public string DescStatusSolicitudRecoleccion { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigation { get; set; }
        public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigation { get; set; }
        public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
    }
}

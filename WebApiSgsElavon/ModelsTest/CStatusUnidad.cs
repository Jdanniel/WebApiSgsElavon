using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CStatusUnidad
    {
        public CStatusUnidad()
        {
            BdBitacoraUnidadIdStatusUnidadFinNavigation = new HashSet<BdBitacoraUnidad>();
            BdBitacoraUnidadIdStatusUnidadIniNavigation = new HashSet<BdBitacoraUnidad>();
            BdReingresoUnidadIdStatusUnidadAnteriorNavigation = new HashSet<BdReingresoUnidad>();
            BdReingresoUnidadIdStatusUnidadReingresoNavigation = new HashSet<BdReingresoUnidad>();
        }

        public int IdStatusUnidad { get; set; }
        public string DescStatusUnidad { get; set; }
        public string Status { get; set; }
        public int? IsLab { get; set; }
        public string AssignmentNo { get; set; }
        public string AssignmentNoDanada { get; set; }

        public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidadIdStatusUnidadFinNavigation { get; set; }
        public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidadIdStatusUnidadIniNavigation { get; set; }
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdStatusUnidadAnteriorNavigation { get; set; }
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdStatusUnidadReingresoNavigation { get; set; }
    }
}

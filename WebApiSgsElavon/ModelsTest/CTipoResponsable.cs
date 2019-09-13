using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoResponsable
    {
        public CTipoResponsable()
        {
            BdBitacoraInsumos = new HashSet<BdBitacoraInsumos>();
            BdBitacoraUnidad = new HashSet<BdBitacoraUnidad>();
            BdControlInsumosDetalle = new HashSet<BdControlInsumosDetalle>();
            BdEnviosIdTipoResponsableDestinoNavigation = new HashSet<BdEnvios>();
            BdEnviosIdTipoResponsableOrigenNavigation = new HashSet<BdEnvios>();
            BdReingresoUnidadIdTipoResponsableAnteriorNavigation = new HashSet<BdReingresoUnidad>();
            BdReingresoUnidadIdTipoResponsableReingresoNavigation = new HashSet<BdReingresoUnidad>();
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
            BdSolicitudesAlmacenOld = new HashSet<BdSolicitudesAlmacenOld>();
        }

        public int IdTipoResponsable { get; set; }
        public string DescTipoResponsable { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdBitacoraInsumos> BdBitacoraInsumos { get; set; }
        public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidad { get; set; }
        public virtual ICollection<BdControlInsumosDetalle> BdControlInsumosDetalle { get; set; }
        public virtual ICollection<BdEnvios> BdEnviosIdTipoResponsableDestinoNavigation { get; set; }
        public virtual ICollection<BdEnvios> BdEnviosIdTipoResponsableOrigenNavigation { get; set; }
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdTipoResponsableAnteriorNavigation { get; set; }
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdTipoResponsableReingresoNavigation { get; set; }
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
    }
}

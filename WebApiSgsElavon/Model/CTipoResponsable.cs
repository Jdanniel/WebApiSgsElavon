using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_RESPONSABLE")]
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

        [Column("ID_TIPO_RESPONSABLE")]
        public int IdTipoResponsable { get; set; }
        [Column("DESC_TIPO_RESPONSABLE")]
        [StringLength(50)]
        public string DescTipoResponsable { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoResponsableNavigation")]
        public virtual ICollection<BdBitacoraInsumos> BdBitacoraInsumos { get; set; }
        [InverseProperty("IdTipoResponsableNavigation")]
        public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidad { get; set; }
        [InverseProperty("IdTipoReponsableNavigation")]
        public virtual ICollection<BdControlInsumosDetalle> BdControlInsumosDetalle { get; set; }
        [InverseProperty("IdTipoResponsableDestinoNavigation")]
        public virtual ICollection<BdEnvios> BdEnviosIdTipoResponsableDestinoNavigation { get; set; }
        [InverseProperty("IdTipoResponsableOrigenNavigation")]
        public virtual ICollection<BdEnvios> BdEnviosIdTipoResponsableOrigenNavigation { get; set; }
        [InverseProperty("IdTipoResponsableAnteriorNavigation")]
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdTipoResponsableAnteriorNavigation { get; set; }
        [InverseProperty("IdTipoResponsableReingresoNavigation")]
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdTipoResponsableReingresoNavigation { get; set; }
        [InverseProperty("IdTipoResponsableDestinoNavigation")]
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        [InverseProperty("IdTipoResponsableDestinoNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
    }
}

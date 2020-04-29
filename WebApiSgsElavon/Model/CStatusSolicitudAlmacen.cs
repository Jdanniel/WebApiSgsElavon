using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_SOLICITUD_ALMACEN")]
    public partial class CStatusSolicitudAlmacen
    {
        public CStatusSolicitudAlmacen()
        {
            BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigation = new HashSet<BdBitacoraSolicitudesAlmacen>();
            BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigation = new HashSet<BdBitacoraSolicitudesAlmacen>();
        }

        [Key]
        [Column("ID_STATUS_SOLICITUD_ALMACEN")]
        public int IdStatusSolicitudAlmacen { get; set; }
        [Required]
        [Column("DESC_STATUS_SOLICITUD_ALMACEN")]
        [StringLength(50)]
        public string DescStatusSolicitudAlmacen { get; set; }
        [Column("IS_CONFIRMAR_ENTREGA")]
        public int? IsConfirmarEntrega { get; set; }
        [Column("IS_HABILITA_CONFIRMAR")]
        public int? IsHabilitaConfirmar { get; set; }
        [Column("IS_CANCELADO")]
        public int? IsCancelado { get; set; }
        [Column("IS_FLUJO_ALMACEN")]
        public int? IsFlujoAlmacen { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdStatusSolicitudAlmacenFinNavigation")]
        public virtual ICollection<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigation { get; set; }
        [InverseProperty("IdStatusSolicitudAlmacenIniNavigation")]
        public virtual ICollection<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigation { get; set; }
    }
}

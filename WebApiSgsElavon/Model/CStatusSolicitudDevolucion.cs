using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_SOLICITUD_DEVOLUCION")]
    public partial class CStatusSolicitudDevolucion
    {
        public CStatusSolicitudDevolucion()
        {
            BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigation = new HashSet<BdBitacoraSolicitudDevolucion>();
            BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigation = new HashSet<BdBitacoraSolicitudDevolucion>();
        }

        [Key]
        [Column("ID_STATUS_SOLICITUD_DEVOLUCION")]
        public int IdStatusSolicitudDevolucion { get; set; }
        [Column("DESC_STATUS_SOLICITUD_DEVOLUCION")]
        [StringLength(255)]
        public string DescStatusSolicitudDevolucion { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdStatusSolicitudDevolucionFinNavigation")]
        public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigation { get; set; }
        [InverseProperty("IdStatusSolicitudDevolucionIniNavigation")]
        public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigation { get; set; }
    }
}

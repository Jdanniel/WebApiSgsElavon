using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_SOLICITUD_RECOLECCION")]
    public partial class CStatusSolicitudRecoleccion
    {
        public CStatusSolicitudRecoleccion()
        {
            BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigation = new HashSet<BdBitacoraSolicitudRecoleccion>();
            BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigation = new HashSet<BdBitacoraSolicitudRecoleccion>();
            BdSolicitudRecoleccion = new HashSet<BdSolicitudRecoleccion>();
        }

        [Key]
        [Column("ID_STATUS_SOLICITUD_RECOLECCION")]
        public int IdStatusSolicitudRecoleccion { get; set; }
        [Column("DESC_STATUS_SOLICITUD_RECOLECCION")]
        [StringLength(50)]
        public string DescStatusSolicitudRecoleccion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdStatusSolicitudRecoleccionFinNavigation")]
        public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigation { get; set; }
        [InverseProperty("IdStatusSolicitudRecoleccionIniNavigation")]
        public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigation { get; set; }
        [InverseProperty("IdStatusSolicitudRecoleccionNavigation")]
        public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
    }
}

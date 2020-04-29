using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_UNIDAD")]
    public partial class CStatusUnidad
    {
        public CStatusUnidad()
        {
            BdBitacoraUnidadIdStatusUnidadFinNavigation = new HashSet<BdBitacoraUnidad>();
            BdBitacoraUnidadIdStatusUnidadIniNavigation = new HashSet<BdBitacoraUnidad>();
            BdReingresoUnidadIdStatusUnidadAnteriorNavigation = new HashSet<BdReingresoUnidad>();
            BdReingresoUnidadIdStatusUnidadReingresoNavigation = new HashSet<BdReingresoUnidad>();
        }

        [Key]
        [Column("ID_STATUS_UNIDAD")]
        public int IdStatusUnidad { get; set; }
        [Column("DESC_STATUS_UNIDAD")]
        [StringLength(50)]
        public string DescStatusUnidad { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("IS_LAB")]
        public int? IsLab { get; set; }
        [Column("assignment_no")]
        [StringLength(250)]
        public string AssignmentNo { get; set; }
        [Column("assignment_no_danada")]
        [StringLength(250)]
        public string AssignmentNoDanada { get; set; }

        [InverseProperty("IdStatusUnidadFinNavigation")]
        public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidadIdStatusUnidadFinNavigation { get; set; }
        [InverseProperty("IdStatusUnidadIniNavigation")]
        public virtual ICollection<BdBitacoraUnidad> BdBitacoraUnidadIdStatusUnidadIniNavigation { get; set; }
        [InverseProperty("IdStatusUnidadAnteriorNavigation")]
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdStatusUnidadAnteriorNavigation { get; set; }
        [InverseProperty("IdStatusUnidadReingresoNavigation")]
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdStatusUnidadReingresoNavigation { get; set; }
    }
}

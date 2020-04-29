using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONFIRMACIONES")]
    public partial class BdConfirmaciones
    {
        [Key]
        [Column("ID_CONFIRMACION")]
        public int IdConfirmacion { get; set; }
        [Column("ID_CARGA_CONFIRMACIONES")]
        public int? IdCargaConfirmaciones { get; set; }
        [Column("ID_SOLICITUD_VIATICOS")]
        public int? IdSolicitudViaticos { get; set; }
        [Column("NUM_CONFIRMACION")]
        [StringLength(50)]
        public string NumConfirmacion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [ForeignKey("IdCargaConfirmaciones")]
        [InverseProperty("BdConfirmaciones")]
        public virtual BdCargasConfirmaciones IdCargaConfirmacionesNavigation { get; set; }
        [ForeignKey("IdSolicitudViaticos")]
        [InverseProperty("BdConfirmaciones")]
        public virtual BdSolicitudesViaticos IdSolicitudViaticosNavigation { get; set; }
    }
}

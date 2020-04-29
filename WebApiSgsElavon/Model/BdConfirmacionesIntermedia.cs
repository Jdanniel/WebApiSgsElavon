using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONFIRMACIONES_INTERMEDIA")]
    public partial class BdConfirmacionesIntermedia
    {
        [Key]
        [Column("ID_CONFIRMACION_INTERMEDIA")]
        public int IdConfirmacionIntermedia { get; set; }
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
        [InverseProperty("BdConfirmacionesIntermedia")]
        public virtual BdCargasConfirmaciones IdCargaConfirmacionesNavigation { get; set; }
        [ForeignKey("IdSolicitudViaticos")]
        [InverseProperty("BdConfirmacionesIntermedia")]
        public virtual BdSolicitudesViaticos IdSolicitudViaticosNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REINGRESO_SIM")]
    public partial class BdReingresoSim
    {
        [Key]
        [Column("ID_REINGRESO_SIM")]
        public int IdReingresoSim { get; set; }
        [Column("ID_SIM")]
        public int IdSim { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION_ANTERIOR")]
        public int? IdSolicitudRecoleccionAnterior { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION_REINGRESO")]
        public int? IdSolicitudRecoleccionReingreso { get; set; }
        [Column("FEC_REINGRESO", TypeName = "smalldatetime")]
        public DateTime? FecReingreso { get; set; }
        [Column("ID_USUARIO_REINGRESO")]
        public int? IdUsuarioReingreso { get; set; }

        [ForeignKey("IdSolicitudRecoleccionAnterior")]
        [InverseProperty("BdReingresoSimIdSolicitudRecoleccionAnteriorNavigation")]
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionAnteriorNavigation { get; set; }
        [ForeignKey("IdSolicitudRecoleccionReingreso")]
        [InverseProperty("BdReingresoSimIdSolicitudRecoleccionReingresoNavigation")]
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionReingresoNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdReingresoSim")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

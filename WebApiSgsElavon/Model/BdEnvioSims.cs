using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ENVIO_SIMS")]
    public partial class BdEnvioSims
    {
        [Key]
        [Column("ID_ENVIO_SIM")]
        public int IdEnvioSim { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_SIM")]
        public int? IdSim { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_RECIBIDA")]
        public int? IsRecibida { get; set; }
        [Column("FEC_RECIBIDA", TypeName = "smalldatetime")]
        public DateTime? FecRecibida { get; set; }
        [Column("ID_USUARIO_RECEPCION")]
        public int? IdUsuarioRecepcion { get; set; }
        [Column("ID_STATUS_UNIDAD2")]
        public int? IdStatusUnidad2 { get; set; }

        [ForeignKey("IdSim")]
        [InverseProperty("BdEnvioSims")]
        public virtual BdMcSims IdSimNavigation { get; set; }
        [ForeignKey("IdUsuarioRecepcion")]
        [InverseProperty("BdEnvioSims")]
        public virtual CUsuarios IdUsuarioRecepcionNavigation { get; set; }
    }
}

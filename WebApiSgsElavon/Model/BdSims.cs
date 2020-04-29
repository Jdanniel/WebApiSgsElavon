using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SIMS")]
    public partial class BdSims
    {
        [Key]
        [Column("ID_SIM")]
        public int IdSim { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Required]
        [Column("NO_SIM")]
        [StringLength(50)]
        public string NoSim { get; set; }
        [Column("NO_IMEI")]
        [StringLength(50)]
        public string NoImei { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_CARRIER")]
        public int? IdCarrier { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_STATUS_SIM")]
        public int? IdStatusSim { get; set; }
        [Column("IS_DISPONIBLE")]
        public int? IsDisponible { get; set; }
    }
}

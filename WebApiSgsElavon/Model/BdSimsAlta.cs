using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SIMS_ALTA")]
    public partial class BdSimsAlta
    {
        [Key]
        [Column("ID_SIM_ALTA")]
        public int IdSimAlta { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int IdSolicitudRecoleccion { get; set; }
        [Column("NO_SIM")]
        [StringLength(100)]
        public string NoSim { get; set; }
        [Column("ID_CARRIER")]
        public int? IdCarrier { get; set; }
        [Column("IS_ASIGNADO")]
        public int? IsAsignado { get; set; }
        [Column("IS_NUMERIC")]
        public int? IsNumeric { get; set; }
        [Column("IS_NULL_SIM")]
        public int? IsNullSim { get; set; }
        [Column("IS_NULL_CARRIER")]
        public int? IsNullCarrier { get; set; }
        [Column("IS_PROCESADO")]
        public int? IsProcesado { get; set; }
        [Column("IS_REINGRESO")]
        public int? IsReingreso { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("VALIDACION")]
        public int? Validacion { get; set; }
        [Column("IS_OTRO_CLIENTE")]
        public int? IsOtroCliente { get; set; }
    }
}

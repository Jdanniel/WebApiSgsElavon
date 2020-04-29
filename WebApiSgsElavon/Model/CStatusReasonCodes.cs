using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_REASON_CODES")]
    public partial class CStatusReasonCodes
    {
        [Key]
        [Column("ID_STATUS_REASON_CODES")]
        public int IdStatusReasonCodes { get; set; }
        [Column("status_reason_code")]
        [StringLength(250)]
        public string StatusReasonCode { get; set; }
        [Column("status_reason")]
        [StringLength(250)]
        public string StatusReason { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("status_elavon")]
        [StringLength(250)]
        public string StatusElavon { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

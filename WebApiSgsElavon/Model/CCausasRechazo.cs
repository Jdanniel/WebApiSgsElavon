using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CAUSAS_RECHAZO")]
    public partial class CCausasRechazo
    {
        [Key]
        [Column("ID_CAUSA_RECHAZO")]
        public int IdCausaRechazo { get; set; }
        [Column("DESC_CAUSA_RECHAZO")]
        public string DescCausaRechazo { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("status_reason_code")]
        [StringLength(50)]
        public string StatusReasonCode { get; set; }
        [Column("ID_TRECHAZO")]
        public int IdTrechazo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_LOGROS")]
    public partial class CLogros
    {
        [Key]
        [Column("ID_TIPO_LOGRO")]
        public int IdTipoLogro { get; set; }
        [Column("DESC_LOGRO")]
        [StringLength(255)]
        public string DescLogro { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

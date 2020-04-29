using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CALIF_JUNTA")]
    public partial class CCalifJunta
    {
        [Key]
        [Column("ID_CALIF_JUNTA")]
        public int IdCalifJunta { get; set; }
        [Column("CALIF_JUNTA")]
        [StringLength(250)]
        public string CalifJunta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_STATUS_JUNTA")]
        public int? IdStatusJunta { get; set; }
    }
}

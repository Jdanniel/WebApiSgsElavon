using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_CURSO")]
    public partial class CStatusCurso
    {
        [Key]
        [Column("ID_STATUS_CURSO")]
        public int IdStatusCurso { get; set; }
        [Column("STATUS_CURSO")]
        [StringLength(250)]
        public string StatusCurso { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
    }
}

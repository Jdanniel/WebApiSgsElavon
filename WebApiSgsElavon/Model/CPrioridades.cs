using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PRIORIDADES")]
    public partial class CPrioridades
    {
        [Key]
        [Column("ID_PRIORIDADES")]
        public int IdPrioridades { get; set; }
        [Column("DESC_PRIORIDADES")]
        [StringLength(250)]
        public string DescPrioridades { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

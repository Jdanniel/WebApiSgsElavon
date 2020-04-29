using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TIPO_PLAN")]
    public partial class BdTipoPlan
    {
        [Key]
        [Column("ID_TIPO_PLAN")]
        public int IdTipoPlan { get; set; }
        [Column("DESC_TIPO_PLAN")]
        [StringLength(250)]
        public string DescTipoPlan { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

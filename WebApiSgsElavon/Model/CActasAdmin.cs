using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ACTAS_ADMIN")]
    public partial class CActasAdmin
    {
        [Key]
        [Column("ID_TIPO_ACTA_ADMIN")]
        public int IdTipoActaAdmin { get; set; }
        [Column("DESC_ACTA_ADMIN")]
        [StringLength(250)]
        public string DescActaAdmin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

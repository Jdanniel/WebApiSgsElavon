using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SEDE_CURSO")]
    public partial class CSedeCurso
    {
        [Key]
        [Column("ID_SEDE_CURSO")]
        public int IdSedeCurso { get; set; }
        [Column("SEDE_CURSO")]
        [StringLength(250)]
        public string SedeCurso { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
    }
}

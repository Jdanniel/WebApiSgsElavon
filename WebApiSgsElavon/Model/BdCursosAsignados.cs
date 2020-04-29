using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CURSOS_ASIGNADOS")]
    public partial class BdCursosAsignados
    {
        [Key]
        [Column("ID_CURSO_ASIGNADO")]
        public int IdCursoAsignado { get; set; }
        [Column("ID_CURSOS")]
        public int? IdCursos { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("CALIFICACION")]
        [StringLength(10)]
        public string Calificacion { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CURSOS")]
    public partial class BdCursos
    {
        [Key]
        [Column("ID_CURSOS")]
        public int IdCursos { get; set; }
        [Column("FEC_INICIO", TypeName = "smalldatetime")]
        public DateTime? FecInicio { get; set; }
        [Column("FEC_FIN", TypeName = "smalldatetime")]
        public DateTime? FecFin { get; set; }
        [Column("ID_CAPACITADOR")]
        public int? IdCapacitador { get; set; }
        [Column("ID_STATUS_CURSO")]
        public int? IdStatusCurso { get; set; }
        [Column("ID_SEDE_CURSO")]
        public int? IdSedeCurso { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("ID_NOMBRE_CURSO")]
        public int? IdNombreCurso { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}

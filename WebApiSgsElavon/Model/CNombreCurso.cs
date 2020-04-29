using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_NOMBRE_CURSO")]
    public partial class CNombreCurso
    {
        [Column("ID_NOMBRE_CURSO")]
        public int IdNombreCurso { get; set; }
        [Column("NOMBRE_CURSO")]
        [StringLength(250)]
        public string NombreCurso { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

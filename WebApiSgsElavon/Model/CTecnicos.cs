using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TECNICOS")]
    public partial class CTecnicos
    {
        [Key]
        [Column("ID_TECNICO")]
        public int IdTecnico { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("PATERNO")]
        [StringLength(50)]
        public string Paterno { get; set; }
        [Column("MATERNO")]
        [StringLength(50)]
        public string Materno { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
    }
}

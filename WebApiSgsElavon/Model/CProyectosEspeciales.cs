using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PROYECTOS_ESPECIALES")]
    public partial class CProyectosEspeciales
    {
        [Key]
        [Column("ID_PROYECTO_ESPECIAL")]
        public int IdProyectoEspecial { get; set; }
        [Column("DESC_PROYECTO_ESPECIAL")]
        [StringLength(50)]
        public string DescProyectoEspecial { get; set; }
        [Column("STATUS")]
        public int? Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("CALL_CENTER")]
        public int? CallCenter { get; set; }
        [Column("CARGA_MASIVA")]
        public int? CargaMasiva { get; set; }
        [Column("INTERFASE_ONBASE")]
        public int? InterfaseOnbase { get; set; }
        [Column("APLICA_CIERRES")]
        public int? AplicaCierres { get; set; }
        [Column("APLICA_BLOQUE_CIERRE")]
        [StringLength(100)]
        public string AplicaBloqueCierre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AFILIACIONES_PROYECTO_ESPECIAL")]
    public partial class BdAfiliacionesProyectoEspecial
    {
        [Key]
        [Column("ID_AFILIACION_PROY_ESP")]
        public int IdAfiliacionProyEsp { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("ID_PROYECTO_ESPECIAL")]
        public int? IdProyectoEspecial { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("IS_PROCESADO")]
        [StringLength(1)]
        public string IsProcesado { get; set; }
    }
}

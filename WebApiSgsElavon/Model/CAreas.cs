using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_AREAS")]
    public partial class CAreas
    {
        [Key]
        [Column("ID_AREA")]
        public int IdArea { get; set; }
        [Column("DESC_AREA")]
        [StringLength(75)]
        public string DescArea { get; set; }
        [Column("ID_JEFE_AREA")]
        public int? IdJefeArea { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}

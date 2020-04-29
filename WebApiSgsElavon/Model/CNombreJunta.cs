using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_NOMBRE_JUNTA")]
    public partial class CNombreJunta
    {
        [Key]
        [Column("ID_NOMBRE_JUNTA")]
        public int IdNombreJunta { get; set; }
        [Column("NOMBRE_JUNTA")]
        [StringLength(250)]
        public string NombreJunta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("NEED_AREA")]
        public int? NeedArea { get; set; }
    }
}

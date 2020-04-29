using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_ZONA")]
    public partial class BdUsuarioZona
    {
        [Key]
        [Column("ID_USUARIO_ZONA")]
        public int IdUsuarioZona { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}

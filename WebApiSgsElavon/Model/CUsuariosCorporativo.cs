using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_USUARIOS_CORPORATIVO")]
    public partial class CUsuariosCorporativo
    {
        [Key]
        [Column("ID_USUARIO_CORP")]
        public int IdUsuarioCorp { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_LOGRO_BLOG")]
    public partial class BdLogroBlog
    {
        [Key]
        [Column("ID_LOGRO_BLOG")]
        public int IdLogroBlog { get; set; }
        [Column("ID_LOGRO")]
        public int? IdLogro { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("COMENTARIO")]
        public string Comentario { get; set; }
    }
}

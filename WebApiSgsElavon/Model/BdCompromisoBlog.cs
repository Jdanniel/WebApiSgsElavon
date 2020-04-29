using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMPROMISO_BLOG")]
    public partial class BdCompromisoBlog
    {
        [Key]
        [Column("ID_COMPROMISOS_BLOG")]
        public int IdCompromisosBlog { get; set; }
        [Column("ID_COMPROMISO")]
        public int? IdCompromiso { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("COMENTARIO")]
        public string Comentario { get; set; }
    }
}

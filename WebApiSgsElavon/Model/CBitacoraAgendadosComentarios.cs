using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_BITACORA_AGENDADOS_COMENTARIOS")]
    public partial class CBitacoraAgendadosComentarios
    {
        [Key]
        [Column("ID_BITACORA_AGENDADOS_COMENTARIOS")]
        public int IdBitacoraAgendadosComentarios { get; set; }
        [Column("COMENTARIO")]
        [StringLength(450)]
        public string Comentario { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

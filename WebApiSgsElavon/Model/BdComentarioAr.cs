using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMENTARIO_AR")]
    public partial class BdComentarioAr
    {
        [Key]
        [Column("ID_COMENTARIO_AR")]
        public int IdComentarioAr { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("DESC_COMENTARIO_AR")]
        [StringLength(3000)]
        public string DescComentarioAr { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_TAREA")]
        public int? IdTarea { get; set; }
        [Column("NOTIFY_BANCOMER")]
        [StringLength(10)]
        public string NotifyBancomer { get; set; }
        [Column("ID_USUARIO_OKI")]
        public int? IdUsuarioOki { get; set; }
    }
}

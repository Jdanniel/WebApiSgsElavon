using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_SLA_INVENTARIOS")]
    public partial class BdArSlaInventarios
    {
        [Key]
        [Column("ID_SLA_INV")]
        public int IdSlaInv { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("FEC_INICIO_SLA", TypeName = "datetime")]
        public DateTime FecInicioSla { get; set; }
        [Column("FEC_FIN_SLA", TypeName = "datetime")]
        public DateTime FecFinSla { get; set; }
        [Column("FEC_REAL", TypeName = "datetime")]
        public DateTime? FecReal { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("ID_USUARIO_MOV_INV")]
        public int? IdUsuarioMovInv { get; set; }
    }
}

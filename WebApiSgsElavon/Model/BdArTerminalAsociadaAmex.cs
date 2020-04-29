using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_TERMINAL_ASOCIADA_AMEX")]
    public partial class BdArTerminalAsociadaAmex
    {
        [Column("ID_AR_TERMINAL_ASOCIADA_AMEX")]
        public int IdArTerminalAsociadaAmex { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_TERMINAL_AMEX")]
        [StringLength(50)]
        public string IdTerminalAmex { get; set; }
        [Column("AFILIACION_TERMINAL_AMEX")]
        [StringLength(50)]
        public string AfiliacionTerminalAmex { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}

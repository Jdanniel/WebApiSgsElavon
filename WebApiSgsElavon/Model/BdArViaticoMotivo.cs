using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_VIATICO_MOTIVO")]
    public partial class BdArViaticoMotivo
    {
        [Key]
        [Column("ID_AR_VIATICO_MOTIVO")]
        public int IdArViaticoMotivo { get; set; }
        [Column("NO_AR")]
        [StringLength(50)]
        public string NoAr { get; set; }
        [Column("ID_SOLICITUD_VIATICO")]
        public int IdSolicitudViatico { get; set; }
        [Column("ID_MOTIVO")]
        public int IdMotivo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

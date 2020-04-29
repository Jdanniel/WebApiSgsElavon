using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_VISTA_ESCALAMIENTO")]
    public partial class BdUsuarioVistaEscalamiento
    {
        [Key]
        [Column("ID_USUARIO_VISTA_ESCALAMIENTO")]
        public int IdUsuarioVistaEscalamiento { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_VISTA_ESCALAMIENTO")]
        public int? IdVistaEscalamiento { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdVistaEscalamiento")]
        [InverseProperty("BdUsuarioVistaEscalamiento")]
        public virtual CVistasEscalamiento IdVistaEscalamientoNavigation { get; set; }
    }
}

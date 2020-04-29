using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_LLAVE")]
    public partial class BdModeloLlave
    {
        [Key]
        [Column("ID_MODELO_LLAVE")]
        public int IdModeloLlave { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_LLAVE")]
        public int? IdLlave { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdLlave")]
        [InverseProperty("BdModeloLlave")]
        public virtual CLlaves IdLlaveNavigation { get; set; }
        [ForeignKey("IdModelo")]
        [InverseProperty("BdModeloLlave")]
        public virtual CModelos IdModeloNavigation { get; set; }
    }
}

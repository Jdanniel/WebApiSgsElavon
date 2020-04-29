using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_ACCESORIO")]
    public partial class BdModeloAccesorio
    {
        [Key]
        [Column("ID_MODELO_ACCESORIO")]
        public int IdModeloAccesorio { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_ACCESORIO")]
        public int? IdAccesorio { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdAccesorio")]
        [InverseProperty("BdModeloAccesorio")]
        public virtual CAccesorios IdAccesorioNavigation { get; set; }
        [ForeignKey("IdModelo")]
        [InverseProperty("BdModeloAccesorio")]
        public virtual CModelos IdModeloNavigation { get; set; }
    }
}

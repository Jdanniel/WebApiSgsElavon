using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_INSUMO")]
    public partial class BdModeloInsumo
    {
        [Key]
        [Column("ID_MODELO_INSUMO")]
        public int IdModeloInsumo { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdInsumo")]
        [InverseProperty("BdModeloInsumo")]
        public virtual CInsumosOld IdInsumoNavigation { get; set; }
        [ForeignKey("IdModelo")]
        [InverseProperty("BdModeloInsumo")]
        public virtual CModelos IdModeloNavigation { get; set; }
    }
}

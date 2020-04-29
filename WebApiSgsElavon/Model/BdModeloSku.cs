using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_SKU")]
    public partial class BdModeloSku
    {
        [Key]
        [Column("ID_MODELO_SKU")]
        public int IdModeloSku { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Column("PRECIO", TypeName = "decimal(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdModeloSku")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdModelo")]
        [InverseProperty("BdModeloSku")]
        public virtual CModelos IdModeloNavigation { get; set; }
    }
}

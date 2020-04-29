using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_INSUMOS_OLD")]
    public partial class CInsumosOld
    {
        public CInsumosOld()
        {
            BdModeloInsumo = new HashSet<BdModeloInsumo>();
        }

        [Column("ID_INSUMO")]
        public int IdInsumo { get; set; }
        [Column("DESC_INSUMO")]
        [StringLength(250)]
        public string DescInsumo { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_TIPO_INSUMO")]
        public int? IdTipoInsumo { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdTipoInsumo")]
        [InverseProperty("CInsumosOld")]
        public virtual CTipoInsumo IdTipoInsumoNavigation { get; set; }
        [InverseProperty("IdInsumoNavigation")]
        public virtual ICollection<BdModeloInsumo> BdModeloInsumo { get; set; }
    }
}

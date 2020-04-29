using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_INSUMO")]
    public partial class CTipoInsumo
    {
        public CTipoInsumo()
        {
            CInsumosOld = new HashSet<CInsumosOld>();
        }

        [Key]
        [Column("ID_TIPO_INSUMO")]
        public int IdTipoInsumo { get; set; }
        [Column("DESC_TIPO_INSUMO")]
        [StringLength(50)]
        public string DescTipoInsumo { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoInsumoNavigation")]
        public virtual ICollection<CInsumosOld> CInsumosOld { get; set; }
    }
}

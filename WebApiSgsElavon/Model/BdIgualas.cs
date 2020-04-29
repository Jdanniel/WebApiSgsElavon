using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_IGUALAS")]
    public partial class BdIgualas
    {
        [Key]
        [Column("ID_IGUALAS")]
        public int IdIgualas { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(250)]
        public string NoAfiliacion { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("IS_DOLAR")]
        public int? IsDolar { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("PRECIO_DOLAR", TypeName = "numeric(18, 2)")]
        public decimal? PrecioDolar { get; set; }
        [Column("TIPO_DE_CAMBIO", TypeName = "decimal(8, 4)")]
        public decimal? TipoDeCambio { get; set; }
    }
}

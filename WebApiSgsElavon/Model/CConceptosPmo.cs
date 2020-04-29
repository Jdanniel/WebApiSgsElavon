using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CONCEPTOS_PMO")]
    public partial class CConceptosPmo
    {
        [Key]
        [Column("ID_CONCEPTOS_PMO")]
        public int IdConceptosPmo { get; set; }
        [Column("DESC_CONCEPTO")]
        [StringLength(40)]
        public string DescConcepto { get; set; }
        [Column("ID_TIPO_CONCEPTO")]
        public int? IdTipoConcepto { get; set; }
        [Column("ID_APLICA")]
        public int? IdAplica { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CONCEPTO_AR")]
    public partial class CConceptoAr
    {
        [Key]
        [Column("ID_CONCEPTO")]
        public int IdConcepto { get; set; }
        [Column("DESCRIPCION_CONCEPTO_AR")]
        [StringLength(100)]
        public string DescripcionConceptoAr { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

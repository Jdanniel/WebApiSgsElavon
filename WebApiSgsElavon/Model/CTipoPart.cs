using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_PART")]
    public partial class CTipoPart
    {
        [Key]
        [Column("ID_TIPO_PART")]
        public int IdTipoPart { get; set; }
        [Column("DESC_TIPO_PART")]
        [StringLength(50)]
        public string DescTipoPart { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}

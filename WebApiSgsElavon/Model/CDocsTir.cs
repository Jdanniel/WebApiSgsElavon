using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_DOCS_TIR")]
    public partial class CDocsTir
    {
        [Key]
        [Column("ID_DOCS_TIR")]
        public int IdDocsTir { get; set; }
        [Column("DESC_DOC")]
        [StringLength(250)]
        public string DescDoc { get; set; }
        [Column("DOC_TIR")]
        [StringLength(50)]
        public string DocTir { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

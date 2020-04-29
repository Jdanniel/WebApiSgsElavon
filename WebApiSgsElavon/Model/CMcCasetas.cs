using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_CASETAS")]
    public partial class CMcCasetas
    {
        [Column("ID_CASETA")]
        public int IdCaseta { get; set; }
        [Column("DESC_CASETA")]
        [StringLength(50)]
        public string DescCaseta { get; set; }
        [Column("COSTO")]
        [StringLength(10)]
        public string Costo { get; set; }
        [Column("ESTATUS")]
        [StringLength(10)]
        public string Estatus { get; set; }
    }
}

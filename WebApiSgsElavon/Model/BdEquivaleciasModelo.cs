using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_EQUIVALECIAS_MODELO")]
    public partial class BdEquivaleciasModelo
    {
        [Column("ID_EQUIVALIENCIA")]
        public int IdEquivaliencia { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("DESC_NUEVO_MODELO")]
        [StringLength(100)]
        public string DescNuevoModelo { get; set; }
    }
}

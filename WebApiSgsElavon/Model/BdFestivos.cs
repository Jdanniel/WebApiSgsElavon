using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_FESTIVOS")]
    public partial class BdFestivos
    {
        [Key]
        [Column("ID_FESTIVOS")]
        public int IdFestivos { get; set; }
        [Column("DIA", TypeName = "date")]
        public DateTime? Dia { get; set; }
    }
}

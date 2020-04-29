using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_LOGROS_RESPONSABLES")]
    public partial class BdLogrosResponsables
    {
        [Key]
        [Column("ID_LOGROS_RESPONSABLES")]
        public int IdLogrosResponsables { get; set; }
        [Column("ID_LOGRO")]
        public int? IdLogro { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_AREA")]
        public int? IdArea { get; set; }
    }
}

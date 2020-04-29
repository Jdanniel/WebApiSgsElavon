using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TEMP_SERVICIO_CIERRE_PDA")]
    public partial class BdTempServicioCierrePda
    {
        [Key]
        [Column("ID_TEMP_SERVICIO_CIERRE_PDA")]
        public int IdTempServicioCierrePda { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("IS_CIERRE_PDA")]
        public int? IsCierrePda { get; set; }
    }
}

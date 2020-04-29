using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("TEMP_UPDATE_NO_INVENTARIO")]
    public partial class TempUpdateNoInventario
    {
        [Key]
        [Column("ID_TEMP_UPDATE_NO_INVENTARIO")]
        public int IdTempUpdateNoInventario { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Required]
        [Column("NO_INVENTARIO")]
        [StringLength(50)]
        public string NoInventario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("TEMP_AFILIACIONES")]
    public partial class TempAfiliaciones
    {
        [Key]
        [Column("ID_TEMP_AFILACION")]
        public int IdTempAfilacion { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_RESPONSABLE")]
        [StringLength(10)]
        public string IdResponsable { get; set; }
    }
}

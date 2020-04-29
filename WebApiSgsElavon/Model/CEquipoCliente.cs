using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_EQUIPO_CLIENTE")]
    public partial class CEquipoCliente
    {
        [Key]
        [Column("ID_EQUIPO_CLIENTE")]
        public int IdEquipoCliente { get; set; }
        [Column("DESCRIPCION_EQUIPO")]
        [StringLength(100)]
        public string DescripcionEquipo { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_NIVEL_REPARACION")]
    public partial class CNivelReparacion
    {
        [Key]
        [Column("ID_NIVEL_REPARACION")]
        public int IdNivelReparacion { get; set; }
        [Column("DESC_NIVEL_REPARACION")]
        [StringLength(250)]
        public string DescNivelReparacion { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

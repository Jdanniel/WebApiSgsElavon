using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMPROMISO_RESPONSABLE")]
    public partial class BdCompromisoResponsable
    {
        [Key]
        [Column("ID_COMPROMISO_RESPONSABLE")]
        public int IdCompromisoResponsable { get; set; }
        [Column("ID_COMPROMISO")]
        public int? IdCompromiso { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_AREA")]
        public int? IdArea { get; set; }
    }
}

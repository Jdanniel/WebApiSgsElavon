using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_FALLAS_ENCONTRADAS")]
    public partial class CFallasEncontradas
    {
        [Key]
        [Column("ID_FALLA")]
        public int IdFalla { get; set; }
        [Column("DESC_FALLA")]
        [StringLength(50)]
        public string DescFalla { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(15)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "date")]
        public DateTime? FecAlta { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_IGUALAS")]
    public partial class BdBitacoraIgualas
    {
        [Key]
        [Column("ID_BITACORA_IGUALAS")]
        public int IdBitacoraIgualas { get; set; }
        [Column("ID_IGUALAS")]
        public int? IdIgualas { get; set; }
        [Column("STATUS_INI")]
        [StringLength(250)]
        public string StatusIni { get; set; }
        [Column("STATUS_FIN")]
        [StringLength(250)]
        public string StatusFin { get; set; }
        [Column("COMENTARIO")]
        [StringLength(500)]
        public string Comentario { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

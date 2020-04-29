using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_AR")]
    public partial class BdBitacoraAr
    {
        [Key]
        [Column("ID_BITACORA_AR")]
        public int IdBitacoraAr { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_STATUS_AR_INI")]
        public int? IdStatusArIni { get; set; }
        [Column("ID_STATUS_AR_FIN")]
        public int? IdStatusArFin { get; set; }
        [Column("COMENTARIO")]
        [StringLength(100)]
        public string Comentario { get; set; }
        [Column("IS_PDA")]
        public int? IsPda { get; set; }
        [Column("IS_CAMBIO_VALIDO")]
        public int? IsCambioValido { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_COMPROMISOS")]
    public partial class BdBitacoraCompromisos
    {
        [Key]
        [Column("ID_BITACORA_COMPROMISOS")]
        public int IdBitacoraCompromisos { get; set; }
        [Column("ID_COMPROMISO")]
        public int? IdCompromiso { get; set; }
        [Column("ID_STATUS_JUNTA_INI")]
        public int? IdStatusJuntaIni { get; set; }
        [Column("ID_STATUS_JUNTA_FIN")]
        public int? IdStatusJuntaFin { get; set; }
        [Column("COMENTARIO")]
        [StringLength(250)]
        public string Comentario { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

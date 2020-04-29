using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_DOCTOS_PREFACTURACION")]
    public partial class BdBitacoraDoctosPrefacturacion
    {
        [Key]
        [Column("ID_BITACORA_DOCTOS_PREFACTURACION")]
        public int IdBitacoraDoctosPrefacturacion { get; set; }
        [Column("ID_AR_PREFACTURACION")]
        public int? IdArPrefacturacion { get; set; }
        [Column("ID_TIPO_DOCTO_PREFACTURACION")]
        public int? IdTipoDoctoPrefacturacion { get; set; }
        [Column("ID_TIPO_RESPONSABLE_PREFACTURACION")]
        [StringLength(10)]
        public string IdTipoResponsablePrefacturacion { get; set; }
        [Column("ID_RESPONSABLE_PREFACTURACION")]
        public int? IdResponsablePrefacturacion { get; set; }
        [Column("ID_STATUS_DOCTO_PREFACTURACION_INI")]
        public int? IdStatusDoctoPrefacturacionIni { get; set; }
        [Column("ID_STATUS_DOCTO_PREFACTURACION_FIN")]
        public int? IdStatusDoctoPrefacturacionFin { get; set; }
        [Column("COMENTARIO")]
        [StringLength(500)]
        public string Comentario { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

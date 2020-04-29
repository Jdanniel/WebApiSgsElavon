using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_ENVIO")]
    public partial class BdBitacoraEnvio
    {
        [Key]
        [Column("ID_BITACORA_ENVIO")]
        public int IdBitacoraEnvio { get; set; }
        [Column("ID_ENVIO")]
        public int IdEnvio { get; set; }
        [Column("ID_STATUS_ENVIO_INI")]
        public int? IdStatusEnvioIni { get; set; }
        [Column("ID_STATUS_ENVIO_FIN")]
        public int? IdStatusEnvioFin { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ORIGEN")]
        public int? IdTipoResponsableOrigen { get; set; }
        [Column("ID_RESPONSABLE_ORIGEN")]
        public int? IdResponsableOrigen { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("COMENTARIO")]
        [StringLength(50)]
        public string Comentario { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}

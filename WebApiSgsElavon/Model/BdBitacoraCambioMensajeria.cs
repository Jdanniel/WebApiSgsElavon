using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_CAMBIO_MENSAJERIA")]
    public partial class BdBitacoraCambioMensajeria
    {
        [Column("ID_BITACORA_CAMBIO_MENSAJERIA")]
        public int IdBitacoraCambioMensajeria { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("ID_MENSAJERIA_INI")]
        public int? IdMensajeriaIni { get; set; }
        [Column("ID_MENSAJERIA_FIN")]
        public int? IdMensajeriaFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

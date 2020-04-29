using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_SERVICIOS_FALLA")]
    public partial class BdBitacoraServiciosFalla
    {
        [Column("ID_BITACORA_SERVICIOS_FALLA")]
        public int IdBitacoraServiciosFalla { get; set; }
        [Column("ID_SERVICIO_FALLA")]
        public int? IdServicioFalla { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ACCION")]
        public string Accion { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}

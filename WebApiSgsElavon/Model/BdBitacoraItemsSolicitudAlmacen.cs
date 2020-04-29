using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_ITEMS_SOLICITUD_ALMACEN")]
    public partial class BdBitacoraItemsSolicitudAlmacen
    {
        [Column("ID_BITACORA_ITEMS_SOLICITUD_ALMACEN")]
        public int IdBitacoraItemsSolicitudAlmacen { get; set; }
        [Column("ID_ITEMS_SOLICITUD_ALMACEN")]
        public int? IdItemsSolicitudAlmacen { get; set; }
        [Column("ID_STATUS_ITEMS_SOLICITUD_ALMACEN_INI")]
        public int? IdStatusItemsSolicitudAlmacenIni { get; set; }
        [Column("ID_STATUS_ITEMS_SOLICITUD_ALMACEN_FIN")]
        public int? IdStatusItemsSolicitudAlmacenFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("COMENTARIO")]
        [StringLength(250)]
        public string Comentario { get; set; }
    }
}

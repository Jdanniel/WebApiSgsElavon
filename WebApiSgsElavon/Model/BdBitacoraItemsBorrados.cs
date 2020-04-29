using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_ITEMS_BORRADOS")]
    public partial class BdBitacoraItemsBorrados
    {
        [Column("ID_BITACORA_ITEMS_BORRADOS")]
        public int IdBitacoraItemsBorrados { get; set; }
        [Column("ID_SOLICITUD_ALMACEN")]
        public int? IdSolicitudAlmacen { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("ID_STATUS_ITEMS_SOLICITUD_ALMACEN")]
        public int? IdStatusItemsSolicitudAlmacen { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}

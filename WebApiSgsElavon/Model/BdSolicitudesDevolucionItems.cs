using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_DEVOLUCION_ITEMS")]
    public partial class BdSolicitudesDevolucionItems
    {
        [Column("ID_SOLICITUD_DEVOLUCION_ITEM")]
        public int IdSolicitudDevolucionItem { get; set; }
        [Column("ID_SOLICITUD_DEVOLUCION")]
        public int IdSolicitudDevolucion { get; set; }
        [Column("ID_TIPO_ITEM_SOLICITUD_ALMACEN")]
        public int IdTipoItemSolicitudAlmacen { get; set; }
        [Column("CANTIDAD")]
        [StringLength(250)]
        public string Cantidad { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_RECIBIDO_RETORNO")]
        public int? IsRecibidoRetorno { get; set; }
        [Column("ID_STATUS_INSUMO_INI")]
        public int? IdStatusInsumoIni { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_ACCESORIO")]
        public int? IdAccesorio { get; set; }
        [Column("ID_SPARE_PART")]
        public int? IdSparePart { get; set; }
        [Column("ID_REFACCION")]
        public int? IdRefaccion { get; set; }
    }
}

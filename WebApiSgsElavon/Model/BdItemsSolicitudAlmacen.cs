using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ITEMS_SOLICITUD_ALMACEN")]
    public partial class BdItemsSolicitudAlmacen
    {
        [Key]
        [Column("ID_ITEMS_SOLICITUD_ALMACEN")]
        public int IdItemsSolicitudAlmacen { get; set; }
        [Column("ID_SOLICITUD_ALMACEN")]
        public int IdSolicitudAlmacen { get; set; }
        [Column("ID_TIPO_ITEM_SOLICITUD_ALMACEN")]
        public int IdTipoItemSolicitudAlmacen { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_MARCA")]
        public int? IdMarca { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_SPARE_PART")]
        public int? IdSparePart { get; set; }
        [Column("CANTIDAD_ITEMS")]
        public int CantidadItems { get; set; }
        [Column("NOTAS")]
        [StringLength(512)]
        public string Notas { get; set; }
        [Column("ID_STATUS_ITEMS_SOLICITUD_ALMACEN")]
        public int? IdStatusItemsSolicitudAlmacen { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("IS_SURTIDO")]
        public int? IsSurtido { get; set; }
        [Column("IS_EMBARQUE")]
        public int? IsEmbarque { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_SOFTWARE")]
        public int? IdSoftware { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("ID_KIT_INSUMO")]
        public int? IdKitInsumo { get; set; }
        [Column("ID_PARENT_INSUMO")]
        public int? IdParentInsumo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_ITEM_SOLICITUD_ALMACEN")]
    public partial class CTipoItemSolicitudAlmacen
    {
        [Key]
        [Column("ID_TIPO_ITEM_SOLICITUD_ALMACEN")]
        public int IdTipoItemSolicitudAlmacen { get; set; }
        [Column("DESC_TIPO_ITEM_SOLICITUD_ALMACEN")]
        [StringLength(50)]
        public string DescTipoItemSolicitudAlmacen { get; set; }
        [Column("ID_TIPO_PRODUCTO")]
        public int? IdTipoProducto { get; set; }
        [Column("ID_STATUS_AR_NEW")]
        public int? IdStatusArNew { get; set; }
        [Column("IS_INDIVIDUALLY_CONTROLLED")]
        public int? IsIndividuallyControlled { get; set; }
        [Column("IS_UNIDAD_GRUPO_CLIENTES")]
        public int? IsUnidadGrupoClientes { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_INSUMOS")]
    public partial class BdInsumos
    {
        [Column("ID_BD_INSUMO")]
        public int IdBdInsumo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int? IdSolicitudRecoleccion { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_STATUS_INSUMO")]
        public int? IdStatusInsumo { get; set; }
        [Column("ID_ITEMS_SOLICITUD_ALMACEN")]
        public int? IdItemsSolicitudAlmacen { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("NO_TARIMA")]
        [StringLength(100)]
        public string NoTarima { get; set; }
        [Column("POSICION_INVENTARIO")]
        [StringLength(100)]
        public string PosicionInventario { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }
    }
}

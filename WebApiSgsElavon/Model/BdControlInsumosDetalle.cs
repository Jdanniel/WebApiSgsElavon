using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONTROL_INSUMOS_DETALLE")]
    public partial class BdControlInsumosDetalle
    {
        [Key]
        [Column("ID_CONTROL_INSUMOS_DETALLE")]
        public int IdControlInsumosDetalle { get; set; }
        [Column("ID_SOLICITUD_ALMACEN")]
        public int IdSolicitudAlmacen { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_INSUMO")]
        public int IdInsumo { get; set; }
        [Column("CANTIDAD")]
        public int Cantidad { get; set; }
        [Column("ID_TIPO_REPONSABLE")]
        public int IdTipoReponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int IdResponsable { get; set; }
        [Column("ID_ALMACEN")]
        public int IdAlmacen { get; set; }
        [Column("STATUS")]
        public int Status { get; set; }

        [ForeignKey("IdTipoReponsable")]
        [InverseProperty("BdControlInsumosDetalle")]
        public virtual CTipoResponsable IdTipoReponsableNavigation { get; set; }
    }
}

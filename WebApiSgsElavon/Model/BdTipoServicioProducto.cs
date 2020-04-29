using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TIPO_SERVICIO_PRODUCTO")]
    public partial class BdTipoServicioProducto
    {
        [Key]
        [Column("ID_TIPO_SERVICIO_PRODUCTO")]
        public int IdTipoServicioProducto { get; set; }
        [Column("ID_TIPO_SERVICIO")]
        public int IdTipoServicio { get; set; }
        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }
        [Column("ID_TIPO_COBRO")]
        public int? IdTipoCobro { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdTipoCobro")]
        [InverseProperty("BdTipoServicioProducto")]
        public virtual CTipoCobro IdTipoCobroNavigation { get; set; }
        [ForeignKey("IdTipoServicio")]
        [InverseProperty("BdTipoServicioProducto")]
        public virtual CTipoServicio IdTipoServicioNavigation { get; set; }
    }
}

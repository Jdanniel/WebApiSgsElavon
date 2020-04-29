using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_PROPIEDAD_CLIENTE")]
    public partial class BdBitacoraPropiedadCliente
    {
        [Column("ID_BITACORA_PROPIEDAD_CLIENTE")]
        public int IdBitacoraPropiedadCliente { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("IS_PROPIEDAD_CLIENTE_ACTUAL")]
        public int? IsPropiedadClienteActual { get; set; }
        [Column("IS_PROPIEDAD_CLIENTE_NUEVO")]
        public int? IsPropiedadClienteNuevo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }

        [ForeignKey("IdUnidad")]
        [InverseProperty("BdBitacoraPropiedadCliente")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

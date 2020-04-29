using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CLIENTE_MODELO_CAMBIO_STATUS_UNIDAD")]
    public partial class BdClienteModeloCambioStatusUnidad
    {
        [Key]
        [Column("ID_CLIENTE_MODELO_CAMBIO_STATUS_UNIDAD")]
        public int IdClienteModeloCambioStatusUnidad { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("ID_STATUS_UNIDAD_FROM")]
        public int? IdStatusUnidadFrom { get; set; }
        [Column("ID_STATUS_UNIDAD_TO")]
        public int? IdStatusUnidadTo { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

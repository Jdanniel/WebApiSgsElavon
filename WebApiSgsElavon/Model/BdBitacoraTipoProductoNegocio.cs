using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_TIPO_PRODUCTO_NEGOCIO")]
    public partial class BdBitacoraTipoProductoNegocio
    {
        [Column("ID_BITACORA_TIPO_PRODUCTO_NEGOCIO")]
        public int IdBitacoraTipoProductoNegocio { get; set; }
        [Column("ID_PRODUCTO_NEGOCIO")]
        public int? IdProductoNegocio { get; set; }
        [Column("DESC_PRODUCTO_NEGOCIO_ANTERIOR")]
        public string DescProductoNegocioAnterior { get; set; }
        [Column("DESC_PRODUCTO_NEGOCIO_ACTUAL")]
        public string DescProductoNegocioActual { get; set; }
        [Column("STATUS_ANTERIOR")]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        public string StatusActual { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("USUARIO_ALTA")]
        public int? UsuarioAlta { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_TIPO_CAUSA_CANCELACION")]
    public partial class BdBitacoraTipoCausaCancelacion
    {
        [Column("ID_BITACORA_TIPO_CAUSA_CANCELACION")]
        public int IdBitacoraTipoCausaCancelacion { get; set; }
        [Column("ID_CAUSA_CANCELACION")]
        public int? IdCausaCancelacion { get; set; }
        [Column("DESC_CAUSA_CANCELACION_ANTERIOR")]
        public string DescCausaCancelacionAnterior { get; set; }
        [Column("DESC_CAUSA_CANCELACION_ACTUAL")]
        public string DescCausaCancelacionActual { get; set; }
        [Column("STATUS_ANTERIOR")]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        public string StatusActual { get; set; }
        [Column("ID_TIPO_CANCELADO_ANTERIOR")]
        public string IdTipoCanceladoAnterior { get; set; }
        [Column("ID_TIPO_CANCELADO_ACTUAL")]
        public string IdTipoCanceladoActual { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("USUARIOS_ALTA")]
        public int? UsuariosAlta { get; set; }
    }
}

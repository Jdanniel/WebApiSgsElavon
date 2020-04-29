using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_TIPO_CUSAS_RECHAZO")]
    public partial class BdBitacoraTipoCusasRechazo
    {
        [Column("ID_BITACORA_TIPO_CUSAS_RECHAZO")]
        public int IdBitacoraTipoCusasRechazo { get; set; }
        [Column("ID_CAUSA_RECHAZO")]
        public int? IdCausaRechazo { get; set; }
        [Column("DESC_CAUSA_RECHAZO_ANTERIOR")]
        public string DescCausaRechazoAnterior { get; set; }
        [Column("DESC_CAUSA_RECHAZO_ACTUAL")]
        public string DescCausaRechazoActual { get; set; }
        [Column("STATUS_ANTERIOR")]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        public string StatusActual { get; set; }
        [Column("ID_TRECHAZO_ANTERIOR")]
        public string IdTrechazoAnterior { get; set; }
        [Column("ID_TRECHAZO_ACTUAL")]
        public string IdTrechazoActual { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("USUARIOS_ALTA")]
        public int? UsuariosAlta { get; set; }
    }
}

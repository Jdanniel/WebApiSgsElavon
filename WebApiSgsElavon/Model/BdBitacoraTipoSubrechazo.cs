using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_TIPO_SUBRECHAZO")]
    public partial class BdBitacoraTipoSubrechazo
    {
        [Column("ID_BITACORA_TIPO_SUBRECHAZO")]
        public int IdBitacoraTipoSubrechazo { get; set; }
        [Column("ID_SUBRECHAZO")]
        public int? IdSubrechazo { get; set; }
        [Column("SUBRECHAZO_ANTERIOR")]
        public string SubrechazoAnterior { get; set; }
        [Column("SUBRECHAZO_ACTUAL")]
        public string SubrechazoActual { get; set; }
        [Column("STATUS_ANTERIOR")]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        public string StatusActual { get; set; }
        [Column("ID_ANTERIOR")]
        public string IdAnterior { get; set; }
        [Column("ID_ACTUAL")]
        public string IdActual { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("USUARIOS_ALTA")]
        public int? UsuariosAlta { get; set; }
    }
}

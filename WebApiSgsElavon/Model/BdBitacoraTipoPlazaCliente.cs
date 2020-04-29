using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_TIPO_PLAZA_CLIENTE")]
    public partial class BdBitacoraTipoPlazaCliente
    {
        [Column("ID_BITACORA_TIPO_PLAZA_CLIENTE")]
        public int IdBitacoraTipoPlazaCliente { get; set; }
        [Column("ID_TIPO_PLAZA")]
        public int? IdTipoPlaza { get; set; }
        [Column("CP")]
        [StringLength(10)]
        public string Cp { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}

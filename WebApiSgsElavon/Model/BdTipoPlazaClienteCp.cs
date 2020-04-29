using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TIPO_PLAZA_CLIENTE_CP")]
    public partial class BdTipoPlazaClienteCp
    {
        [Key]
        [Column("ID_TIPO_PLAZA_CLIENTE_CP")]
        public int IdTipoPlazaClienteCp { get; set; }
        [Column("ID_TIPO_PLAZA_CLIENTE")]
        public int? IdTipoPlazaCliente { get; set; }
        [Column("CP")]
        [StringLength(10)]
        public string Cp { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

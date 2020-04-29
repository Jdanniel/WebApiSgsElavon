using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_A_B")]
    public partial class CTipoAB
    {
        [Column("ID_TIPO_A_B")]
        public int IdTipoAB { get; set; }
        [Column("DESC_TIPO_A_B")]
        public string DescTipoAB { get; set; }
        [Column("STATUS")]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}

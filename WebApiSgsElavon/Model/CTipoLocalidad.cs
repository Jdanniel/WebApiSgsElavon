using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_LOCALIDAD")]
    public partial class CTipoLocalidad
    {
        [Column("ID_TIPO_LOCALIDAD")]
        public int IdTipoLocalidad { get; set; }
        [Column("DESC_LOCALIDAD")]
        [StringLength(500)]
        public string DescLocalidad { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

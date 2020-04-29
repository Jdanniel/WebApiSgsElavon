using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ACTAS_ADMIN")]
    public partial class BdActasAdmin
    {
        [Column("ID_ACTA_ADMIN")]
        public int IdActaAdmin { get; set; }
        [Column("ID_TIPO_ACTA_ADMIN")]
        public int? IdTipoActaAdmin { get; set; }
        [Column("ID_AREA")]
        public int? IdArea { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_USUARIO_ACTA")]
        public int? IdUsuarioActa { get; set; }
        [Column("COMENTARIOS")]
        [StringLength(250)]
        public string Comentarios { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS_ACTA_ADMIN")]
        [StringLength(50)]
        public string StatusActaAdmin { get; set; }
    }
}

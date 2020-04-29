using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_FALLAS")]
    public partial class CFallas
    {
        [Column("ID_FALLA")]
        public int IdFalla { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("DESC_FALLA")]
        [StringLength(250)]
        public string DescFalla { get; set; }
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("IS_DOWNTIME")]
        public int? IsDowntime { get; set; }
        [Column("ID_TIPO_FALLA")]
        public int? IdTipoFalla { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

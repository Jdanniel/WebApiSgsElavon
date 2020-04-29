using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_LOGROS")]
    public partial class BdLogros
    {
        [Key]
        [Column("ID_LOGRO")]
        public int IdLogro { get; set; }
        [Column("FEC_REAL_CIERRE", TypeName = "smalldatetime")]
        public DateTime? FecRealCierre { get; set; }
        [Column("ID_GERENTE")]
        public int? IdGerente { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_AREA")]
        public int? IdArea { get; set; }
        [Column("ID_TIPO_LOGRO")]
        public int? IdTipoLogro { get; set; }
        [Column("DESC_LOGRO")]
        [StringLength(255)]
        public string DescLogro { get; set; }
        [Column("CUANTIFICACION")]
        [StringLength(255)]
        public string Cuantificacion { get; set; }
        [Column("FEC_AUDITABLE", TypeName = "smalldatetime")]
        public DateTime? FecAuditable { get; set; }
        [Column("COMENTARIO")]
        [StringLength(255)]
        public string Comentario { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
    }
}

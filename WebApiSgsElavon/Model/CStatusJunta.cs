using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_JUNTA")]
    public partial class CStatusJunta
    {
        [Key]
        [Column("ID_STATUS_JUNTA")]
        public int IdStatusJunta { get; set; }
        [Column("STATUS_JUNTA")]
        [StringLength(250)]
        public string StatusJunta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("COLOR_RGB")]
        [StringLength(12)]
        public string ColorRgb { get; set; }
        [Column("IS_AUTO")]
        public int? IsAuto { get; set; }
    }
}

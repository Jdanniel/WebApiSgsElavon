using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_CELULAR")]
    public partial class BdUsuarioCelular
    {
        [Key]
        [Column("ID_USUARIO_CELULAR")]
        public int IdUsuarioCelular { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("CELULAR")]
        [StringLength(50)]
        public string Celular { get; set; }
        [Column("ID_TIPO_PLAN")]
        public int? IdTipoPlan { get; set; }
        [Column("ID_MODELO_CELULAR")]
        public int? IdModeloCelular { get; set; }
        [Column("FEC_INI_PLAN", TypeName = "smalldatetime")]
        public DateTime? FecIniPlan { get; set; }
        [Column("FEC_FIN_PLAN", TypeName = "smalldatetime")]
        public DateTime? FecFinPlan { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("IMEI")]
        [StringLength(20)]
        public string Imei { get; set; }
    }
}

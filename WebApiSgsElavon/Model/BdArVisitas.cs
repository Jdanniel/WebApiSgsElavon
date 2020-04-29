using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_VISITAS")]
    public partial class BdArVisitas
    {
        [Key]
        [Column("ID_AR_VISITA")]
        public int IdArVisita { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("ID_TIPO_PRECIO")]
        public int? IdTipoPrecio { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("ID_TIPO_COBRO")]
        public int? IdTipoCobro { get; set; }
        [Column("IS_COBRABLE")]
        public int? IsCobrable { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("FEC_VISITA", TypeName = "smalldatetime")]
        public DateTime? FecVisita { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [ForeignKey("IdTipoCobro")]
        [InverseProperty("BdArVisitas")]
        public virtual CTipoCobro IdTipoCobroNavigation { get; set; }
    }
}

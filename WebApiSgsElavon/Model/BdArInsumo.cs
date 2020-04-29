using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_INSUMO")]
    public partial class BdArInsumo
    {
        [Key]
        [Column("ID_AR_INSUMO")]
        public int IdArInsumo { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_INSUMO")]
        public int IdInsumo { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("COSTO_UNITARIO", TypeName = "numeric(18, 2)")]
        public decimal? CostoUnitario { get; set; }
        [Column("COSTO_TOTAL", TypeName = "numeric(18, 2)")]
        public decimal? CostoTotal { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_MICROSIP")]
        public int? IsMicrosip { get; set; }
        [Column("CONTROL_MICROSIP")]
        public int? ControlMicrosip { get; set; }
    }
}

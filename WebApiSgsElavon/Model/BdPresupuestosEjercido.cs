using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PRESUPUESTOS_EJERCIDO")]
    public partial class BdPresupuestosEjercido
    {
        [Key]
        [Column("ID_PRESUPUESTO_EJERCIDO")]
        public int IdPresupuestoEjercido { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("ID_CONCEPTO")]
        public int? IdConcepto { get; set; }
        [Column("MES")]
        [StringLength(15)]
        public string Mes { get; set; }
        [Column("SEMANA")]
        public int? Semana { get; set; }
        [Column("IMPORTE", TypeName = "decimal(20, 2)")]
        public decimal? Importe { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}

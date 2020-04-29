using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PRESUPUESTOS")]
    public partial class BdPresupuestos
    {
        [Key]
        [Column("ID_PRESUPUESTO")]
        public int IdPresupuesto { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_CONCEPTO")]
        public int? IdConcepto { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("ENERO", TypeName = "decimal(20, 2)")]
        public decimal? Enero { get; set; }
        [Column("FEBRERO", TypeName = "decimal(20, 0)")]
        public decimal? Febrero { get; set; }
        [Column("MARZO", TypeName = "decimal(20, 0)")]
        public decimal? Marzo { get; set; }
        [Column("ABRIL", TypeName = "decimal(20, 0)")]
        public decimal? Abril { get; set; }
        [Column("MAYO", TypeName = "decimal(20, 0)")]
        public decimal? Mayo { get; set; }
        [Column("JUNIO", TypeName = "decimal(20, 0)")]
        public decimal? Junio { get; set; }
        [Column("JULIO", TypeName = "decimal(20, 0)")]
        public decimal? Julio { get; set; }
        [Column("AGOSTO", TypeName = "decimal(20, 0)")]
        public decimal? Agosto { get; set; }
        [Column("SEPTIEMBRE", TypeName = "decimal(20, 0)")]
        public decimal? Septiembre { get; set; }
        [Column("OCTUBRE", TypeName = "decimal(20, 0)")]
        public decimal? Octubre { get; set; }
        [Column("NOVIEMBRE", TypeName = "decimal(20, 0)")]
        public decimal? Noviembre { get; set; }
        [Column("DICIEMBRE", TypeName = "decimal(20, 0)")]
        public decimal? Diciembre { get; set; }
        [Column("TOTAL", TypeName = "decimal(20, 0)")]
        public decimal? Total { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        public int? Status { get; set; }
    }
}

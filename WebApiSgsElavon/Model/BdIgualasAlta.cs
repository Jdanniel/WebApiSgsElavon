using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_IGUALAS_ALTA")]
    public partial class BdIgualasAlta
    {
        [Key]
        [Column("ID_IGUALA_ALTA")]
        public int IdIgualaAlta { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(250)]
        public string NoAfiliacion { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("IS_DOLAR")]
        public int? IsDolar { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_CLIENTE_NO_CONFIGURADO")]
        public int? IsClienteNoConfigurado { get; set; }
        [Column("IS_AFILIACION_NO_VALIDO")]
        public int? IsAfiliacionNoValido { get; set; }
        [Column("IS_IGUALA_REPETIDA")]
        public int? IsIgualaRepetida { get; set; }
        [Column("IS_PROCESADO")]
        public int? IsProcesado { get; set; }
        [Column("IS_DUPLICADO_EXCEL")]
        public int? IsDuplicadoExcel { get; set; }
        [Column("HAVE_PRICE_PROBLEM")]
        public int? HavePriceProblem { get; set; }
        [Column("PRECIO_DOLAR", TypeName = "numeric(18, 2)")]
        public decimal? PrecioDolar { get; set; }
        [Column("TIPO_DE_CAMBIO", TypeName = "decimal(8, 4)")]
        public decimal? TipoDeCambio { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COTIZACIONES_3M")]
    public partial class BdCotizaciones3m
    {
        [Key]
        [Column("id_cotizacion")]
        public int IdCotizacion { get; set; }
        [Column("id_negocio")]
        public int? IdNegocio { get; set; }
        [Column("id_genera")]
        public int? IdGenera { get; set; }
        [Column("id_unidad")]
        public int? IdUnidad { get; set; }
        [Column("id_diagnostica")]
        public int? IdDiagnostica { get; set; }
        [Column("id_autoriza")]
        public int? IdAutoriza { get; set; }
        [Column("id_impuesto")]
        public int? IdImpuesto { get; set; }
        [Column("tc")]
        public double? Tc { get; set; }
        [Column("id_condiciones")]
        public int? IdCondiciones { get; set; }
        [Column("no_reporte")]
        [StringLength(20)]
        public string NoReporte { get; set; }
        [Column("total")]
        public double? Total { get; set; }
        [Column("is_autorizada")]
        public int? IsAutorizada { get; set; }
        [Column("id_status")]
        public int? IdStatus { get; set; }
        [Column("id_ar")]
        public int? IdAr { get; set; }
        [Column("fec_alta", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [StringLength(60)]
        public string Atencion { get; set; }
        [Column(TypeName = "numeric(12, 0)")]
        public decimal? Telefono { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("id_reparacion")]
        public int? IdReparacion { get; set; }
        [Column("razon_social")]
        [StringLength(250)]
        public string RazonSocial { get; set; }
    }
}

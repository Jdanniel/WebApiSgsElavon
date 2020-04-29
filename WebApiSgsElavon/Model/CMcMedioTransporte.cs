using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_MEDIO_TRANSPORTE")]
    public partial class CMcMedioTransporte
    {
        [Column("ID_MEDIO_TRANSPORTE")]
        public int IdMedioTransporte { get; set; }
        [Column("DESC_NOMBRE")]
        [StringLength(50)]
        public string DescNombre { get; set; }
        [Column("ESTATUS")]
        [StringLength(50)]
        public string Estatus { get; set; }
        [Required]
        [Column("COSTO_POR_KM")]
        [StringLength(10)]
        public string CostoPorKm { get; set; }
        [Column("COSTO_POR_MANTENIMIENTO")]
        [StringLength(10)]
        public string CostoPorMantenimiento { get; set; }
        [Column("IS_CASETAS")]
        public bool? IsCasetas { get; set; }
        [Column("IS_AUTOBUS")]
        public bool? IsAutobus { get; set; }
        [Column("IS_MANTENIMIENTO")]
        public bool? IsMantenimiento { get; set; }
        [Column("COSTO_POR_CASETA")]
        [StringLength(20)]
        public string CostoPorCaseta { get; set; }
    }
}

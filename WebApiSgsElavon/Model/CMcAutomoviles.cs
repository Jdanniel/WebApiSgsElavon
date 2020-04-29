using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_AUTOMOVILES")]
    public partial class CMcAutomoviles
    {
        [Column("ID_AUTOMOVIL")]
        public int IdAutomovil { get; set; }
        [Column("ID_MEDIO_TRANSPORTE")]
        public int? IdMedioTransporte { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("DESC_MARCA")]
        [StringLength(25)]
        public string DescMarca { get; set; }
        [Column("DESC_MODELO")]
        [StringLength(25)]
        public string DescModelo { get; set; }
        [Column("TIPO")]
        [StringLength(25)]
        public string Tipo { get; set; }
        [Column("ESTATUS")]
        [StringLength(25)]
        public string Estatus { get; set; }
        [Column("PLACAS")]
        [StringLength(10)]
        public string Placas { get; set; }
        [Column("NIV")]
        [StringLength(18)]
        public string Niv { get; set; }
        [Column("RENDIMIENTO_POR_LITRO")]
        public double? RendimientoPorLitro { get; set; }
    }
}

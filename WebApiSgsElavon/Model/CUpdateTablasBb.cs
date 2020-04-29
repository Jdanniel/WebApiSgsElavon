using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_UPDATE_TABLAS_BB")]
    public partial class CUpdateTablasBb
    {
        [Key]
        [Column("ID_UPDATE_TABLAS_BB")]
        public int IdUpdateTablasBb { get; set; }
        [Required]
        [Column("TABLA_UPDATE")]
        [StringLength(50)]
        public string TablaUpdate { get; set; }
        [Column("DESC_TABLA_UPDATE")]
        [StringLength(255)]
        public string DescTablaUpdate { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_UPDATE", TypeName = "smalldatetime")]
        public DateTime? FecUpdate { get; set; }
        [Column("ID_USUARIO_UPDATE")]
        public int? IdUsuarioUpdate { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}

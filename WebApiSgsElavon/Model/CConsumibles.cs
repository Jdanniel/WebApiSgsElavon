using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CONSUMIBLES")]
    public partial class CConsumibles
    {
        [Key]
        [Column("ID_CONSUMIBLE")]
        public int IdConsumible { get; set; }
        [Column("NO_PARTE")]
        [StringLength(255)]
        public string NoParte { get; set; }
        [Required]
        [Column("DESC_CONSUMIBLE")]
        [StringLength(255)]
        public string DescConsumible { get; set; }
        [Column("MARCA")]
        [StringLength(255)]
        public string Marca { get; set; }
        [Column("MODULO")]
        [StringLength(255)]
        public string Modulo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
        [Column("FECHA_STATUS", TypeName = "smalldatetime")]
        public DateTime? FechaStatus { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
    }
}

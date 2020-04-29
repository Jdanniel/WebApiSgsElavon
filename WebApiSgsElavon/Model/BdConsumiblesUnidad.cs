using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONSUMIBLES_UNIDAD")]
    public partial class BdConsumiblesUnidad
    {
        [Key]
        [Column("ID_CONSUMIBLE_UNIDAD")]
        public int IdConsumibleUnidad { get; set; }
        [Column("ID_CONSUMIBLE")]
        public int IdConsumible { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("TOTAL_CONSUMIBLES")]
        public int? TotalConsumibles { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("STATUS")]
        [StringLength(15)]
        public string Status { get; set; }
        [Column("AUTORIZADO")]
        public int? Autorizado { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("NO_CONSUMIBLES_UTILIZADOS")]
        public int? NoConsumiblesUtilizados { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_EXISTENCIAS_CONSUMIBLES_TECNICOS")]
    public partial class BdExistenciasConsumiblesTecnicos
    {
        [Key]
        [Column("ID_EXISTENCIA_CONSUMIBLE_TECNICO")]
        public int IdExistenciaConsumibleTecnico { get; set; }
        [Column("ID_TECNICO")]
        public int IdTecnico { get; set; }
        [Column("ID_CONSUMIBLE")]
        public int IdConsumible { get; set; }
        [Column("CONSUMIBLES_RECIBIDOS")]
        public int? ConsumiblesRecibidos { get; set; }
        [Column("CONSUMIBLES_REPORTADOS")]
        public int? ConsumiblesReportados { get; set; }
    }
}

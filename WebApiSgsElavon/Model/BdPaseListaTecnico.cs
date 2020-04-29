using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PASE_LISTA_TECNICO")]
    public partial class BdPaseListaTecnico
    {
        [Key]
        [Column("ID_PASE_LISTA_TECNICO")]
        public int IdPaseListaTecnico { get; set; }
        [Column("ID_TECNICO")]
        public int IdTecnico { get; set; }
        [Column("FECHA_HORA", TypeName = "smalldatetime")]
        public DateTime FechaHora { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

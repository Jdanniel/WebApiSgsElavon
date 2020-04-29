using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMPROMISOS_ACCIONES")]
    public partial class BdCompromisosAcciones
    {
        [Key]
        [Column("ID_COMPROMISOS_ACCIONES")]
        public int IdCompromisosAcciones { get; set; }
        [Column("ID_COMPROMISO")]
        public int? IdCompromiso { get; set; }
        [Column("DESC_ACCION")]
        [StringLength(250)]
        public string DescAccion { get; set; }
        [Column("PORCENTAJE")]
        public int? Porcentaje { get; set; }
        [Column("ACCION_CONCLUIDA")]
        public int? AccionConcluida { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

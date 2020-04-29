using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_VACACIONES")]
    public partial class BdVacaciones
    {
        [Key]
        [Column("ID_VACACIONES")]
        public int IdVacaciones { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_SOLICITUD", TypeName = "smalldatetime")]
        public DateTime? FecSolicitud { get; set; }
        [Column("FEC_INICIO", TypeName = "smalldatetime")]
        public DateTime? FecInicio { get; set; }
        [Column("FEC_TERMINA", TypeName = "smalldatetime")]
        public DateTime? FecTermina { get; set; }
        [Column("PERIODO")]
        public int? Periodo { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}

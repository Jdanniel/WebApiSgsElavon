using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PERIODO_USUARIO_INACTIVO")]
    public partial class BdPeriodoUsuarioInactivo
    {
        [Key]
        [Column("ID_PERIODO_USUARIO_INACTIVO")]
        public int IdPeriodoUsuarioInactivo { get; set; }
        [Column("ID_USUARIO_CAMBIO")]
        public int? IdUsuarioCambio { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("STATUS_USUARIO")]
        [StringLength(250)]
        public string StatusUsuario { get; set; }
        [Column("FEC_INICIO", TypeName = "smalldatetime")]
        public DateTime? FecInicio { get; set; }
        [Column("FEC_FIN", TypeName = "smalldatetime")]
        public DateTime? FecFin { get; set; }
        [Column("FEC_CAMBIO", TypeName = "smalldatetime")]
        public DateTime? FecCambio { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
    }
}

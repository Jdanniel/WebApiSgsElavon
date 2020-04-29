using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMPROBACION_SOLICITUDES_VIATICOS")]
    public partial class BdComprobacionSolicitudesViaticos
    {
        [Key]
        [Column("ID_COMPROBACION_SOLICITUDES_VIATICOS")]
        public int IdComprobacionSolicitudesViaticos { get; set; }
        [Column("ID_USUARIO_SOLICITADO")]
        public int IdUsuarioSolicitado { get; set; }
        [Column("MONTO_COMPROBADO", TypeName = "numeric(18, 2)")]
        public decimal? MontoComprobado { get; set; }
        [Column("FEC_CORTE_SOLICITUDES_VIATICOS", TypeName = "smalldatetime")]
        public DateTime FecCorteSolicitudesViaticos { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}

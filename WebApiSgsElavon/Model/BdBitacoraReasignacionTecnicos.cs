using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_REASIGNACION_TECNICOS")]
    public partial class BdBitacoraReasignacionTecnicos
    {
        [Key]
        [Column("ID_BITACORA")]
        public int IdBitacora { get; set; }
        [Column("ID_REPARACION_UNIDAD")]
        public int? IdReparacionUnidad { get; set; }
        [Column("ID_USUARIO_ANTERIOR")]
        public int? IdUsuarioAnterior { get; set; }
        [Column("ID_USUARIO_ASIGNADO")]
        public int? IdUsuarioAsignado { get; set; }
        [Column("ID_USUARIO_CAMBIO")]
        public int? IdUsuarioCambio { get; set; }
        [Column("STATUS")]
        [StringLength(25)]
        public string Status { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
    }
}

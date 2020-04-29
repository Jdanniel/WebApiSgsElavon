using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_SUB_SERVICIOS")]
    public partial class BdBitacoraSubServicios
    {
        [Column("ID_BITACORA_SUB_SERVICIOS")]
        public int IdBitacoraSubServicios { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("DESC_FALLA_ANTERIOR")]
        public string DescFallaAnterior { get; set; }
        [Column("DESC_FALLA_ACTUAL")]
        public string DescFallaActual { get; set; }
        [Column("STATUS_ANTERIOR")]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        public string StatusActual { get; set; }
        [Column("IS_DOWNTIME_ANTERIOR")]
        public int? IsDowntimeAnterior { get; set; }
        [Column("IS_DOWNTIME_ACTUAL")]
        public int? IsDowntimeActual { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIOS_ALTA")]
        public int? IdUsuariosAlta { get; set; }
    }
}

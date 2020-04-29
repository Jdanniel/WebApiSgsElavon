using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_VAL_MOVIMIENTOS_INV_SERVICIO_FALLA")]
    public partial class BdValMovimientosInvServicioFalla
    {
        [Column("ID_VAL_MOVIMIENTOS_INV_SERVICIO_FALLA")]
        public int IdValMovimientosInvServicioFalla { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("ID_MOV_INVENTARIO")]
        public int? IdMovInventario { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("STATUS")]
        public string Status { get; set; }
    }
}

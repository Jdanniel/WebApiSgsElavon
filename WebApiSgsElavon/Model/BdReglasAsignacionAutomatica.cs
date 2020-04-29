using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REGLAS_ASIGNACION_AUTOMATICA")]
    public partial class BdReglasAsignacionAutomatica
    {
        [Column("ID_REGLA_ASIGNACION_AUTOMATICA")]
        public int IdReglaAsignacionAutomatica { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
    }
}

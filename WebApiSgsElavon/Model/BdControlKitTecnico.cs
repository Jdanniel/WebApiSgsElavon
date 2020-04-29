using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CONTROL_KIT_TECNICO")]
    public partial class BdControlKitTecnico
    {
        [Column("ID_KIT_TECNICO")]
        public int IdKitTecnico { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
        [Column("CONTROL_INSUMO")]
        public int? ControlInsumo { get; set; }
        [Column("APROBO_CANTIDAD")]
        public int? AproboCantidad { get; set; }
    }
}

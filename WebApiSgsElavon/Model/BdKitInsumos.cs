using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_KIT_INSUMOS")]
    public partial class BdKitInsumos
    {
        [Column("ID_KIT_INSUMO")]
        public int IdKitInsumo { get; set; }
        [Column("ID_INSUMO_PARENT")]
        public int? IdInsumoParent { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("CANTIDAD")]
        public int? Cantidad { get; set; }
    }
}

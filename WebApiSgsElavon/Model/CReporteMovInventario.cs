using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_REPORTE_MOV_INVENTARIO")]
    public partial class CReporteMovInventario
    {
        public CReporteMovInventario()
        {
            BdReporteMovInventario = new HashSet<BdReporteMovInventario>();
        }

        [Key]
        [Column("ID_REPORTE_MOV_INVENTARIO")]
        public int IdReporteMovInventario { get; set; }
        [Column("FEC_INI", TypeName = "smalldatetime")]
        public DateTime? FecIni { get; set; }
        [Column("FEC_FIN", TypeName = "smalldatetime")]
        public DateTime? FecFin { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdReporteMovInventarioNavigation")]
        public virtual ICollection<BdReporteMovInventario> BdReporteMovInventario { get; set; }
    }
}

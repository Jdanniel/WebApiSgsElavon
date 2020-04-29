using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ZONAS")]
    public partial class CZonas
    {
        [Column("ID_ZONA")]
        public int IdZona { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("DESC_ZONA")]
        [StringLength(50)]
        public string DescZona { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ORDEN_F11")]
        public int? OrdenF11 { get; set; }
        [Column("CADENA_F11")]
        [StringLength(50)]
        public string CadenaF11 { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FRONTERA")]
        public bool? Frontera { get; set; }
        [Column("IS_ASIGNACION_AUTO")]
        public int? IsAsignacionAuto { get; set; }

        [ForeignKey("IdRegion")]
        [InverseProperty("CZonas")]
        public virtual CRegiones IdRegionNavigation { get; set; }
    }
}

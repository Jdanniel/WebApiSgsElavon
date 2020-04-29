using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PUESTOS")]
    public partial class CPuestos
    {
        [Key]
        [Column("ID_PUESTO")]
        public int IdPuesto { get; set; }
        [Column("DESC_PUESTO")]
        [StringLength(75)]
        public string DescPuesto { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_RESPONSABLE")]
        public int? IsResponsable { get; set; }
    }
}

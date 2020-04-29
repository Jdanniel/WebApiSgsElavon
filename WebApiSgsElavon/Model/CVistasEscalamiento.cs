using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_VISTAS_ESCALAMIENTO")]
    public partial class CVistasEscalamiento
    {
        public CVistasEscalamiento()
        {
            BdUsuarioVistaEscalamiento = new HashSet<BdUsuarioVistaEscalamiento>();
            BdVistaEscalamientoStatusAr = new HashSet<BdVistaEscalamientoStatusAr>();
        }

        [Key]
        [Column("ID_VISTA_ESCALAMIENTO")]
        public int IdVistaEscalamiento { get; set; }
        [Column("DESC_VISTA_ESCALAMIENTO")]
        [StringLength(50)]
        public string DescVistaEscalamiento { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [InverseProperty("IdVistaEscalamientoNavigation")]
        public virtual ICollection<BdUsuarioVistaEscalamiento> BdUsuarioVistaEscalamiento { get; set; }
        [InverseProperty("IdVistaEscalamientoNavigation")]
        public virtual ICollection<BdVistaEscalamientoStatusAr> BdVistaEscalamientoStatusAr { get; set; }
    }
}

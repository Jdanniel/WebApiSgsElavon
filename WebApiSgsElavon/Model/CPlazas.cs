using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PLAZAS")]
    public partial class CPlazas
    {
        public CPlazas()
        {
            BdPlazaCp = new HashSet<BdPlazaCp>();
        }

        [Key]
        [Column("ID_PLAZA")]
        public int IdPlaza { get; set; }
        [Column("DESC_PLAZA")]
        [StringLength(50)]
        public string DescPlaza { get; set; }
        [Column("ID_TIPO_PLAZA")]
        public int? IdTipoPlaza { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdTipoPlaza")]
        [InverseProperty("CPlazas")]
        public virtual CTipoPlaza IdTipoPlazaNavigation { get; set; }
        [InverseProperty("IdPlazaNavigation")]
        public virtual ICollection<BdPlazaCp> BdPlazaCp { get; set; }
    }
}

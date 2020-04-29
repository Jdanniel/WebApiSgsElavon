using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_GRUPOS")]
    public partial class CGrupos
    {
        public CGrupos()
        {
            BdGruposClientes = new HashSet<BdGruposClientes>();
        }

        [Key]
        [Column("ID_GRUPO")]
        public int IdGrupo { get; set; }
        [Column("DESC_GRUPO")]
        [StringLength(50)]
        public string DescGrupo { get; set; }
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
        [Column("ID_DOCS_TIR")]
        public int? IdDocsTir { get; set; }

        [InverseProperty("IdGrupoNavigation")]
        public virtual ICollection<BdGruposClientes> BdGruposClientes { get; set; }
    }
}

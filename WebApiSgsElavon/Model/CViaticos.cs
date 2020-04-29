using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_VIATICOS")]
    public partial class CViaticos
    {
        public CViaticos()
        {
            BdArViatico = new HashSet<BdArViatico>();
            BdSolicitudesViaticosConceptos = new HashSet<BdSolicitudesViaticosConceptos>();
        }

        [Key]
        [Column("ID_VIATICO")]
        public int IdViatico { get; set; }
        [Column("DESC_VIATICO")]
        [StringLength(50)]
        public string DescViatico { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("IS_AR")]
        public int? IsAr { get; set; }
        [Column("IS_NOT_AR")]
        public int? IsNotAr { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [InverseProperty("IdViaticoNavigation")]
        public virtual ICollection<BdArViatico> BdArViatico { get; set; }
        [InverseProperty("IdViaticoNavigation")]
        public virtual ICollection<BdSolicitudesViaticosConceptos> BdSolicitudesViaticosConceptos { get; set; }
    }
}

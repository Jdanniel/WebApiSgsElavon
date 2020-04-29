using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SOFTWARE")]
    public partial class CSoftware
    {
        public CSoftware()
        {
            BdModeloSustituto = new HashSet<BdModeloSustituto>();
        }

        [Column("ID_SOFTWARE")]
        public int IdSoftware { get; set; }
        [Column("DESC_SOFTWARE")]
        [StringLength(50)]
        public string DescSoftware { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [InverseProperty("IdSoftwareNavigation")]
        public virtual ICollection<BdModeloSustituto> BdModeloSustituto { get; set; }
    }
}

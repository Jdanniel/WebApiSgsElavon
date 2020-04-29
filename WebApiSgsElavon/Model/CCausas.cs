using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CAUSAS")]
    public partial class CCausas
    {
        public CCausas()
        {
            BdServicioCausa = new HashSet<BdServicioCausa>();
        }

        [Key]
        [Column("ID_CAUSA")]
        public int IdCausa { get; set; }
        [Column("DESC_CAUSA")]
        [StringLength(50)]
        public string DescCausa { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("CLAVE")]
        [StringLength(20)]
        public string Clave { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [InverseProperty("IdCausaNavigation")]
        public virtual ICollection<BdServicioCausa> BdServicioCausa { get; set; }
    }
}

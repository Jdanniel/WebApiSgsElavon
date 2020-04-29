using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_LLAVES")]
    public partial class CLlaves
    {
        public CLlaves()
        {
            BdModeloLlave = new HashSet<BdModeloLlave>();
        }

        [Column("ID_LLAVE")]
        public int IdLlave { get; set; }
        [Column("DESC_LLAVE")]
        [StringLength(50)]
        public string DescLlave { get; set; }
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

        [InverseProperty("IdLlaveNavigation")]
        public virtual ICollection<BdModeloLlave> BdModeloLlave { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CLIENTE_PRODUCTO_STATUS_AR")]
    public partial class BdClienteProductoStatusAr
    {
        public BdClienteProductoStatusAr()
        {
            BdReglasStatusAr = new HashSet<BdReglasStatusAr>();
        }

        [Key]
        [Column("ID_CLIENTE_PRODUCTO_STATUS_AR")]
        public int IdClienteProductoStatusAr { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_PRODUCTO_STATUS_AR")]
        public int IdProductoStatusAr { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }

        [ForeignKey("IdProductoStatusAr")]
        [InverseProperty("BdClienteProductoStatusAr")]
        public virtual BdProductoStatusAr IdProductoStatusArNavigation { get; set; }
        [InverseProperty("IdClienteProductoStatusArNavigation")]
        public virtual ICollection<BdReglasStatusAr> BdReglasStatusAr { get; set; }
    }
}

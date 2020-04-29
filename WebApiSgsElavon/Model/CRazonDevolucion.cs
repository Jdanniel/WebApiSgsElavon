using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_RAZON_DEVOLUCION")]
    public partial class CRazonDevolucion
    {
        public CRazonDevolucion()
        {
            BdDevoluciones = new HashSet<BdDevoluciones>();
        }

        [Key]
        [Column("ID_RAZON_DEVOLUCION")]
        public int IdRazonDevolucion { get; set; }
        [Column("DESC_RAZON_DEVOLUCION")]
        [StringLength(50)]
        public string DescRazonDevolucion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdRazonDevolucionNavigation")]
        public virtual ICollection<BdDevoluciones> BdDevoluciones { get; set; }
    }
}

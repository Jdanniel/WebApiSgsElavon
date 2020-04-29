using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_OPERADORES")]
    public partial class COperadores
    {
        public COperadores()
        {
            BdReglasStatusAr = new HashSet<BdReglasStatusAr>();
        }

        [Key]
        [Column("ID_OPERADOR")]
        public int IdOperador { get; set; }
        [Required]
        [Column("DESC_OPERADOR")]
        [StringLength(50)]
        public string DescOperador { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdOperadorNavigation")]
        public virtual ICollection<BdReglasStatusAr> BdReglasStatusAr { get; set; }
    }
}

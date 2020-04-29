using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_PLAZA")]
    public partial class CTipoPlaza
    {
        public CTipoPlaza()
        {
            CPlazas = new HashSet<CPlazas>();
        }

        [Key]
        [Column("ID_TIPO_PLAZA")]
        public int IdTipoPlaza { get; set; }
        [Column("DESC_TIPO_PLAZA")]
        [StringLength(50)]
        public string DescTipoPlaza { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoPlazaNavigation")]
        public virtual ICollection<CPlazas> CPlazas { get; set; }
    }
}

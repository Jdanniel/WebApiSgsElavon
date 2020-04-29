using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIEMPO_MEDICION")]
    public partial class CTiempoMedicion
    {
        public CTiempoMedicion()
        {
            BdReglasStatusAr = new HashSet<BdReglasStatusAr>();
        }

        [Key]
        [Column("ID_TIEMPO_MEDICION")]
        public int IdTiempoMedicion { get; set; }
        [Column("DESC_TIEMPO_MEDICION")]
        [StringLength(50)]
        public string DescTiempoMedicion { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdTiempoMedicionNavigation")]
        public virtual ICollection<BdReglasStatusAr> BdReglasStatusAr { get; set; }
    }
}

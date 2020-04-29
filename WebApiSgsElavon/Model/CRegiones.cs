using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_REGIONES")]
    public partial class CRegiones
    {
        public CRegiones()
        {
            CZonas = new HashSet<CZonas>();
        }

        [Column("ID_REGION")]
        public int IdRegion { get; set; }
        [Column("DESC_REGION")]
        [StringLength(50)]
        public string DescRegion { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("COLOR")]
        [StringLength(6)]
        public string Color { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdRegionNavigation")]
        public virtual ICollection<CZonas> CZonas { get; set; }
    }
}

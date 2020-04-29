using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MONEDAS")]
    public partial class CMonedas
    {
        public CMonedas()
        {
            BdModeloPrecio = new HashSet<BdModeloPrecio>();
            BdSparePartPrecio = new HashSet<BdSparePartPrecio>();
            CModelos = new HashSet<CModelos>();
            CServicios = new HashSet<CServicios>();
        }

        [Key]
        [Column("ID_MONEDA")]
        public int IdMoneda { get; set; }
        [Column("DESC_MONEDA")]
        [StringLength(50)]
        public string DescMoneda { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [InverseProperty("IdMonedaNavigation")]
        public virtual ICollection<BdModeloPrecio> BdModeloPrecio { get; set; }
        [InverseProperty("IdMonedaNavigation")]
        public virtual ICollection<BdSparePartPrecio> BdSparePartPrecio { get; set; }
        [InverseProperty("IdMonedaCostoNavigation")]
        public virtual ICollection<CModelos> CModelos { get; set; }
        [InverseProperty("IdMonedaNavigation")]
        public virtual ICollection<CServicios> CServicios { get; set; }
    }
}

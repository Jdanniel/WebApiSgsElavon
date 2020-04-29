using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("SEPOMEX_ESTADOS")]
    public partial class SepomexEstados
    {
        public SepomexEstados()
        {
            BdClaveEstado = new HashSet<BdClaveEstado>();
            BdNegocios = new HashSet<BdNegocios>();
        }

        [Key]
        [Column("ID_ESTADO")]
        public int IdEstado { get; set; }
        [Required]
        [Column("ESTADO")]
        [StringLength(50)]
        public string Estado { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ABREVIATURA")]
        [StringLength(4)]
        public string Abreviatura { get; set; }

        [InverseProperty("IdEstadoNavigation")]
        public virtual ICollection<BdClaveEstado> BdClaveEstado { get; set; }
        [InverseProperty("IdEstadoNavigation")]
        public virtual ICollection<BdNegocios> BdNegocios { get; set; }
    }
}

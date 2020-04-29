using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_SOPORTE_TECNICO")]
    public partial class CTipoSoporteTecnico
    {
        public CTipoSoporteTecnico()
        {
            BdSoporteTecnico = new HashSet<BdSoporteTecnico>();
        }

        [Key]
        [Column("ID_TIPO_SOPORTE_TECNICO")]
        public int IdTipoSoporteTecnico { get; set; }
        [Column("DESC_TIPO_SOPORTE_TECNICO")]
        [StringLength(50)]
        public string DescTipoSoporteTecnico { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdTipoSoporteTecnicoNavigation")]
        public virtual ICollection<BdSoporteTecnico> BdSoporteTecnico { get; set; }
    }
}

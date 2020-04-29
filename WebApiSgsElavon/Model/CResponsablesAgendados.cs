using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_RESPONSABLES_AGENDADOS")]
    public partial class CResponsablesAgendados
    {
        public CResponsablesAgendados()
        {
            BdBitacoraAgendados = new HashSet<BdBitacoraAgendados>();
        }

        [Column("ID_RESPONSABLE_AGENDADO")]
        public int IdResponsableAgendado { get; set; }
        [Column("DESC_RESPONSABLE_AGENDADO")]
        [StringLength(50)]
        public string DescResponsableAgendado { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [InverseProperty("IdResponsableAgendadoNavigation")]
        public virtual ICollection<BdBitacoraAgendados> BdBitacoraAgendados { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_HORARIOS")]
    public partial class CHorarios
    {
        public CHorarios()
        {
            BdHorarioHorasMes = new HashSet<BdHorarioHorasMes>();
            BdHorarioWeekhour = new HashSet<BdHorarioWeekhour>();
            BdNegociosIdHorarioAccesoNavigation = new HashSet<BdNegocios>();
            BdNegociosIdHorarioUptimeNavigation = new HashSet<BdNegocios>();
        }

        [Column("ID_HORARIO")]
        public int IdHorario { get; set; }
        [Column("DESC_HORARIO")]
        [StringLength(50)]
        public string DescHorario { get; set; }
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

        [InverseProperty("IdHorarioNavigation")]
        public virtual ICollection<BdHorarioHorasMes> BdHorarioHorasMes { get; set; }
        [InverseProperty("IdHorarioNavigation")]
        public virtual ICollection<BdHorarioWeekhour> BdHorarioWeekhour { get; set; }
        [InverseProperty("IdHorarioAccesoNavigation")]
        public virtual ICollection<BdNegocios> BdNegociosIdHorarioAccesoNavigation { get; set; }
        [InverseProperty("IdHorarioUptimeNavigation")]
        public virtual ICollection<BdNegocios> BdNegociosIdHorarioUptimeNavigation { get; set; }
    }
}

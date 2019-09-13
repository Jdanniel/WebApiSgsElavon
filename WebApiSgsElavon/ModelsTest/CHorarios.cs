using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CHorarios
    {
        public CHorarios()
        {
            BdHorarioHorasMes = new HashSet<BdHorarioHorasMes>();
            BdHorarioWeekhour = new HashSet<BdHorarioWeekhour>();
            BdNegociosIdHorarioAccesoNavigation = new HashSet<BdNegocios>();
            BdNegociosIdHorarioUptimeNavigation = new HashSet<BdNegocios>();
        }

        public int IdHorario { get; set; }
        public string DescHorario { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual ICollection<BdHorarioHorasMes> BdHorarioHorasMes { get; set; }
        public virtual ICollection<BdHorarioWeekhour> BdHorarioWeekhour { get; set; }
        public virtual ICollection<BdNegocios> BdNegociosIdHorarioAccesoNavigation { get; set; }
        public virtual ICollection<BdNegocios> BdNegociosIdHorarioUptimeNavigation { get; set; }
    }
}

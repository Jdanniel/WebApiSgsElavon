using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdAuditorias
    {
        public BdAuditorias()
        {
            BdAuditoriaReporte = new HashSet<BdAuditoriaReporte>();
        }

        public int IdAuditoria { get; set; }
        public string DescAuditoria { get; set; }
        public int? IdTipoAuditoria { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Status { get; set; }
        public int? IdRegion { get; set; }

        public virtual CTipoAuditoria IdTipoAuditoriaNavigation { get; set; }
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
        public virtual ICollection<BdAuditoriaReporte> BdAuditoriaReporte { get; set; }
    }
}

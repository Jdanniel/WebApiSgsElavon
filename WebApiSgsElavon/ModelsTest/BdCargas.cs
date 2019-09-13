using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCargas
    {
        public BdCargas()
        {
            BdNegociosIdCargaAltaNavigation = new HashSet<BdNegocios>();
            BdNegociosIdCargaStatusNavigation = new HashSet<BdNegocios>();
        }

        public int IdCarga { get; set; }
        public int? IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdAttachArchivo1 { get; set; }
        public int IdStatusCarga { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdNegocios> BdNegociosIdCargaAltaNavigation { get; set; }
        public virtual ICollection<BdNegocios> BdNegociosIdCargaStatusNavigation { get; set; }
    }
}

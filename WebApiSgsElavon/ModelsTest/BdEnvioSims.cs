using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdEnvioSims
    {
        public int IdEnvioSim { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdSim { get; set; }
        public int? IdEnvio { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IsRecibida { get; set; }
        public DateTime? FecRecibida { get; set; }
        public int? IdUsuarioRecepcion { get; set; }
        public int? IdStatusUnidad2 { get; set; }

        public virtual BdMcSims IdSimNavigation { get; set; }
        public virtual CUsuarios IdUsuarioRecepcionNavigation { get; set; }
    }
}

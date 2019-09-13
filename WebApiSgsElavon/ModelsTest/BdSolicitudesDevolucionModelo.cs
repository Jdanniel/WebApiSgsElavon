using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdSolicitudesDevolucionModelo
    {
        public int IdSolicitudDevolucionModelo { get; set; }
        public int? IdSolicitudDevolucion { get; set; }
        public int? IdModelo { get; set; }
        public int? NoUnidades { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CModelos IdModeloNavigation { get; set; }
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}

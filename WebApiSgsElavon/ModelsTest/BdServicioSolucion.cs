using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdServicioSolucion
    {
        public int IdServicioSolucion { get; set; }
        public int IdServicio { get; set; }
        public int IdSolucion { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CServicios IdServicioNavigation { get; set; }
        public virtual CSoluciones IdSolucionNavigation { get; set; }
    }
}

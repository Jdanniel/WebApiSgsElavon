using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CChoferes
    {
        public CChoferes()
        {
            BdSolicitudRecoleccion = new HashSet<BdSolicitudRecoleccion>();
        }

        public int IdChofer { get; set; }
        public int IdServicioMensajeria { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Status { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }

        public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
    }
}

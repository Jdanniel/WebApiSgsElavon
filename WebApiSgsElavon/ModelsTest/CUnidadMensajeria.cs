using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CUnidadMensajeria
    {
        public CUnidadMensajeria()
        {
            BdSolicitudRecoleccion = new HashSet<BdSolicitudRecoleccion>();
        }

        public int IdUnidadMensajeria { get; set; }
        public int IdServicioMensajeria { get; set; }
        public string DescUnidadMensajeria { get; set; }
        public string Status { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }

        public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
    }
}

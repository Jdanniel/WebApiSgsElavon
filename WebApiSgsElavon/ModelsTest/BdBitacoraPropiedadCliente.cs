using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraPropiedadCliente
    {
        public int IdBitacoraPropiedadCliente { get; set; }
        public int? IdUnidad { get; set; }
        public int? IsPropiedadClienteActual { get; set; }
        public int? IsPropiedadClienteNuevo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }

        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

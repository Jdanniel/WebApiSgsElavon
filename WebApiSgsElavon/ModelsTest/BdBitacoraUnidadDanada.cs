using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraUnidadDanada
    {
        public int IdBitacoraUnidadDanada { get; set; }
        public int? IdUnidad { get; set; }
        public int? IsDaniadaActual { get; set; }
        public int? IsDaniadaNuevo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }

        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

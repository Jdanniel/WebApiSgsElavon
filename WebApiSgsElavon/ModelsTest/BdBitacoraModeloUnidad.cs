using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraModeloUnidad
    {
        public int IdBitacoraModeloUnidad { get; set; }
        public int IdUnidad { get; set; }
        public int IdModeloViejo { get; set; }
        public int IdModeloNuevo { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }

        public virtual CModelos IdModeloNuevoNavigation { get; set; }
        public virtual CModelos IdModeloViejoNavigation { get; set; }
        public virtual BdUnidades IdUnidadNavigation { get; set; }
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdModeloAccesorio
    {
        public int IdModeloAccesorio { get; set; }
        public int? IdModelo { get; set; }
        public int? IdAccesorio { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CAccesorios IdAccesorioNavigation { get; set; }
        public virtual CModelos IdModeloNavigation { get; set; }
    }
}

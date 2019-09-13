using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdTipoServicioProducto
    {
        public int IdTipoServicioProducto { get; set; }
        public int IdTipoServicio { get; set; }
        public int IdProducto { get; set; }
        public int? IdTipoCobro { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CTipoCobro IdTipoCobroNavigation { get; set; }
        public virtual CTipoServicio IdTipoServicioNavigation { get; set; }
    }
}

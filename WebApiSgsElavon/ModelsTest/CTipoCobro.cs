using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoCobro
    {
        public CTipoCobro()
        {
            BdArVisitas = new HashSet<BdArVisitas>();
            BdTipoServicioProducto = new HashSet<BdTipoServicioProducto>();
        }

        public int IdTipoCobro { get; set; }
        public string DescTipoCobro { get; set; }
        public int? IsCobrable { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdArVisitas> BdArVisitas { get; set; }
        public virtual ICollection<BdTipoServicioProducto> BdTipoServicioProducto { get; set; }
    }
}

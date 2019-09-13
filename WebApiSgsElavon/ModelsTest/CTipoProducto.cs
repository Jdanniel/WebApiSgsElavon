using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoProducto
    {
        public CTipoProducto()
        {
            CProductos = new HashSet<CProductos>();
        }

        public int IdTipoProducto { get; set; }
        public string DescTipoProducto { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CProductos> CProductos { get; set; }
    }
}

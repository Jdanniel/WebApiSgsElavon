using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdProductoStatusAr
    {
        public BdProductoStatusAr()
        {
            BdClienteProductoStatusAr = new HashSet<BdClienteProductoStatusAr>();
        }

        public int IdProductoStatusAr { get; set; }
        public int? IdProducto { get; set; }
        public int? IdStatusAr { get; set; }
        public string StatusWeb { get; set; }
        public string StatusBb { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CStatusAr IdStatusArNavigation { get; set; }
        public virtual ICollection<BdClienteProductoStatusAr> BdClienteProductoStatusAr { get; set; }
    }
}

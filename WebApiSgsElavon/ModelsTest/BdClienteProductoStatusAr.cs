using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdClienteProductoStatusAr
    {
        public BdClienteProductoStatusAr()
        {
            BdReglasStatusAr = new HashSet<BdReglasStatusAr>();
        }

        public int IdClienteProductoStatusAr { get; set; }
        public int IdCliente { get; set; }
        public int IdProductoStatusAr { get; set; }
        public DateTime FecAlta { get; set; }
        public int IdUsuarioAlta { get; set; }

        public virtual BdProductoStatusAr IdProductoStatusArNavigation { get; set; }
        public virtual ICollection<BdReglasStatusAr> BdReglasStatusAr { get; set; }
    }
}

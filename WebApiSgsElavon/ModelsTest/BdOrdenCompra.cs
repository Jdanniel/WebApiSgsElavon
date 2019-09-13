using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdOrdenCompra
    {
        public BdOrdenCompra()
        {
            BdOrdenCompraUnidades = new HashSet<BdOrdenCompraUnidades>();
        }

        public int IdOrdenCompra { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IdStatusOrdenCompra { get; set; }
        public DateTime? FecOrdenCompra { get; set; }

        public virtual ICollection<BdOrdenCompraUnidades> BdOrdenCompraUnidades { get; set; }
    }
}

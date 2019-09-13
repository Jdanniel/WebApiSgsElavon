using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CMarcas
    {
        public CMarcas()
        {
            BdModeloModulo = new HashSet<BdModeloModulo>();
        }

        public int IdMarca { get; set; }
        public int? IdProducto { get; set; }
        public string DescMarca { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public int? IdAccess { get; set; }

        public virtual CProductos IdProductoNavigation { get; set; }
        public virtual ICollection<BdModeloModulo> BdModeloModulo { get; set; }
    }
}

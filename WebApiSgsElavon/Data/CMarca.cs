using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CMarca
{
    public int IdMarca { get; set; }

    public int? IdProducto { get; set; }

    public string DescMarca { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public int? IdAccess { get; set; }

    public virtual ICollection<BdModeloModulo> BdModeloModulos { get; set; } = new List<BdModeloModulo>();

    public virtual CProducto IdProductoNavigation { get; set; }
}

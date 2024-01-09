using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CProducto
{
    public int IdProducto { get; set; }

    public int? IdTipoProducto { get; set; }

    public int? IdParent { get; set; }

    public string DescProducto { get; set; }

    public string Descripcion { get; set; }

    public string Image { get; set; }

    public string ImageEdit { get; set; }

    public string ImageInactive { get; set; }

    public string Class { get; set; }

    public string ClassEdit { get; set; }

    public string Status { get; set; }

    public int? IsGprs { get; set; }

    public int? IsAccesorios { get; set; }

    public int? IsInsumos { get; set; }

    public int? IsKey { get; set; }

    public int? IsSoftware { get; set; }

    public int? IsBom { get; set; }

    public int? IsSpareParts { get; set; }

    public virtual ICollection<BdModeloModulo> BdModeloModulos { get; set; } = new List<BdModeloModulo>();

    public virtual ICollection<CMarca> CMarcas { get; set; } = new List<CMarca>();

    public virtual CTipoProducto IdTipoProductoNavigation { get; set; }
}

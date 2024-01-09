using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CSparePart
{
    public int IdSparePart { get; set; }

    public string DescSparePart { get; set; }

    public string Descripcion { get; set; }

    public int? IdMarca { get; set; }

    public int? IdTipoSparePart { get; set; }

    public decimal? Costo { get; set; }

    public string Sku { get; set; }

    public int? IdAttachImagenSparePart { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdArSparePart> BdArSpareParts { get; set; } = new List<BdArSparePart>();

    public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOlds { get; set; } = new List<BdSolicitudesAlmacenOld>();

    public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacens { get; set; } = new List<BdSolicitudesAlmacen>();

    public virtual ICollection<BdSparePartPrecio> BdSparePartPrecios { get; set; } = new List<BdSparePartPrecio>();

    public virtual CTipoSparePart IdTipoSparePartNavigation { get; set; }
}

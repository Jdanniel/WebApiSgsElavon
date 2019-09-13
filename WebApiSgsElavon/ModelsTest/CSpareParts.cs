using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CSpareParts
    {
        public CSpareParts()
        {
            BdArSparePart = new HashSet<BdArSparePart>();
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
            BdSolicitudesAlmacenOld = new HashSet<BdSolicitudesAlmacenOld>();
            BdSparePartPrecio = new HashSet<BdSparePartPrecio>();
        }

        public int IdSparePart { get; set; }
        public string DescSparePart { get; set; }
        public string Descripcion { get; set; }
        public int? IdMarca { get; set; }
        public int? IdTipoSparePart { get; set; }
        public decimal? Costo { get; set; }
        public string Sku { get; set; }
        public int? IdAttachImagenSparePart { get; set; }
        public string Status { get; set; }

        public virtual CTipoSparePart IdTipoSparePartNavigation { get; set; }
        public virtual ICollection<BdArSparePart> BdArSparePart { get; set; }
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
        public virtual ICollection<BdSparePartPrecio> BdSparePartPrecio { get; set; }
    }
}

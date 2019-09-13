using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CAlmacenes
    {
        public CAlmacenes()
        {
            BdSolicitudesAlmacenOld = new HashSet<BdSolicitudesAlmacenOld>();
            CSubAlmacenes = new HashSet<CSubAlmacenes>();
        }

        public int IdAlmacen { get; set; }
        public string DescAlmacen { get; set; }
        public string Descripcion { get; set; }
        public int IdZona { get; set; }
        public int IsLab { get; set; }
        public string Status { get; set; }
        public int? IdResponsable { get; set; }
        public bool? AutoNotif { get; set; }
        public int? IsPropiedadCliente { get; set; }
        public int? EnvioEmail { get; set; }
        public int? IdProveedor { get; set; }

        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
        public virtual ICollection<CSubAlmacenes> CSubAlmacenes { get; set; }
    }
}

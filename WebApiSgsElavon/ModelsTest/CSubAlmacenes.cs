using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CSubAlmacenes
    {
        public int IdCSubAlmacenes { get; set; }
        public string DescSubAlmacen { get; set; }
        public string Descripcion { get; set; }
        public int? IdParentAlmacen { get; set; }
        public int? IdZona { get; set; }
        public string Status { get; set; }
        public int? IdResponsable { get; set; }

        public virtual CAlmacenes IdParentAlmacenNavigation { get; set; }
    }
}

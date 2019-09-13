using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CRegiones
    {
        public CRegiones()
        {
            CZonas = new HashSet<CZonas>();
        }

        public int IdRegion { get; set; }
        public string DescRegion { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CZonas> CZonas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CRazonDevolucion
    {
        public CRazonDevolucion()
        {
            BdDevoluciones = new HashSet<BdDevoluciones>();
        }

        public int IdRazonDevolucion { get; set; }
        public string DescRazonDevolucion { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdDevoluciones> BdDevoluciones { get; set; }
    }
}

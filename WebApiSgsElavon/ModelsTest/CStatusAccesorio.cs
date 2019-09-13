using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CStatusAccesorio
    {
        public CStatusAccesorio()
        {
            BdUnidadAccesorio = new HashSet<BdUnidadAccesorio>();
        }

        public int IdStatusAccesorio { get; set; }
        public string DescStatusAccesorio { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdUnidadAccesorio> BdUnidadAccesorio { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CMovInv
    {
        public CMovInv()
        {
            BdServicioMovInv = new HashSet<BdServicioMovInv>();
        }

        public int IdMovInv { get; set; }
        public string DescMovInv { get; set; }
        public string Corto { get; set; }
        public string Href { get; set; }
        public string Status { get; set; }
        public int? IsObligatorio { get; set; }

        public virtual ICollection<BdServicioMovInv> BdServicioMovInv { get; set; }
    }
}

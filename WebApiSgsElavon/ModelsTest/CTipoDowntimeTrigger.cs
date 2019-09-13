using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoDowntimeTrigger
    {
        public CTipoDowntimeTrigger()
        {
            CStatusAr = new HashSet<CStatusAr>();
        }

        public int IdTipoDowntimeTrigger { get; set; }
        public string DescTipoDowntimeTrigger { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CStatusAr> CStatusAr { get; set; }
    }
}

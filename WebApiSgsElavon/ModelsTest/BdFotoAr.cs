using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdFotoAr
    {
        public int IdFotoAr { get; set; }
        public int? IdAttach { get; set; }
        public int? IdAr { get; set; }

        public virtual BdAttach IdAttachNavigation { get; set; }
    }
}

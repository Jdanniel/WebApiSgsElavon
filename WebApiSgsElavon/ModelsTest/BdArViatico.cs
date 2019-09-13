using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArViatico
    {
        public int IdArViatico { get; set; }
        public int IdAr { get; set; }
        public int IdViatico { get; set; }
        public decimal Costo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CViaticos IdViaticoNavigation { get; set; }
    }
}

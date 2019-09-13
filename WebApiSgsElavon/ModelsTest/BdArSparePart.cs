using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArSparePart
    {
        public int IdArSparePart { get; set; }
        public int IdAr { get; set; }
        public int IdSparePart { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CSpareParts IdSparePartNavigation { get; set; }
    }
}

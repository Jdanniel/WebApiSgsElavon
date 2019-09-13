using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArInsumo
    {
        public int IdArInsumo { get; set; }
        public int IdAr { get; set; }
        public int IdInsumo { get; set; }
        public int? Cantidad { get; set; }
        public decimal? CostoUnitario { get; set; }
        public decimal? CostoTotal { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IsMicrosip { get; set; }
        public int? ControlMicrosip { get; set; }
    }
}

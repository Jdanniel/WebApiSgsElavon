using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdKitInsumos
    {
        public int IdKitInsumo { get; set; }
        public int? IdInsumoParent { get; set; }
        public int? IdInsumo { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? Cantidad { get; set; }
    }
}

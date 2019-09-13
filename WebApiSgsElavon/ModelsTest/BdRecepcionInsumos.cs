using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdRecepcionInsumos
    {
        public int IdRecepcionInsumo { get; set; }
        public int? IdOrdenCompra { get; set; }
        public int? IdInsumo { get; set; }
        public double? CantidadRecepcionada { get; set; }
    }
}

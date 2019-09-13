using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CClientesPmo
    {
        public int IdClienteProducto { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProducto { get; set; }
        public string Status { get; set; }
    }
}

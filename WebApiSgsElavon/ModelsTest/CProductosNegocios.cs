using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CProductosNegocios
    {
        public int IdProductoNegocio { get; set; }
        public string DescProductoNegocio { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}

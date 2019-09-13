using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdServicioTipoFalla
    {
        public int IdServicioTipoFalla { get; set; }
        public int? IdServicio { get; set; }
        public int? IdTipoFalla { get; set; }
        public int? IdCliente { get; set; }
    }
}

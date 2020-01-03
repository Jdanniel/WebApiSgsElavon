using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdEstadosProveedores
    {
        public int IdEstadoProveedor { get; set; }
        public int? IdEstado { get; set; }
        public string Cp { get; set; }
        public int? IdProveedor { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}

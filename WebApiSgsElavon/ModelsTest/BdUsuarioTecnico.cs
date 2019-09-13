using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdUsuarioTecnico
    {
        public int IdUsuarioTecnico { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdTecnico { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdFallaConFallaEncontrada
    {
        public int IdFallaFallaEncontrada { get; set; }
        public int? IdFallaPadre { get; set; }
        public int? IdFallaHijo { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
    }
}

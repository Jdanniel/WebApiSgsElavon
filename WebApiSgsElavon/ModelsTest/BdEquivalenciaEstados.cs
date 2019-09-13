using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdEquivalenciaEstados
    {
        public int IdEquivalenciaEstado { get; set; }
        public string EstadoSepomex { get; set; }
        public string EstadoEquivalencia { get; set; }
        public DateTime? FectAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}

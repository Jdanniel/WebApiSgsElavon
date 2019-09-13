using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CMcRutas
    {
        public int IdRuta { get; set; }
        public string DescNombre { get; set; }
        public string PoblacionOrigen { get; set; }
        public string EstadoOrigen { get; set; }
        public string PoblacionDestino { get; set; }
        public string EstadoDestino { get; set; }
        public string Estatus { get; set; }
    }
}

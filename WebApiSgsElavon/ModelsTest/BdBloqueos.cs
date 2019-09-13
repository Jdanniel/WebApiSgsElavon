using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBloqueos
    {
        public int IdBloqueo { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string NoAfiliacion { get; set; }
        public string Cp { get; set; }
        public string Proveedor { get; set; }
        public string Territorio { get; set; }
        public int TotalRollos { get; set; }
        public int Bloqueo { get; set; }
        public string Mensaje { get; set; }
    }
}

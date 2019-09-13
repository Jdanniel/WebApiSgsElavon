using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraRechazosEnvios
    {
        public int IdBitacoraRechazo { get; set; }
        public int? IdEnvio { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

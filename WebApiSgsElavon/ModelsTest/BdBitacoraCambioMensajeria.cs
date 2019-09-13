using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraCambioMensajeria
    {
        public int IdBitacoraCambioMensajeria { get; set; }
        public int? IdEnvio { get; set; }
        public int? IdMensajeriaIni { get; set; }
        public int? IdMensajeriaFin { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

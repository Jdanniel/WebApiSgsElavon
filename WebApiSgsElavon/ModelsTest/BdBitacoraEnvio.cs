using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraEnvio
    {
        public int IdBitacoraEnvio { get; set; }
        public int IdEnvio { get; set; }
        public int? IdStatusEnvioIni { get; set; }
        public int? IdStatusEnvioFin { get; set; }
        public int? IdTipoResponsableOrigen { get; set; }
        public int? IdResponsableOrigen { get; set; }
        public int? IdTipoResponsableDestino { get; set; }
        public int? IdResponsableDestino { get; set; }
        public string Comentario { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

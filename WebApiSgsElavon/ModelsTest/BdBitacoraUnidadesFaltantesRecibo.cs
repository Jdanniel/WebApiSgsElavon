using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraUnidadesFaltantesRecibo
    {
        public int IdBitacoraUnidadFaltante { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdEnvio { get; set; }
        public int? IdStatusEnvio { get; set; }
        public string FecEnvio { get; set; }
        public int? IdTipoResponsableOrigen { get; set; }
        public int? IdResponsableOrigen { get; set; }
        public int? IdTipoResponsableDestino { get; set; }
        public int? IdResponsableDestino { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? NoUnidadesNoRecibidas { get; set; }
        public int? NoUnidadesInsumosNoRecibidas { get; set; }
    }
}

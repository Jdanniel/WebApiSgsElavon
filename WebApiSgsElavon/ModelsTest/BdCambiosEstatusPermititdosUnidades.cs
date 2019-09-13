using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCambiosEstatusPermititdosUnidades
    {
        public int IdCambioEstatusPermitido { get; set; }
        public int? IdStatusIni { get; set; }
        public int? IdStatusFin { get; set; }
        public int? IsValidacionEnvio { get; set; }
        public int? IdTipoResponsable { get; set; }
        public int? IdResponsable { get; set; }
        public int? ArchivoObligatorio { get; set; }
        public int? Status { get; set; }
        public int? LiberarEnvio { get; set; }
    }
}

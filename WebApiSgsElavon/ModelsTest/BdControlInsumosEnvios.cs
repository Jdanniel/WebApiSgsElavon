using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdControlInsumosEnvios
    {
        public int IdControlInsumoEnvio { get; set; }
        public int? IdEnvio { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdResponsableOrigen { get; set; }
        public int? IdResponsableDestino { get; set; }
        public int? IdTipoResponsableOrigen { get; set; }
        public int? IdTipoResponsableDestino { get; set; }
        public int? Cantidad { get; set; }
        public int? IdStatusInsumo { get; set; }
        public int? IdCliente { get; set; }
        public int? IsReception { get; set; }
        public int? CantidadRetorno { get; set; }
    }
}

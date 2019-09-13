using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdLoadFilterEstafeta
    {
        public int IdLoadFilterEstafeta { get; set; }
        public int? IdServicioMensajeriaPrecio { get; set; }
        public int? IdCarga { get; set; }
        public int? IdEnvio { get; set; }
        public int? IdCliente { get; set; }
        public int? IdRegion { get; set; }
        public string Cliente { get; set; }
        public string Region { get; set; }
        public string NoGuia { get; set; }
        public decimal? CostoSgs { get; set; }
        public int? IdCargaEnvioEstafeta { get; set; }
    }
}

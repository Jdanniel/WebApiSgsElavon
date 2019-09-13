using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdConfiguracionMensajeria
    {
        public int IdConfiguracion { get; set; }
        public int? IdServicioMensajeria { get; set; }
        public int? Longitud { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
        public decimal? Fiull { get; set; }
    }
}

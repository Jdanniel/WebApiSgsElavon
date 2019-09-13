using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdConsumiblesUnidad
    {
        public int IdConsumibleUnidad { get; set; }
        public int IdConsumible { get; set; }
        public int IdUnidad { get; set; }
        public int? TotalConsumibles { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Status { get; set; }
        public int? Autorizado { get; set; }
        public int? IdTecnico { get; set; }
        public int? NoConsumiblesUtilizados { get; set; }
    }
}

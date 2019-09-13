using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdPresupuestosEjercido
    {
        public int IdPresupuestoEjercido { get; set; }
        public int? IdCliente { get; set; }
        public int? Year { get; set; }
        public int? IdRegion { get; set; }
        public int? IdConcepto { get; set; }
        public string Mes { get; set; }
        public int? Semana { get; set; }
        public decimal? Importe { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

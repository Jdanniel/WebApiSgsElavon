using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class NegociosMontepio
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdRegion { get; set; }
        public int? IdZona { get; set; }
        public double? IdSegmento { get; set; }
        public string NoAfiliacion { get; set; }
        public string DescNegocio { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string Poblacion { get; set; }
        public string Estado { get; set; }
        public int? IdEstado { get; set; }
        public double? Cp { get; set; }
        public double? Telefono { get; set; }
        public int? IsDuplicated { get; set; }
    }
}

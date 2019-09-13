using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CMcAutomoviles
    {
        public int IdAutomovil { get; set; }
        public int? IdMedioTransporte { get; set; }
        public int? IdTecnico { get; set; }
        public string DescMarca { get; set; }
        public string DescModelo { get; set; }
        public string Tipo { get; set; }
        public string Estatus { get; set; }
        public string Placas { get; set; }
        public string Niv { get; set; }
        public double? RendimientoPorLitro { get; set; }
    }
}

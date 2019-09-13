using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdIgualasAlta
    {
        public int IdIgualaAlta { get; set; }
        public string NoAfiliacion { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? Precio { get; set; }
        public int? IsDolar { get; set; }
        public int? IdCliente { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IsClienteNoConfigurado { get; set; }
        public int? IsAfiliacionNoValido { get; set; }
        public int? IsIgualaRepetida { get; set; }
        public int? IsProcesado { get; set; }
        public int? IsDuplicadoExcel { get; set; }
        public int? HavePriceProblem { get; set; }
        public decimal? PrecioDolar { get; set; }
        public decimal? TipoDeCambio { get; set; }
    }
}

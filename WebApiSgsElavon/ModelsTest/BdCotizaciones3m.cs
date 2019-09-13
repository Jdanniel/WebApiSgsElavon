using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCotizaciones3m
    {
        public int IdCotizacion { get; set; }
        public int? IdNegocio { get; set; }
        public int? IdGenera { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdDiagnostica { get; set; }
        public int? IdAutoriza { get; set; }
        public int? IdImpuesto { get; set; }
        public double? Tc { get; set; }
        public int? IdCondiciones { get; set; }
        public string NoReporte { get; set; }
        public double? Total { get; set; }
        public int? IsAutorizada { get; set; }
        public int? IdStatus { get; set; }
        public int? IdAr { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Atencion { get; set; }
        public decimal? Telefono { get; set; }
        public string Email { get; set; }
        public int? IdReparacion { get; set; }
        public string RazonSocial { get; set; }
    }
}

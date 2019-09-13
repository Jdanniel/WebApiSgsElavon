using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReparacionUnidad
    {
        public int IdReparacionUnidad { get; set; }
        public int? IdReparacion { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdTecnico { get; set; }
        public int? IdStatusReparacion { get; set; }
        public decimal? Costo { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecStatus { get; set; }
        public int? IdUsuarioStatus { get; set; }
        public DateTime? FecReparacion { get; set; }
        public int? IdUsuarioReparacion { get; set; }
        public int? IdNivelReparacion { get; set; }
        public int? IdTipoReparacion { get; set; }
        public int? IdSoftware { get; set; }
        public int? IdLlave { get; set; }
        public string DescReparacion { get; set; }
    }
}

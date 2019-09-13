using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdUnidadAccesorio
    {
        public int IdUnidadAccesorio { get; set; }
        public int IdUnidad { get; set; }
        public int IdAccesorio { get; set; }
        public decimal? Costo { get; set; }
        public string NoSerie { get; set; }
        public int? IdStatusAccesorio { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioStatus { get; set; }
        public DateTime? FecStatus { get; set; }

        public virtual CAccesorios IdAccesorioNavigation { get; set; }
        public virtual CStatusAccesorio IdStatusAccesorioNavigation { get; set; }
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

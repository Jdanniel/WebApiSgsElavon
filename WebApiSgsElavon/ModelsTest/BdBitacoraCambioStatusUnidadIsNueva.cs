using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraCambioStatusUnidadIsNueva
    {
        public int IdBdBitacoraCambioStatusUnidadIsNueva { get; set; }
        public string NoSerie { get; set; }
        public int? IdUnidad { get; set; }
        public int? IsNuevaAnterior { get; set; }
        public int? IsNuevaActual { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}

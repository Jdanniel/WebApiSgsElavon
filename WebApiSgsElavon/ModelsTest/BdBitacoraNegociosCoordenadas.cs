using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraNegociosCoordenadas
    {
        public int IdBitcoraNegocioCoordenada { get; set; }
        public int? IdNegocio { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

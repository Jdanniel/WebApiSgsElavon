using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraAr
    {
        public int IdBitacoraAr { get; set; }
        public int IdAr { get; set; }
        public int? IdStatusArIni { get; set; }
        public int? IdStatusArFin { get; set; }
        public string Comentario { get; set; }
        public int? IsPda { get; set; }
        public int? IsCambioValido { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

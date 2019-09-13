using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdAltaFecGarantia
    {
        public int IdAlta { get; set; }
        public int? IdAr { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? Hora { get; set; }
        public int? IdUsuario { get; set; }
        public string Error { get; set; }
        public string Status { get; set; }
        public int? IdCarga { get; set; }
    }
}

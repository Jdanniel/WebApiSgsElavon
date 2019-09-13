using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraServiciosFalla
    {
        public int IdBitacoraServiciosFalla { get; set; }
        public int? IdServicioFalla { get; set; }
        public int? IdServicio { get; set; }
        public int? IdFalla { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Accion { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}

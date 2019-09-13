using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdChancgeLog
    {
        public int IdChangeLog { get; set; }
        public string Tipo { get; set; }
        public string BorraCache { get; set; }
        public string Proceso { get; set; }
        public string Contenido { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdChangeLog
    {
        public int IdChangelog { get; set; }
        public int? IdTipoChange { get; set; }
        public string BorrarCache { get; set; }
        public int? IdModulo { get; set; }
        public int? IdOpcion { get; set; }
        public string Descripcion { get; set; }
        public string Nota { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
        public DateTime? Liberacion { get; set; }
    }
}

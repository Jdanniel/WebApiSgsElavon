using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCargasRecalcularFechas
    {
        public int IdRecalcula { get; set; }
        public string FileName { get; set; }
        public string Ruta { get; set; }
        public string IdProceso { get; set; }
        public string Odt { get; set; }
        public DateTime? FecAtencionNueva { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

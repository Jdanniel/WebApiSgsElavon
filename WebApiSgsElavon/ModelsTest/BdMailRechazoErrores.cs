using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdMailRechazoErrores
    {
        public int IdMailRechazoErrores { get; set; }
        public string Odt { get; set; }
        public int? IdCarga { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Status { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArViaticoMotivo
    {
        public int IdArViaticoMotivo { get; set; }
        public string NoAr { get; set; }
        public int IdSolicitudViatico { get; set; }
        public int IdMotivo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

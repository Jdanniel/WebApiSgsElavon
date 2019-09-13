using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdActasAdmin
    {
        public int IdActaAdmin { get; set; }
        public int? IdTipoActaAdmin { get; set; }
        public int? IdArea { get; set; }
        public int? IdResponsable { get; set; }
        public int? IdUsuarioActa { get; set; }
        public string Comentarios { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string StatusActaAdmin { get; set; }
    }
}

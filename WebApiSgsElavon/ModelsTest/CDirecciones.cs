using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CDirecciones
    {
        public int IdDirecciones { get; set; }
        public string DescDireccion { get; set; }
        public int? IdDireccionesJefe { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

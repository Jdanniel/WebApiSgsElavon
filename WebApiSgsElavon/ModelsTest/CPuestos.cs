using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CPuestos
    {
        public int IdPuesto { get; set; }
        public string DescPuesto { get; set; }
        public string Status { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IsResponsable { get; set; }
    }
}

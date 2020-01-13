using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CConectividad
    {
        public int IdConectividad { get; set; }
        public string DescConectividad { get; set; }
        public string Descripcion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdProducto { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int IsGprs { get; set; }
        public int? IsConjunto { get; set; }
    }
}

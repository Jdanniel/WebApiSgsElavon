using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdModeloSparePart
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public int IdProductoSparePart { get; set; }
        public int IdMarcaSparePart { get; set; }
        public int IdSparePart { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

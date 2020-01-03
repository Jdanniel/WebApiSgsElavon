using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArSegmento
    {
        public int IdArSegmento { get; set; }
        public int IdAr { get; set; }
        public int IdSegmentoElavon { get; set; }
        public DateTime FecAlta { get; set; }
        public int IdUsuarioAlta { get; set; }
    }
}

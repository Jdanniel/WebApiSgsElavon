using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CSegmentosElavon
    {
        public int IdSegmentoElavon { get; set; }
        public string DescSegmentoElavon { get; set; }
        public string Status { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }
    }
}

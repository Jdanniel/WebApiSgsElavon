using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdUniversoUnidades
    {
        public int IdUniversoUnidades { get; set; }
        public string NoSerie { get; set; }
        public string MinorCategory { get; set; }
        public string AssetNumber { get; set; }
        public string MajorCategory { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuario { get; set; }
        public string Status { get; set; }
    }
}

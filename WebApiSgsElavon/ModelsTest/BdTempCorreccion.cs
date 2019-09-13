using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdTempCorreccion
    {
        public int IdTempCorreccion { get; set; }
        public int? IdUnidad { get; set; }
        public string NoSerieOk { get; set; }
        public string NoSerieMal { get; set; }
        public string NoAfiliacion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdNegocio { get; set; }
        public string DescNegocio { get; set; }
    }
}

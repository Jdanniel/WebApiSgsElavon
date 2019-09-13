using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CUpdateTablasBb
    {
        public int IdUpdateTablasBb { get; set; }
        public string TablaUpdate { get; set; }
        public string DescTablaUpdate { get; set; }
        public DateTime FecAlta { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime? FecUpdate { get; set; }
        public int? IdUsuarioUpdate { get; set; }
        public string Status { get; set; }
    }
}

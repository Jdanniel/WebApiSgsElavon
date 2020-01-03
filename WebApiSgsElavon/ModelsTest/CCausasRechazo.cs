using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CCausasRechazo
    {
        public int IdCausaRechazo { get; set; }
        public string DescCausaRechazo { get; set; }
        public string Descripcion { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string StatusReasonCode { get; set; }
        public int IdTrechazo { get; set; }
    }
}

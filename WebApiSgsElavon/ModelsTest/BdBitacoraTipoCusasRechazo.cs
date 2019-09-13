using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraTipoCusasRechazo
    {
        public int IdBitacoraTipoCusasRechazo { get; set; }
        public int? IdCausaRechazo { get; set; }
        public string DescCausaRechazoAnterior { get; set; }
        public string DescCausaRechazoActual { get; set; }
        public string StatusAnterior { get; set; }
        public string StatusActual { get; set; }
        public string IdTrechazoAnterior { get; set; }
        public string IdTrechazoActual { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? UsuariosAlta { get; set; }
    }
}

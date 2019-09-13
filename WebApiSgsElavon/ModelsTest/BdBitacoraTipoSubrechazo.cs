using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraTipoSubrechazo
    {
        public int IdBitacoraTipoSubrechazo { get; set; }
        public int? IdSubrechazo { get; set; }
        public string SubrechazoAnterior { get; set; }
        public string SubrechazoActual { get; set; }
        public string StatusAnterior { get; set; }
        public string StatusActual { get; set; }
        public string IdAnterior { get; set; }
        public string IdActual { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? UsuariosAlta { get; set; }
    }
}

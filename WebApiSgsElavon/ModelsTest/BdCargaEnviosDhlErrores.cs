using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCargaEnviosDhlErrores
    {
        public int IdCargaEnvioDhlError { get; set; }
        public int? IdCargaEnvioDhl { get; set; }
        public string NoGuia { get; set; }
        public string Error { get; set; }
    }
}

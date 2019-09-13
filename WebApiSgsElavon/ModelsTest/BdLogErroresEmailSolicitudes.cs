using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdLogErroresEmailSolicitudes
    {
        public int IdLogErrorEmail { get; set; }
        public string DescripcionError { get; set; }
        public string Modulo { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}

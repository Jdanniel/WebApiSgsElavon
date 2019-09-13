using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCallCenterSeguimiento
    {
        public int IdCallCenter { get; set; }
        public int? IdAgente { get; set; }
        public int? IdAr { get; set; }
        public string Contacto { get; set; }
        public int? Exito { get; set; }
        public int? IdMotivoNoContacto { get; set; }
        public int? Intento { get; set; }
        public int? IdMotivoRechazo { get; set; }
        public string AceptaServicio { get; set; }
    }
}

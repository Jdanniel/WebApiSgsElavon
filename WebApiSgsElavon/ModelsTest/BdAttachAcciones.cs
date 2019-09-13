using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdAttachAcciones
    {
        public int IdAttachAcciones { get; set; }
        public int? IdTipoArchivo { get; set; }
        public int? IdCompromisosAcciones { get; set; }
        public string DescAttach { get; set; }
        public string SystemFilename { get; set; }
        public string UserFilename { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string Status { get; set; }
    }
}

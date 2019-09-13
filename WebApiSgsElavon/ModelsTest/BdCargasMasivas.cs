using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCargasMasivas
    {
        public int IdCargaMasiva { get; set; }
        public string DescAttach { get; set; }
        public int? IdArchivoAttach { get; set; }
        public DateTime? FechaCarga { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string Status { get; set; }
    }
}

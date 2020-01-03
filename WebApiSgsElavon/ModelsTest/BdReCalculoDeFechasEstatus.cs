using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReCalculoDeFechasEstatus
    {
        public int IdReCalculoDeFechasEstatus { get; set; }
        public string Odt { get; set; }
        public DateTime? FecAtencion { get; set; }
        public DateTime? FecGarantia { get; set; }
        public int? IdProveedor { get; set; }
        public int? IdStatusAr { get; set; }
        public string Status { get; set; }
        public int? IdCarga { get; set; }
        public string DescError { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

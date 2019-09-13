using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraCambioFecGarantia
    {
        public int IdBitacoraCambioFecGarantia { get; set; }
        public int? IdAr { get; set; }
        public DateTime? FecGarantiaAnterior { get; set; }
        public DateTime? FecGarantiaActual { get; set; }
        public DateTime? FecAtencionAnterior { get; set; }
        public DateTime? FecAtencionActual { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

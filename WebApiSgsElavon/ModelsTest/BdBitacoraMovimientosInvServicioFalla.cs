using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraMovimientosInvServicioFalla
    {
        public int IdBitacoraMovimientosInvServicioFalla { get; set; }
        public int? IdServicioAnterior { get; set; }
        public int? IdServicioActual { get; set; }
        public int? IdFallaAnterior { get; set; }
        public int? IdFallaActual { get; set; }
        public int? IdMovInventarioAnterior { get; set; }
        public int? IdMovInventarioActual { get; set; }
        public string StatusAnterior { get; set; }
        public string StatusActual { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdValMovimientosInvServicioFalla { get; set; }
    }
}

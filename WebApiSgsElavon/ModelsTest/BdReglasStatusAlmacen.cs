using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReglasStatusAlmacen
    {
        public int IdReglasStatusAlmacen { get; set; }
        public int? IdCliente { get; set; }
        public int? IdStatusSolicitudAlmacen { get; set; }
        public int? Minutos { get; set; }
        public int? IdOperador { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string ColorRgb { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraItemsBorrados
    {
        public int IdBitacoraItemsBorrados { get; set; }
        public int? IdSolicitudAlmacen { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdInsumo { get; set; }
        public int? Cantidad { get; set; }
        public int? IdStatusItemsSolicitudAlmacen { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}

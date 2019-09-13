using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdItemsSolicitudAlmacen
    {
        public int IdItemsSolicitudAlmacen { get; set; }
        public int IdSolicitudAlmacen { get; set; }
        public int IdTipoItemSolicitudAlmacen { get; set; }
        public int IdCliente { get; set; }
        public int? IdMarca { get; set; }
        public int? IdModelo { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdSparePart { get; set; }
        public int CantidadItems { get; set; }
        public string Notas { get; set; }
        public int? IdStatusItemsSolicitudAlmacen { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }
        public int? IsSurtido { get; set; }
        public int? IsEmbarque { get; set; }
        public int? IdUnidad { get; set; }
        public string Status { get; set; }
        public int? IdSoftware { get; set; }
        public int? IdConectividad { get; set; }
        public int? IdKitInsumo { get; set; }
        public int? IdParentInsumo { get; set; }
    }
}

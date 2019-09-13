using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoItemSolicitudAlmacen
    {
        public int IdTipoItemSolicitudAlmacen { get; set; }
        public string DescTipoItemSolicitudAlmacen { get; set; }
        public int? IdTipoProducto { get; set; }
        public int? IdStatusArNew { get; set; }
        public int? IsIndividuallyControlled { get; set; }
        public int? IsUnidadGrupoClientes { get; set; }
        public string Status { get; set; }
    }
}

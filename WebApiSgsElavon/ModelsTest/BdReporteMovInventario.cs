using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReporteMovInventario
    {
        public int IdBdReporteMovInventario { get; set; }
        public int IdReporteMovInventario { get; set; }
        public int? IdCliente { get; set; }
        public int? IdAlmacen { get; set; }
        public int? IdModelo { get; set; }
        public string DiaSemana { get; set; }
        public int? UInvLab { get; set; }
        public int? UDispInicioDia { get; set; }
        public int? UEntradasDia { get; set; }
        public int? UEntradasLab { get; set; }
        public int? USalInst { get; set; }
        public int? USalManto { get; set; }
        public int? USalLab { get; set; }

        public virtual CReporteMovInventario IdReporteMovInventarioNavigation { get; set; }
    }
}

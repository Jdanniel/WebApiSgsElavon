using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdBitacoraInsumos
    {
        public int IdBitacoraInsumo { get; set; }
        public int IdInsumo { get; set; }
        public int? IdStatusInsumoIni { get; set; }
        public int? IdStatusInsumoFin { get; set; }
        public int? IdTipoResponsable { get; set; }
        public int? IdResponsable { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CStatusInsumos IdStatusInsumoFinNavigation { get; set; }
        public virtual CStatusInsumos IdStatusInsumoIniNavigation { get; set; }
        public virtual CTipoResponsable IdTipoResponsableNavigation { get; set; }
    }
}

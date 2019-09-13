using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CInsumosOld
    {
        public CInsumosOld()
        {
            BdModeloInsumo = new HashSet<BdModeloInsumo>();
        }

        public int IdInsumo { get; set; }
        public string DescInsumo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Precio { get; set; }
        public int? IdCliente { get; set; }
        public int? IdTipoInsumo { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CTipoInsumo IdTipoInsumoNavigation { get; set; }
        public virtual ICollection<BdModeloInsumo> BdModeloInsumo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdModeloInsumo
    {
        public int IdModeloInsumo { get; set; }
        public int? IdModelo { get; set; }
        public int? IdInsumo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CInsumosOld IdInsumoNavigation { get; set; }
        public virtual CModelos IdModeloNavigation { get; set; }
    }
}

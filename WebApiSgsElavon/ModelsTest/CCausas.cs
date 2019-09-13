using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CCausas
    {
        public CCausas()
        {
            BdServicioCausa = new HashSet<BdServicioCausa>();
        }

        public int IdCausa { get; set; }
        public string DescCausa { get; set; }
        public string Descripcion { get; set; }
        public int? IdCliente { get; set; }
        public string Clave { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual ICollection<BdServicioCausa> BdServicioCausa { get; set; }
    }
}

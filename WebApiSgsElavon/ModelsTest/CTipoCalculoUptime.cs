using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoCalculoUptime
    {
        public CTipoCalculoUptime()
        {
            CClientes = new HashSet<CClientes>();
        }

        public int IdTipoCalculoUptime { get; set; }
        public string DescTipoCalculoUptime { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CClientes> CClientes { get; set; }
    }
}

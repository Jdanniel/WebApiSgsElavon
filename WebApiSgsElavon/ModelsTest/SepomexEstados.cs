using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class SepomexEstados
    {
        public SepomexEstados()
        {
            BdClaveEstado = new HashSet<BdClaveEstado>();
            BdNegocios = new HashSet<BdNegocios>();
        }

        public int IdEstado { get; set; }
        public string Estado { get; set; }
        public string Status { get; set; }
        public string Abreviatura { get; set; }

        public virtual ICollection<BdClaveEstado> BdClaveEstado { get; set; }
        public virtual ICollection<BdNegocios> BdNegocios { get; set; }
    }
}

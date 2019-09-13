using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTipoPlaza
    {
        public CTipoPlaza()
        {
            CPlazas = new HashSet<CPlazas>();
        }

        public int IdTipoPlaza { get; set; }
        public string DescTipoPlaza { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CPlazas> CPlazas { get; set; }
    }
}

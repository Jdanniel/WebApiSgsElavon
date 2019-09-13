using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class COperadores
    {
        public COperadores()
        {
            BdReglasStatusAr = new HashSet<BdReglasStatusAr>();
        }

        public int IdOperador { get; set; }
        public string DescOperador { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdReglasStatusAr> BdReglasStatusAr { get; set; }
    }
}

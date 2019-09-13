using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CTiempoReferencia
    {
        public CTiempoReferencia()
        {
            BdReglasStatusAr = new HashSet<BdReglasStatusAr>();
        }

        public int IdTiempoReferencia { get; set; }
        public string DescTiempoReferencia { get; set; }
        public string Descripcion { get; set; }
        public int? Factor { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BdReglasStatusAr> BdReglasStatusAr { get; set; }
    }
}

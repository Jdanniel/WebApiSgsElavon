using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CAccesorios
    {
        public CAccesorios()
        {
            BdModeloAccesorio = new HashSet<BdModeloAccesorio>();
            BdUnidadAccesorio = new HashSet<BdUnidadAccesorio>();
        }

        public int IdAccesorio { get; set; }
        public string DescAccesorio { get; set; }
        public string Descripcion { get; set; }
        public decimal? Costo { get; set; }
        public int? IdProducto { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual ICollection<BdModeloAccesorio> BdModeloAccesorio { get; set; }
        public virtual ICollection<BdUnidadAccesorio> BdUnidadAccesorio { get; set; }
    }
}

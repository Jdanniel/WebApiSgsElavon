using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CMonedas
    {
        public CMonedas()
        {
            BdModeloPrecio = new HashSet<BdModeloPrecio>();
            BdSparePartPrecio = new HashSet<BdSparePartPrecio>();
            CModelos = new HashSet<CModelos>();
            CServicios = new HashSet<CServicios>();
        }

        public int IdMoneda { get; set; }
        public string DescMoneda { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual ICollection<BdModeloPrecio> BdModeloPrecio { get; set; }
        public virtual ICollection<BdSparePartPrecio> BdSparePartPrecio { get; set; }
        public virtual ICollection<CModelos> CModelos { get; set; }
        public virtual ICollection<CServicios> CServicios { get; set; }
    }
}

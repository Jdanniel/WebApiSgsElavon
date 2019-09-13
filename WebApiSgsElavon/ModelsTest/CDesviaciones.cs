using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CDesviaciones
    {
        public CDesviaciones()
        {
            BdArDesviacion = new HashSet<BdArDesviacion>();
        }

        public int IdDesviacion { get; set; }
        public string DescDesviacion { get; set; }
        public string Descripcion { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IsDesviacionTemp { get; set; }
        public int? IdResponsable { get; set; }
        public int? IsAdministradorLogistico { get; set; }
        public int? IsLaboratorio { get; set; }

        public virtual ICollection<BdArDesviacion> BdArDesviacion { get; set; }
    }
}

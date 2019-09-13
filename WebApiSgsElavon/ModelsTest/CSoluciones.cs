using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CSoluciones
    {
        public CSoluciones()
        {
            BdServicioSolucion = new HashSet<BdServicioSolucion>();
        }

        public int IdSolucion { get; set; }
        public string DescSolucion { get; set; }
        public string Descripcion { get; set; }
        public int? IdCliente { get; set; }
        public string Clave { get; set; }
        public int? IsExito { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual ICollection<BdServicioSolucion> BdServicioSolucion { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CServicioMensajeria
    {
        public CServicioMensajeria()
        {
            BdEnvios = new HashSet<BdEnvios>();
        }

        public int IdServicioMensajeria { get; set; }
        public string DescServicioMensajeria { get; set; }
        public string Descripcion { get; set; }
        public int? IsInterno { get; set; }
        public string PaginaWeb { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IsCamion { get; set; }

        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
    }
}

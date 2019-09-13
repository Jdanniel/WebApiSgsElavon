using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CPlazas
    {
        public CPlazas()
        {
            BdPlazaCp = new HashSet<BdPlazaCp>();
        }

        public int IdPlaza { get; set; }
        public string DescPlaza { get; set; }
        public int? IdTipoPlaza { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CTipoPlaza IdTipoPlazaNavigation { get; set; }
        public virtual ICollection<BdPlazaCp> BdPlazaCp { get; set; }
    }
}

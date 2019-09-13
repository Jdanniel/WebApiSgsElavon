using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CResponsablesAgendados
    {
        public CResponsablesAgendados()
        {
            BdBitacoraAgendados = new HashSet<BdBitacoraAgendados>();
        }

        public int IdResponsableAgendado { get; set; }
        public string DescResponsableAgendado { get; set; }
        public string Descripcion { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual ICollection<BdBitacoraAgendados> BdBitacoraAgendados { get; set; }
    }
}

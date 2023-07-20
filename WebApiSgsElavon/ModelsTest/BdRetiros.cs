using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdRetiros
    {
        public int IdRetiro { get; set; }
        public int IdAr { get; set; }
        public int IdNegocio { get; set; }
        public int? IdTecnico { get; set; }
        public int IdUnidad { get; set; }
        public int? IsNueva { get; set; }
        public int? IsDaniada { get; set; }
        public int? IdParent { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IdConectividad { get; set; }
        public int? IdAplicativo { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Tipo { get; set; }

        public virtual BdNegocios IdNegocioNavigation { get; set; }
        public virtual BdUnidades IdParentNavigation { get; set; }
        public virtual CUsuarios IdTecnicoNavigation { get; set; }
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

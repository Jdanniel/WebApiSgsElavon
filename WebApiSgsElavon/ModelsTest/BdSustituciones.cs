using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdSustituciones
    {
        public int IdSustitucion { get; set; }
        public int IdAr { get; set; }
        public int IdNegocio { get; set; }
        public int? IdTecnico { get; set; }
        public int? IdParent { get; set; }
        public int IdUnidadEntrada { get; set; }
        public string NoEquipoEntrada { get; set; }
        public int IdUnidadSalida { get; set; }
        public string NoEquipoSalida { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual BdNegocios IdNegocioNavigation { get; set; }
        public virtual CUsuarios IdTecnicoNavigation { get; set; }
        public virtual BdUnidades IdUnidadEntradaNavigation { get; set; }
        public virtual BdUnidades IdUnidadSalidaNavigation { get; set; }
    }
}

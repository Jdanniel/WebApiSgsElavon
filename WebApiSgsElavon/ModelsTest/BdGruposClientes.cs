using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdGruposClientes
    {
        public int IdGrupoCliente { get; set; }
        public int? IdGrupo { get; set; }
        public int? IdCliente { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CClientes IdClienteNavigation { get; set; }
        public virtual CGrupos IdGrupoNavigation { get; set; }
    }
}

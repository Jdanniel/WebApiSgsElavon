using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdModeloModulo
    {
        public int Id { get; set; }
        public int IdModelo { get; set; }
        public int IdProductoModulo { get; set; }
        public int IdMarcaModulo { get; set; }
        public int IdModeloModulo { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CMarcas IdMarcaModuloNavigation { get; set; }
        public virtual CModelos IdModeloModuloNavigation { get; set; }
        public virtual CModelos IdModeloNavigation { get; set; }
        public virtual CProductos IdProductoModuloNavigation { get; set; }
    }
}

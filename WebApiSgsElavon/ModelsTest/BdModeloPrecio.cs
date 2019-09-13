using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdModeloPrecio
    {
        public int IdModeloPrecio { get; set; }
        public int IdModelo { get; set; }
        public int IdCliente { get; set; }
        public int? IdMoneda { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CClientes IdClienteNavigation { get; set; }
        public virtual CModelos IdModeloNavigation { get; set; }
        public virtual CMonedas IdMonedaNavigation { get; set; }
    }
}

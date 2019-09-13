using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdDevoluciones
    {
        public int IdDevolucion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdUnidad { get; set; }
        public string NoSerie { get; set; }
        public int? IdRazonDevolucion { get; set; }
        public string DescEncargadoRecepcion { get; set; }
        public string DescLugarRecepcion { get; set; }
        public DateTime? FecDevolucion { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CClientes IdClienteNavigation { get; set; }
        public virtual CRazonDevolucion IdRazonDevolucionNavigation { get; set; }
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

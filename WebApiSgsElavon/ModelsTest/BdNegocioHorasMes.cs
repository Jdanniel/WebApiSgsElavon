using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdNegocioHorasMes
    {
        public int IdNegocioHorasMes { get; set; }
        public int IdNegocio { get; set; }
        public int IdCliente { get; set; }
        public int IdHorario { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int HorasMes { get; set; }
        public int? IsContract { get; set; }
        public DateTime? FecAlta { get; set; }

        public virtual CClientes IdClienteNavigation { get; set; }
        public virtual BdNegocios IdNegocioNavigation { get; set; }
    }
}

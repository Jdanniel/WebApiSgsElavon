using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.ModelsTest
{
    public class BdDatosCierreAplicacion
    {
        public int IdDatoCierreAplicacion { get; set; }
        public string Datos { get; set; }
        public string TipoCierre { get; set; }
        public DateTime FechaCarga { get; set; }
        public int IdUsuario { get; set; }
        public int IdAr { get; set; }
    }
}

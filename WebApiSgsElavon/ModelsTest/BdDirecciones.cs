using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdDirecciones
    {
        public BdDirecciones()
        {
            BdEnvios = new HashSet<BdEnvios>();
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
        }

        public int IdDireccion { get; set; }
        public string Direccion { get; set; }
        public string DireccionAbreviada { get; set; }
        public string Colonia { get; set; }
        public string Poblacion { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public string Telefono { get; set; }
        public int IdTipoResponsable { get; set; }
        public int IdResponsable { get; set; }
        public int IsDefault { get; set; }
        public string Status { get; set; }
        public DateTime FecAlta { get; set; }
        public int IdUsuarioAlta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
    }
}

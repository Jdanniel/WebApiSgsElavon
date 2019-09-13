using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CProyectosEspeciales
    {
        public int IdProyectoEspecial { get; set; }
        public string DescProyectoEspecial { get; set; }
        public int? Status { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuario { get; set; }
        public int? CallCenter { get; set; }
        public int? CargaMasiva { get; set; }
        public int? InterfaseOnbase { get; set; }
        public int? AplicaCierres { get; set; }
        public string AplicaBloqueCierre { get; set; }
    }
}

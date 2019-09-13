using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCursos
    {
        public int IdCursos { get; set; }
        public DateTime? FecInicio { get; set; }
        public DateTime? FecFin { get; set; }
        public int? IdCapacitador { get; set; }
        public int? IdStatusCurso { get; set; }
        public int? IdSedeCurso { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IdNombreCurso { get; set; }
        public string Descripcion { get; set; }
    }
}

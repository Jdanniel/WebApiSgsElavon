using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArDesviacion
    {
        public int IdArDesviacion { get; set; }
        public int? IdAr { get; set; }
        public int? IdDesviacion { get; set; }
        public int? IdTecnico { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Comentario { get; set; }
        public string Descripcion { get; set; }
        public int? HaveDescripcion { get; set; }

        public virtual CDesviaciones IdDesviacionNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdComentarioAr
    {
        public int IdComentarioAr { get; set; }
        public int IdAr { get; set; }
        public string DescComentarioAr { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdTarea { get; set; }
        public string NotifyBancomer { get; set; }
        public int? IdUsuarioOki { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CResponsables
    {
        public int IdResponsables { get; set; }
        public string DescResponsable { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
        public int? IsAlmacen { get; set; }
    }
}

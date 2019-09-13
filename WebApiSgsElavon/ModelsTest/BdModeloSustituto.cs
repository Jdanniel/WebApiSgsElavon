using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdModeloSustituto
    {
        public int Id { get; set; }
        public int? IdModelo { get; set; }
        public int? IdModeloSustituto { get; set; }
        public int? IdSoftware { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual CModelos IdModeloNavigation { get; set; }
        public virtual CModelos IdModeloSustitutoNavigation { get; set; }
        public virtual CSoftware IdSoftwareNavigation { get; set; }
    }
}

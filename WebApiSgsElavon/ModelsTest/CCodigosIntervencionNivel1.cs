using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CCodigosIntervencionNivel1
    {
        public int IdCodigoNivel1 { get; set; }
        public string ClaveCodigo { get; set; }
        public string DescCodigo { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
        public int? IdParentNivel0 { get; set; }

        public virtual CCodigosIntervencionNivel0 IdParentNivel0Navigation { get; set; }
    }
}

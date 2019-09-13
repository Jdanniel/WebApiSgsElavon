using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class CCodigosIntervencionNivel0
    {
        public CCodigosIntervencionNivel0()
        {
            CCodigosIntervencionNivel1 = new HashSet<CCodigosIntervencionNivel1>();
        }

        public int IdCodigoNivel0 { get; set; }
        public string ClaveCodigo { get; set; }
        public string DescCodigo { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
        public int? IdTipoMedida { get; set; }
        public int? ReportaInstalacion { get; set; }

        public virtual ICollection<CCodigosIntervencionNivel1> CCodigosIntervencionNivel1 { get; set; }
    }
}

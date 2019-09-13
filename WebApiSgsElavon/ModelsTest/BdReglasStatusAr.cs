using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReglasStatusAr
    {
        public int IdReglaStatusAr { get; set; }
        public int IdClienteProductoStatusAr { get; set; }
        public int Minutos { get; set; }
        public int IdOperador { get; set; }
        public int IdTiempoReferencia { get; set; }
        public int IdTiempoMedicion { get; set; }
        public int? Prioridad { get; set; }
        public string Status { get; set; }
        public DateTime FecAlta { get; set; }
        public int IdUsuarioAlta { get; set; }

        public virtual BdClienteProductoStatusAr IdClienteProductoStatusArNavigation { get; set; }
        public virtual COperadores IdOperadorNavigation { get; set; }
        public virtual CTiempoMedicion IdTiempoMedicionNavigation { get; set; }
        public virtual CTiempoReferencia IdTiempoReferenciaNavigation { get; set; }
    }
}

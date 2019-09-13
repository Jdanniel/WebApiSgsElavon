using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class ReporteHojaServicios
    {
        public int IdReporteHojaServicio { get; set; }
        public int? IdUnidad { get; set; }
        public string NoSerie { get; set; }
        public string Cliente { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string Nombre { get; set; }
        public int? Svc { get; set; }
        public string AbrevTecnico { get; set; }
        public string Accesorios { get; set; }
        public string Comentario { get; set; }
        public string FallaReport { get; set; }
        public string FolioTelmex { get; set; }
        public string EnviadoPor { get; set; }
        public string Empresa { get; set; }
        public string Observaciones { get; set; }
        public string Status { get; set; }
        public string NoReporte { get; set; }

        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdUnidadesReportadas
    {
        public int IdUnidadReportada { get; set; }
        public int? IdAuditoriaReporte { get; set; }
        public string NoSerieReportado { get; set; }
        public int? Existe { get; set; }
        public int? Pertenece { get; set; }
        public int? NoDiasTransito { get; set; }
        public string Descripcion { get; set; }
        public int? IdEnvio { get; set; }
        public string DestinoEnvio { get; set; }
        public string Guia { get; set; }
        public DateTime? FecEnvio { get; set; }
        public int? IdStatusSerie { get; set; }
        public DateTime? FecUltimoStatus { get; set; }
        public string Responsable { get; set; }
        public int? IsDuplicada { get; set; }

        public virtual BdAuditoriaReporte IdAuditoriaReporteNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdReingresoUnidad
    {
        public int IdReingresoUnidad { get; set; }
        public int IdUnidad { get; set; }
        public string NoSerieAnterior { get; set; }
        public string NoInventarioAnterior { get; set; }
        public string NoSimAnterior { get; set; }
        public string NoImeiAnterior { get; set; }
        public int? IsNuevaAnterior { get; set; }
        public int? IsDaniadaAnterior { get; set; }
        public int? IdClienteAnterior { get; set; }
        public int? IdStatusUnidadAnterior { get; set; }
        public int? IdTipoResponsableAnterior { get; set; }
        public int? IdResponsableAnterior { get; set; }
        public int? IdSolicitudRecoleccionAnterior { get; set; }
        public string NoSerieReingreso { get; set; }
        public string NoInventarioReingreso { get; set; }
        public string NoSimReingreso { get; set; }
        public string NoImeiReingreso { get; set; }
        public int? IsNuevaReingreso { get; set; }
        public int? IsDaniadaReingreso { get; set; }
        public int? IdClienteReingreso { get; set; }
        public int? IdStatusUnidadReingreso { get; set; }
        public int? IdTipoResponsableReingreso { get; set; }
        public int? IdResponsableReingreso { get; set; }
        public int? IdSolicitudRecoleccionReingreso { get; set; }
        public DateTime? FecReingreso { get; set; }
        public int? IdUsuarioReingreso { get; set; }
        public int? IdAplicativo { get; set; }
        public int? IdConectividad { get; set; }

        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionAnteriorNavigation { get; set; }
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionReingresoNavigation { get; set; }
        public virtual CStatusUnidad IdStatusUnidadAnteriorNavigation { get; set; }
        public virtual CStatusUnidad IdStatusUnidadReingresoNavigation { get; set; }
        public virtual CTipoResponsable IdTipoResponsableAnteriorNavigation { get; set; }
        public virtual CTipoResponsable IdTipoResponsableReingresoNavigation { get; set; }
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdCargaCierresMasivos
    {
        public int IdCierreMasivo { get; set; }
        public string IdProceso { get; set; }
        public string EstatusProceso { get; set; }
        public string FileName { get; set; }
        public string Ruta { get; set; }
        public DateTime? FechaCarga { get; set; }
        public int? IdUsuarioCarga { get; set; }
        public string Odt { get; set; }
        public string Tipo { get; set; }
        public string DayCierre { get; set; }
        public string MonthCierre { get; set; }
        public string YearCierre { get; set; }
        public string HourCierre { get; set; }
        public string MinuteCierre { get; set; }
        public string Atiende { get; set; }
        public string OtorgaVobo { get; set; }
        public string TipoAtencion { get; set; }
        public string Tecnico { get; set; }
        public string RollosInstalados { get; set; }
        public string Discover { get; set; }
        public string Caja { get; set; }
        public string Comentarios { get; set; }
        public string EstatusOdt { get; set; }
        public string IdCancelacion { get; set; }
        public string IdRechazo { get; set; }
        public string IdSubRechazo { get; set; }
        public string NoSerieInstalacion { get; set; }
        public string IdConectividadInstalacion { get; set; }
        public string IdAplicativoInstalacion { get; set; }
        public string VersionInstalacion { get; set; }
        public string SeDejaMismoSim { get; set; }
        public string SimInstalacion { get; set; }
        public string BateriaInstalacion { get; set; }
        public string EliminadorInstalacion { get; set; }
        public string TapaInstalacion { get; set; }
        public string CableAcInstalacion { get; set; }
        public string BaseInstalacion { get; set; }
        public string EsAmex { get; set; }
        public string IdAmex { get; set; }
        public string AfiliacionAmex { get; set; }
        public string ConclusionesAmex { get; set; }
        public string NoSerieRetiro { get; set; }
        public string IdMarcaRetiro { get; set; }
        public string IdModeloRetiro { get; set; }
        public string IdAplicativoRetiro { get; set; }
        public string IdConectiidadRetiro { get; set; }
        public string VersionRetiro { get; set; }
        public string NoSeRetiraSim { get; set; }
        public string SimRetiro { get; set; }
        public string BateriaRetiro { get; set; }
        public string EliminadorRetiro { get; set; }
        public string TapaRetiro { get; set; }
        public string CableAcRetiro { get; set; }
        public string BaseRetiro { get; set; }
        public string MensajeError { get; set; }
    }
}

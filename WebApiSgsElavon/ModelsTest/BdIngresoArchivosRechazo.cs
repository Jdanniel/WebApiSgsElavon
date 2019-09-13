using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdIngresoArchivosRechazo
    {
        public int IdArchivoMasivo { get; set; }
        public int? IdArchivo { get; set; }
        public int? IdAr { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdCausa { get; set; }
        public int? IdSolucion { get; set; }
        public string DescripcionTrabajo { get; set; }
        public string FolioServicio { get; set; }
        public string OtorganteVobo { get; set; }
        public DateTime? FecCierre { get; set; }
        public string HoraCierre { get; set; }
        public string MinutoCierre { get; set; }
        public string AutorizacionRechazo { get; set; }
        public int? IdCausaRechazo { get; set; }
        public int? IdEspecificaCausaRechazo { get; set; }
        public int? IsCobrable { get; set; }
        public decimal? Precio { get; set; }
        public string StatusArchivo { get; set; }
        public int? IdUsuarioAltaArchivo { get; set; }
        public DateTime? FechaAltaArchivo { get; set; }
        public string DescError { get; set; }
        public int? IsMov { get; set; }
        public string NoSerieEntrada { get; set; }
        public string NoSerieSalida { get; set; }
        public string StatusMov { get; set; }
        public string DescErrorMov { get; set; }
        public string NoEquipoMov { get; set; }
        public int? IsDaniada { get; set; }
    }
}

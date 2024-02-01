using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdIngresoArchivosExito
{
    public int IdArchivoMasivo { get; set; }

    public int? IdArchivo { get; set; }

    public int? IdAr { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdCausa { get; set; }

    public int? IdSolucion { get; set; }

    public string DescripcionTrabajo { get; set; }

    public string Atiende { get; set; }

    public DateTime? FecCierre { get; set; }

    public string HoraCierre { get; set; }

    public string MinutoCierre { get; set; }

    public string FolioTas { get; set; }

    public string CodigoIntervencion { get; set; }

    public string OtorganteTas { get; set; }

    public string NoEquipo { get; set; }

    public string NoSerieFalla { get; set; }

    public string NoInventarioFalla { get; set; }

    public int? IdModeloFalla { get; set; }

    public DateTime? FecLlegada { get; set; }

    public string HoraLlegada { get; set; }

    public string MinutoLlegada { get; set; }

    public DateTime? FecLlegadaTerceros { get; set; }

    public string HoraLlegadaTerceros { get; set; }

    public string MinutoLlegadaTercero { get; set; }

    public string FolioServicio { get; set; }

    public DateTime? FecIniIngeniero { get; set; }

    public string HoraIniIngeniero { get; set; }

    public string MinutoIniIngeniero { get; set; }

    public DateTime? FecFinIngeniero { get; set; }

    public string HoraFinIngeniero { get; set; }

    public string MinutoFinIngeniero { get; set; }

    public string OtorganteVobo { get; set; }

    public string OtorganteVoboTerceros { get; set; }

    public string IntensidadSenial { get; set; }

    public int? IsSimRemplazada { get; set; }

    public string DigitoVerificador { get; set; }

    public int? IdTipoFallaEncontrada { get; set; }

    public int? IdEspecifTipoFalla { get; set; }

    public string FallaEncontrada { get; set; }

    public string OtorganteVoboCliente { get; set; }

    public string VoltajeNeutro { get; set; }

    public string VoltajeTierra { get; set; }

    public string VoltajeTierraNeutro { get; set; }

    public string FolioValidacion { get; set; }

    public string FolioTir { get; set; }

    public string MotivoCobro { get; set; }

    public int? IsSoporteCliente { get; set; }

    public int? IsBoletin { get; set; }

    public string OtorganteSoporteCliente { get; set; }

    public int? IsCobrable { get; set; }

    public decimal? Precio { get; set; }

    public string CadenaCierreEscrita { get; set; }

    public string InstalacionLlaves { get; set; }

    public string TipoLlave { get; set; }

    public string StatusInstalacionLlaves { get; set; }

    public string NombrePersonaLlavesA { get; set; }

    public string NombrePersonaLlavesB { get; set; }

    public string TipoPw { get; set; }

    public string TipoTeclado { get; set; }

    public string VersionTecladoEpp { get; set; }

    public string Procesador { get; set; }

    public string VelocidadProcesador { get; set; }

    public string Memoria { get; set; }

    public string CapacidadDiscoDuro { get; set; }

    public string Monitor { get; set; }

    public string LectorTarjeta { get; set; }

    public string Aplicacion { get; set; }

    public string Version { get; set; }

    public string Caja { get; set; }

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

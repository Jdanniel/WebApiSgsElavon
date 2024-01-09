using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class OdtTemporal
{
    public int IdAr { get; set; }

    public int IdCarga { get; set; }

    public int IdCliente { get; set; }

    public string NoAr { get; set; }

    public string Concepto { get; set; }

    public string DescCorta { get; set; }

    public string Sintoma { get; set; }

    public string Bitacora { get; set; }

    public string NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string DescNegocio { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public string NotasRemedy { get; set; }

    public string Equipo { get; set; }

    public string DescEquipo { get; set; }

    public int? Segmento { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime? FecConvenio { get; set; }

    public int TipoServicio { get; set; }

    public int TipoFalla { get; set; }

    public int? IdSegmento { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? HorasGarantia { get; set; }

    public decimal? PrecioExito { get; set; }

    public decimal? Precio { get; set; }

    public int? IdNegocio { get; set; }

    public int? IdEstado { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdTipoPlaza { get; set; }

    public int? IdPlaza { get; set; }

    public int? IdTecnico { get; set; }

    public int? IsTecnicoForaneo { get; set; }

    public int? IsDuplicada { get; set; }

    public int? IsIngresoManual { get; set; }

    public int? IsActualizacion { get; set; }

    public int? IsInstalacion { get; set; }

    public int? IsSustitucion { get; set; }

    public int? IsRetiro { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime? FecAtencion { get; set; }

    public DateTime? FecGarantia { get; set; }

    public DateTime? FecCierre { get; set; }

    public int? IsGarantia { get; set; }

    public int? HorasAtencion { get; set; }

    public DateTime? FecAltaHorasAtencion { get; set; }

    public int? MinsDowntime { get; set; }

    public int? IdUsuarioCierre { get; set; }

    public int? IdCausa { get; set; }

    public int? IdSolucion { get; set; }

    public string FolioTas { get; set; }

    public string OtorganteTas { get; set; }

    public string NoEquipo { get; set; }

    public DateTime? FecLlegada { get; set; }

    public DateTime? FecLlegadaTerceros { get; set; }

    public string FolioServicio { get; set; }

    public DateTime? FecIniIngeniero { get; set; }

    public DateTime? FecFinIngeniero { get; set; }

    public string OtorganteVobo { get; set; }

    public string OtorganteVoboTerceros { get; set; }

    public string IntensidadSenial { get; set; }

    public int? IsSimRemplazada { get; set; }

    public string FallaEncontrada { get; set; }

    public string OtorganteVoboCliente { get; set; }

    public string MotivoCobro { get; set; }

    public int? IsSoporteCliente { get; set; }

    public int? IsBoletin { get; set; }

    public string OtorganteSoporteCliente { get; set; }

    public string DescripcionTrabajo { get; set; }

    public string Atiende { get; set; }

    public string AutorizadorRechazo { get; set; }

    public int? IdCausaRechazo { get; set; }

    public string CausaRechazo { get; set; }

    public string CausaCancelacion { get; set; }

    public string NoSerieFalla { get; set; }

    public string NoInventarioFalla { get; set; }

    public int? IdModeloFalla { get; set; }

    public int? IsExito { get; set; }

    public int? IdAttach1 { get; set; }

    public int? IdAttach2 { get; set; }

    public int? IdReporteCierre { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdModeloReq { get; set; }

    public int? IdProducto { get; set; }

    public int? IdTipoServicio { get; set; }

    public int? IdTipoPrecio { get; set; }

    public int? IdMoneda { get; set; }

    public int? IdTipoCobro { get; set; }

    public int? IsCobrable { get; set; }

    public int? IdUnidadAtendida { get; set; }

    public int? IdReglaStatusAr { get; set; }

    public DateTime? FecAltaReglaStatusAr { get; set; }

    public int? IdStatusAr { get; set; }

    public DateTime? FecStatusAr { get; set; }

    public string CadenaCierreEscrita { get; set; }

    public string CodigoIntervencion { get; set; }

    public int? IdTipoFallaEncontrada { get; set; }

    public int? IsRetipificado { get; set; }

    public string MotivoRetipificado { get; set; }

    public int? IsFollowDispatch { get; set; }

    public int? IdDispatcher { get; set; }

    public string DigitoVerificador { get; set; }

    public int? NoReincidencias { get; set; }

    public int? IsProgramado { get; set; }

    public int? NoDiasLiberacion { get; set; }

    public int? IdResponsableCancelacionProgramado { get; set; }

    public int? Insumos { get; set; }

    public string Responsable { get; set; }

    public string Caja { get; set; }

    public string Status { get; set; }

    public int? IdEspecifTipoFalla { get; set; }

    public string VoltajeNeutro { get; set; }

    public string VoltajeTierra { get; set; }

    public string VoltajeTierraNeutro { get; set; }

    public string FolioValidacion { get; set; }

    public string FolioTir { get; set; }

    public int? IdEspecificaCausaRechazo { get; set; }

    public int? Duracion { get; set; }

    public int? Traslado { get; set; }

    public int? IdStatusValidacionPrefacturacion { get; set; }

    public int? IdDescripcionTrabajo { get; set; }

    public int? IdStatusReasonCodes { get; set; }

    public string DueBy { get; set; }

    public string CadenaCierre { get; set; }

    public string NoSim { get; set; }

    public string ClaveRechazo { get; set; }

    public int? IsInterfazBancomer { get; set; }

    public int? IdConcepto { get; set; }

    public int? IdEquipoCliente { get; set; }

    public int? NotViaticos { get; set; }

    public int? IsLocal { get; set; }

    public DateTime? FecCarga { get; set; }

    public DateTime? FecAtencionOriginal { get; set; }

    public decimal? HorasGarantiaWincor { get; set; }

    public decimal? HorasAtencionWincor { get; set; }

    public int? IsPdf { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdAplicativo { get; set; }

    public int? IntentoContacto { get; set; }

    public int? IdCalificaContacto { get; set; }

    public DateTime? FecIntento1 { get; set; }

    public DateTime? FecIntento2 { get; set; }

    public DateTime? FecIntento3 { get; set; }

    public DateTime? FecIntento4 { get; set; }

    public int? IdCalificaIntento1 { get; set; }

    public int? IdCalificaIntento2 { get; set; }

    public int? IdCalificaIntento3 { get; set; }

    public int? IdCalificaIntento4 { get; set; }

    public int? FolioTelecarga { get; set; }

    public int? IdTipoEquipo { get; set; }

    public string CorreoEjecutivo { get; set; }

    public string TelefonoComercio { get; set; }

    public string PersonaAtenderaComercio { get; set; }

    public string ProveedorAtenderaComercio { get; set; }

    public TimeOnly? HoraAtencionIni { get; set; }

    public TimeOnly? HoraAtencionFin { get; set; }

    public int? TerminalAmex { get; set; }

    public int? AgregarDiasAtencion { get; set; }

    public string DireccionAlternaComercio { get; set; }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR")]
    public partial class BdAr
    {
        [Key]
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("ID_CARGA")]
        public int IdCarga { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("NO_AR")]
        [StringLength(50)]
        public string NoAr { get; set; }
        [Column("CONCEPTO")]
        [StringLength(255)]
        public string Concepto { get; set; }
        [Column("DESC_CORTA")]
        [StringLength(255)]
        public string DescCorta { get; set; }
        [Column("SINTOMA")]
        [StringLength(4000)]
        public string Sintoma { get; set; }
        [Column("BITACORA")]
        [StringLength(4000)]
        public string Bitacora { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("TELEFONO")]
        [StringLength(50)]
        public string Telefono { get; set; }
        [Column("DESC_NEGOCIO")]
        [StringLength(255)]
        public string DescNegocio { get; set; }
        [Column("DIRECCION")]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Column("COLONIA")]
        [StringLength(255)]
        public string Colonia { get; set; }
        [Column("POBLACION")]
        [StringLength(255)]
        public string Poblacion { get; set; }
        [Column("ESTADO")]
        [StringLength(255)]
        public string Estado { get; set; }
        [Column("CP")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Column("NOTAS_REMEDY")]
        [StringLength(255)]
        public string NotasRemedy { get; set; }
        [Column("EQUIPO")]
        [StringLength(50)]
        public string Equipo { get; set; }
        [Column("DESC_EQUIPO")]
        [StringLength(255)]
        public string DescEquipo { get; set; }
        [Column("SEGMENTO")]
        public int? Segmento { get; set; }
        [Column("NO_SERIE")]
        [StringLength(50)]
        public string NoSerie { get; set; }
        [Column("NO_INVENTARIO")]
        [StringLength(50)]
        public string NoInventario { get; set; }
        [Column("FEC_INICIO", TypeName = "smalldatetime")]
        public DateTime FecInicio { get; set; }
        [Column("FEC_CONVENIO", TypeName = "smalldatetime")]
        public DateTime? FecConvenio { get; set; }
        [Column("TIPO_SERVICIO")]
        public int TipoServicio { get; set; }
        [Column("TIPO_FALLA")]
        public int TipoFalla { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("HORAS_GARANTIA")]
        public int? HorasGarantia { get; set; }
        [Column("PRECIO_EXITO", TypeName = "numeric(18, 2)")]
        public decimal? PrecioExito { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("ID_NEGOCIO")]
        public int IdNegocio { get; set; }
        [Column("ID_ESTADO")]
        public int IdEstado { get; set; }
        [Column("ID_REGION")]
        public int IdRegion { get; set; }
        [Column("ID_ZONA")]
        public int IdZona { get; set; }
        [Column("ID_TIPO_PLAZA")]
        public int? IdTipoPlaza { get; set; }
        [Column("ID_PLAZA")]
        public int? IdPlaza { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("IS_TECNICO_FORANEO")]
        public int? IsTecnicoForaneo { get; set; }
        [Column("IS_DUPLICADA")]
        public int? IsDuplicada { get; set; }
        [Column("IS_INGRESO_MANUAL")]
        public int? IsIngresoManual { get; set; }
        [Column("IS_ACTUALIZACION")]
        public int? IsActualizacion { get; set; }
        [Column("IS_INSTALACION")]
        public int? IsInstalacion { get; set; }
        [Column("IS_SUSTITUCION")]
        public int? IsSustitucion { get; set; }
        [Column("IS_RETIRO")]
        public int? IsRetiro { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("FEC_ATENCION", TypeName = "smalldatetime")]
        public DateTime? FecAtencion { get; set; }
        [Column("FEC_GARANTIA", TypeName = "smalldatetime")]
        public DateTime? FecGarantia { get; set; }
        [Column("FEC_CIERRE", TypeName = "smalldatetime")]
        public DateTime? FecCierre { get; set; }
        [Column("IS_GARANTIA")]
        public int? IsGarantia { get; set; }
        [Column("HORAS_ATENCION")]
        public int? HorasAtencion { get; set; }
        [Column("FEC_ALTA_HORAS_ATENCION", TypeName = "smalldatetime")]
        public DateTime? FecAltaHorasAtencion { get; set; }
        [Column("MINS_DOWNTIME")]
        public int? MinsDowntime { get; set; }
        [Column("ID_USUARIO_CIERRE")]
        public int? IdUsuarioCierre { get; set; }
        [Column("ID_CAUSA")]
        public int? IdCausa { get; set; }
        [Column("ID_SOLUCION")]
        public int? IdSolucion { get; set; }
        [Column("FOLIO_TAS")]
        [StringLength(20)]
        public string FolioTas { get; set; }
        [Column("OTORGANTE_TAS")]
        [StringLength(255)]
        public string OtorganteTas { get; set; }
        [Column("NO_EQUIPO")]
        [StringLength(50)]
        public string NoEquipo { get; set; }
        [Column("FEC_LLEGADA", TypeName = "smalldatetime")]
        public DateTime? FecLlegada { get; set; }
        [Column("FEC_LLEGADA_TERCEROS", TypeName = "smalldatetime")]
        public DateTime? FecLlegadaTerceros { get; set; }
        [Column("FOLIO_SERVICIO")]
        [StringLength(50)]
        public string FolioServicio { get; set; }
        [Column("FEC_INI_INGENIERO", TypeName = "smalldatetime")]
        public DateTime? FecIniIngeniero { get; set; }
        [Column("FEC_FIN_INGENIERO", TypeName = "smalldatetime")]
        public DateTime? FecFinIngeniero { get; set; }
        [Column("OTORGANTE_VOBO")]
        [StringLength(255)]
        public string OtorganteVobo { get; set; }
        [Column("OTORGANTE_VOBO_TERCEROS")]
        [StringLength(255)]
        public string OtorganteVoboTerceros { get; set; }
        [Column("INTENSIDAD_SENIAL")]
        [StringLength(50)]
        public string IntensidadSenial { get; set; }
        [Column("IS_SIM_REMPLAZADA")]
        public int? IsSimRemplazada { get; set; }
        [Column("FALLA_ENCONTRADA")]
        [StringLength(255)]
        public string FallaEncontrada { get; set; }
        [Column("OTORGANTE_VOBO_CLIENTE")]
        [StringLength(255)]
        public string OtorganteVoboCliente { get; set; }
        [Column("MOTIVO_COBRO")]
        [StringLength(255)]
        public string MotivoCobro { get; set; }
        [Column("IS_SOPORTE_CLIENTE")]
        public int? IsSoporteCliente { get; set; }
        [Column("IS_BOLETIN")]
        public int? IsBoletin { get; set; }
        [Column("OTORGANTE_SOPORTE_CLIENTE")]
        [StringLength(255)]
        public string OtorganteSoporteCliente { get; set; }
        [Column("DESCRIPCION_TRABAJO")]
        [StringLength(3000)]
        public string DescripcionTrabajo { get; set; }
        [Column("ATIENDE")]
        [StringLength(255)]
        public string Atiende { get; set; }
        [Column("AUTORIZADOR_RECHAZO")]
        [StringLength(150)]
        public string AutorizadorRechazo { get; set; }
        [Column("ID_CAUSA_RECHAZO")]
        public int? IdCausaRechazo { get; set; }
        [Column("CAUSA_RECHAZO")]
        [StringLength(255)]
        public string CausaRechazo { get; set; }
        [Column("CAUSA_CANCELACION")]
        [StringLength(255)]
        public string CausaCancelacion { get; set; }
        [Column("NO_SERIE_FALLA")]
        [StringLength(50)]
        public string NoSerieFalla { get; set; }
        [Column("NO_INVENTARIO_FALLA")]
        [StringLength(50)]
        public string NoInventarioFalla { get; set; }
        [Column("ID_MODELO_FALLA")]
        public int? IdModeloFalla { get; set; }
        [Column("IS_EXITO")]
        public int? IsExito { get; set; }
        [Column("ID_ATTACH1")]
        public int? IdAttach1 { get; set; }
        [Column("ID_ATTACH2")]
        public int? IdAttach2 { get; set; }
        [Column("ID_REPORTE_CIERRE")]
        public int? IdReporteCierre { get; set; }
        [Column("ID_PROYECTO")]
        public int? IdProyecto { get; set; }
        [Column("ID_MODELO_REQ")]
        public int? IdModeloReq { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("ID_TIPO_SERVICIO")]
        public int? IdTipoServicio { get; set; }
        [Column("ID_TIPO_PRECIO")]
        public int? IdTipoPrecio { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("ID_TIPO_COBRO")]
        public int? IdTipoCobro { get; set; }
        [Column("IS_COBRABLE")]
        public int? IsCobrable { get; set; }
        [Column("ID_UNIDAD_ATENDIDA")]
        public int? IdUnidadAtendida { get; set; }
        [Column("ID_REGLA_STATUS_AR")]
        public int? IdReglaStatusAr { get; set; }
        [Column("FEC_ALTA_REGLA_STATUS_AR", TypeName = "smalldatetime")]
        public DateTime? FecAltaReglaStatusAr { get; set; }
        [Column("ID_STATUS_AR")]
        public int IdStatusAr { get; set; }
        [Column("FEC_STATUS_AR", TypeName = "smalldatetime")]
        public DateTime? FecStatusAr { get; set; }
        [Column("CADENA_CIERRE_ESCRITA")]
        [StringLength(3000)]
        public string CadenaCierreEscrita { get; set; }
        [Column("CODIGO_INTERVENCION")]
        [StringLength(50)]
        public string CodigoIntervencion { get; set; }
        [Column("ID_TIPO_FALLA_ENCONTRADA")]
        public int? IdTipoFallaEncontrada { get; set; }
        [Column("IS_RETIPIFICADO")]
        public int? IsRetipificado { get; set; }
        [Column("MOTIVO_RETIPIFICADO")]
        [StringLength(100)]
        public string MotivoRetipificado { get; set; }
        [Column("IS_FOLLOW_DISPATCH")]
        public int? IsFollowDispatch { get; set; }
        [Column("ID_DISPATCHER")]
        public int? IdDispatcher { get; set; }
        [Column("DIGITO_VERIFICADOR")]
        [StringLength(10)]
        public string DigitoVerificador { get; set; }
        [Column("NO_REINCIDENCIAS")]
        public int? NoReincidencias { get; set; }
        [Column("IS_PROGRAMADO")]
        public int? IsProgramado { get; set; }
        [Column("NO_DIAS_LIBERACION")]
        public int? NoDiasLiberacion { get; set; }
        [Column("ID_RESPONSABLE_CANCELACION_PROGRAMADO")]
        public int? IdResponsableCancelacionProgramado { get; set; }
        [Column("INSUMOS")]
        public int? Insumos { get; set; }
        [Column("RESPONSABLE")]
        [StringLength(50)]
        public string Responsable { get; set; }
        [Column("CAJA")]
        [StringLength(3)]
        public string Caja { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_ESPECIF_TIPO_FALLA")]
        public int? IdEspecifTipoFalla { get; set; }
        [Column("VOLTAJE_NEUTRO")]
        [StringLength(50)]
        public string VoltajeNeutro { get; set; }
        [Column("VOLTAJE_TIERRA")]
        [StringLength(50)]
        public string VoltajeTierra { get; set; }
        [Column("VOLTAJE_TIERRA_NEUTRO")]
        [StringLength(50)]
        public string VoltajeTierraNeutro { get; set; }
        [Column("FOLIO_VALIDACION")]
        [StringLength(50)]
        public string FolioValidacion { get; set; }
        [Column("FOLIO_TIR")]
        [StringLength(50)]
        public string FolioTir { get; set; }
        [Column("ID_ESPECIFICA_CAUSA_RECHAZO")]
        public int? IdEspecificaCausaRechazo { get; set; }
        [Column("DURACION")]
        public int? Duracion { get; set; }
        [Column("TRASLADO")]
        public int? Traslado { get; set; }
        [Column("ID_STATUS_VALIDACION_PREFACTURACION")]
        public int? IdStatusValidacionPrefacturacion { get; set; }
        [Column("ID_DESCRIPCION_TRABAJO")]
        public int? IdDescripcionTrabajo { get; set; }
        [Column("ID_STATUS_REASON_CODES")]
        public int? IdStatusReasonCodes { get; set; }
        [Column("due_by")]
        [StringLength(50)]
        public string DueBy { get; set; }
        [Column("CADENA_CIERRE")]
        public string CadenaCierre { get; set; }
        [Column("NO_SIM")]
        [StringLength(50)]
        public string NoSim { get; set; }
        [Column("CLAVE_RECHAZO")]
        [StringLength(50)]
        public string ClaveRechazo { get; set; }
        [Column("IS_INTERFAZ_BANCOMER")]
        public int? IsInterfazBancomer { get; set; }
        [Column("ID_CONCEPTO")]
        public int? IdConcepto { get; set; }
        [Column("ID_EQUIPO_CLIENTE")]
        public int? IdEquipoCliente { get; set; }
        [Column("NOT_VIATICOS")]
        public int? NotViaticos { get; set; }
        [Column("IS_LOCAL")]
        public int? IsLocal { get; set; }
        [Column("FEC_CARGA", TypeName = "datetime")]
        public DateTime? FecCarga { get; set; }
        [Column("FEC_ATENCION_ORIGINAL", TypeName = "datetime")]
        public DateTime? FecAtencionOriginal { get; set; }
        [Column("HORAS_GARANTIA_WINCOR", TypeName = "numeric(18, 0)")]
        public decimal? HorasGarantiaWincor { get; set; }
        [Column("HORAS_ATENCION_WINCOR", TypeName = "numeric(18, 0)")]
        public decimal? HorasAtencionWincor { get; set; }
        [Column("IS_PDF")]
        public int? IsPdf { get; set; }
        [Column("ID_CONECTIVIDAD")]
        public int? IdConectividad { get; set; }
        [Column("ID_APLICATIVO")]
        public int? IdAplicativo { get; set; }
        [Column("INTENTO_CONTACTO")]
        public int? IntentoContacto { get; set; }
        [Column("ID_CALIFICA_CONTACTO")]
        public int? IdCalificaContacto { get; set; }
        [Column("FEC_INTENTO_1", TypeName = "datetime")]
        public DateTime? FecIntento1 { get; set; }
        [Column("FEC_INTENTO_2", TypeName = "datetime")]
        public DateTime? FecIntento2 { get; set; }
        [Column("FEC_INTENTO_3", TypeName = "datetime")]
        public DateTime? FecIntento3 { get; set; }
        [Column("FEC_INTENTO_4", TypeName = "datetime")]
        public DateTime? FecIntento4 { get; set; }
        [Column("ID_CALIFICA_INTENTO_1")]
        public int? IdCalificaIntento1 { get; set; }
        [Column("ID_CALIFICA_INTENTO_2")]
        public int? IdCalificaIntento2 { get; set; }
        [Column("ID_CALIFICA_INTENTO_3")]
        public int? IdCalificaIntento3 { get; set; }
        [Column("ID_CALIFICA_INTENTO_4")]
        public int? IdCalificaIntento4 { get; set; }
        [Column("FOLIO_TELECARGA")]
        public int? FolioTelecarga { get; set; }
        [Column("ID_TIPO_EQUIPO")]
        public int? IdTipoEquipo { get; set; }
        [Column("CORREO_EJECUTIVO")]
        [StringLength(255)]
        public string CorreoEjecutivo { get; set; }
        [Column("TELEFONO_COMERCIO")]
        [StringLength(255)]
        public string TelefonoComercio { get; set; }
        [Column("PERSONA_ATENDERA_COMERCIO")]
        [StringLength(255)]
        public string PersonaAtenderaComercio { get; set; }
        [Column("PROVEEDOR_ATENDERA_COMERCIO")]
        [StringLength(255)]
        public string ProveedorAtenderaComercio { get; set; }
        [Column("HORA_ATENCION_INI")]
        public TimeSpan? HoraAtencionIni { get; set; }
        [Column("HORA_ATENCION_FIN")]
        public TimeSpan? HoraAtencionFin { get; set; }
        [Column("TERMINAL_AMEX")]
        public int? TerminalAmex { get; set; }
        [Column("AGREGAR_DIAS_ATENCION")]
        public int? AgregarDiasAtencion { get; set; }
        [Column("DIRECCION_ALTERNA_COMERCIO", TypeName = "varchar(max)")]
        public string DireccionAlternaComercio { get; set; }
        [Column("ID_PROVEEDOR")]
        public int? IdProveedor { get; set; }
        [Column("RP")]
        public int? Rp { get; set; }
        [Column("RS")]
        public int? Rs { get; set; }
        [Column("ID_AR_ORIGINAL")]
        public int? IdArOriginal { get; set; }
        [Column("MI_COMERCIO")]
        [StringLength(100)]
        public string MiComercio { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SERVICIOS")]
    public partial class CServicios
    {
        public CServicios()
        {
            BdServicioCausa = new HashSet<BdServicioCausa>();
            BdServicioSolucion = new HashSet<BdServicioSolucion>();
        }

        [Column("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_TIPO_SERVICIO")]
        public int IdTipoServicio { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("ID_TIPO_PRECIO")]
        public int? IdTipoPrecio { get; set; }
        [Column("DESC_SERVICIO")]
        [StringLength(250)]
        public string DescServicio { get; set; }
        [Column("CODIGO")]
        [StringLength(10)]
        public string Codigo { get; set; }
        [Column("MIN_PROMEDIO")]
        public int? MinPromedio { get; set; }
        [Column("IS_INSUMOS_REQUIRED")]
        public int? IsInsumosRequired { get; set; }
        [Column("IS_CAUSA_SOLUCION_REQUIRED")]
        public int? IsCausaSolucionRequired { get; set; }
        [Column("IS_CAUSA_REQUIRED")]
        public int? IsCausaRequired { get; set; }
        [Column("IS_SOLUCION_REQUIRED")]
        public int? IsSolucionRequired { get; set; }
        [Column("IS_TAS_REQUIRED")]
        public int? IsTasRequired { get; set; }
        [Column("IS_OTORGANTE_TAS_REQUIRED")]
        public int? IsOtorganteTasRequired { get; set; }
        [Column("IS_NO_EQUIPO_REQUIRED")]
        public int? IsNoEquipoRequired { get; set; }
        [Column("IS_NO_SERIE_REQUIRED")]
        public int? IsNoSerieRequired { get; set; }
        [Column("IS_NO_INVENTARIO_REQUIRED")]
        public int? IsNoInventarioRequired { get; set; }
        [Column("IS_ID_MODELO_REQUIRED")]
        public int? IsIdModeloRequired { get; set; }
        [Column("IS_FEC_LLEGADA_REQUIRED")]
        public int? IsFecLlegadaRequired { get; set; }
        [Column("IS_FEC_LLEGADA_TERCEROS_REQUIRED")]
        public int? IsFecLlegadaTercerosRequired { get; set; }
        [Column("IS_FOLIO_SERVICIO_REQUIRED")]
        public int? IsFolioServicioRequired { get; set; }
        [Column("IS_FEC_INI_INGENIERO_REQUIRED")]
        public int? IsFecIniIngenieroRequired { get; set; }
        [Column("IS_FEC_FIN_INGENIERO_REQUIRED")]
        public int? IsFecFinIngenieroRequired { get; set; }
        [Column("IS_OTORGANTE_VOBO_REQUIRED")]
        public int? IsOtorganteVoboRequired { get; set; }
        [Column("IS_OTORGANTE_VOBO_TERCEROS_REQUIRED")]
        public int? IsOtorganteVoboTercerosRequired { get; set; }
        [Column("IS_INTENSIDAD_SENIAL_REQUIRED")]
        public int? IsIntensidadSenialRequired { get; set; }
        [Column("IS_IS_SIM_REMPLAZADA_REQUIRED")]
        public int? IsIsSimRemplazadaRequired { get; set; }
        [Column("IS_FOLIO_SERVICIO_RECHAZO_REQUIRED")]
        public int? IsFolioServicioRechazoRequired { get; set; }
        [Column("IS_OTORGANTE_VOBO_RECHAZO_REQUIRED")]
        public int? IsOtorganteVoboRechazoRequired { get; set; }
        [Column("IS_FALLA_ENCONTRADA_REQUIRED")]
        public int? IsFallaEncontradaRequired { get; set; }
        [Column("IS_OTORGANTE_VOBO_CLIENTE_REQUIRED")]
        public int? IsOtorganteVoboClienteRequired { get; set; }
        [Column("IS_MOTIVO_COBRO_REQUIRED")]
        public int? IsMotivoCobroRequired { get; set; }
        [Column("IS_IS_SOPORTE_CLIENTE_REQUIRED")]
        public int? IsIsSoporteClienteRequired { get; set; }
        [Column("IS_OTORGANTE_SOPORTE_CLIENTE_REQUIRED")]
        public int? IsOtorganteSoporteClienteRequired { get; set; }
        [Column("IS_IS_BOLETIN_REQUIRED")]
        public int? IsIsBoletinRequired { get; set; }
        [Column("IS_CADENA_CIERRE_ESCRITA_REQUIRED")]
        public int? IsCadenaCierreEscritaRequired { get; set; }
        [Column("IS_DOWNTIME")]
        public int? IsDowntime { get; set; }
        [Column("IS_CODIGO_INTERVENCION_REQUIRED")]
        public int? IsCodigoIntervencionRequired { get; set; }
        [Column("LENGTH_CODIGO_INTERVENCION")]
        public int? LengthCodigoIntervencion { get; set; }
        [Column("IS_ID_TIPO_FALLA_ENCONTRADA_REQUIRED")]
        public int? IsIdTipoFallaEncontradaRequired { get; set; }
        [Column("IS_IDENTIFICA_AGENDADOS_REQUIRED")]
        public int? IsIdentificaAgendadosRequired { get; set; }
        [Column("IS_DESCRIPCION_TRABAJO_RECHAZO_REQUIRED")]
        public int? IsDescripcionTrabajoRechazoRequired { get; set; }
        [Column("IS_CIERRE_PDA")]
        public int? IsCierrePda { get; set; }
        [Column("IS_INSTALACION_LLAVES_REQUIRED")]
        public int? IsInstalacionLlavesRequired { get; set; }
        [Column("IS_STATUS_INSTALACION_LLAVES_REQUIRED")]
        public int? IsStatusInstalacionLlavesRequired { get; set; }
        [Column("IS_NOMBRE_PERSONA_LLAVES_A_REQUIRED")]
        public int? IsNombrePersonaLlavesARequired { get; set; }
        [Column("IS_NOMBRE_PERSONA_LLAVES_B_REQUIRED")]
        public int? IsNombrePersonaLlavesBRequired { get; set; }
        [Column("IS_TIPO_PW_REQUIRED")]
        public int? IsTipoPwRequired { get; set; }
        [Column("IS_TIPO_TECLADO_REQUIRED")]
        public int? IsTipoTecladoRequired { get; set; }
        [Column("IS_VERSION_TECLADO_EPP_REQUIRED")]
        public int? IsVersionTecladoEppRequired { get; set; }
        [Column("IS_PROCESADOR_REQUIRED")]
        public int? IsProcesadorRequired { get; set; }
        [Column("IS_VELOCIDAD_PROCESADOR_REQUIRED")]
        public int? IsVelocidadProcesadorRequired { get; set; }
        [Column("IS_MEMORIA_REQUIRED")]
        public int? IsMemoriaRequired { get; set; }
        [Column("IS_CAPACIDAD_DISCO_DURO_REQUIRED")]
        public int? IsCapacidadDiscoDuroRequired { get; set; }
        [Column("IS_MONITOR_REQUIRED")]
        public int? IsMonitorRequired { get; set; }
        [Column("IS_LECTOR_TARJETA_REQUIRED")]
        public int? IsLectorTarjetaRequired { get; set; }
        [Column("IS_OTORGANTE_VOBO_ING_PARTNER_REQUIRED")]
        public int? IsOtorganteVoboIngPartnerRequired { get; set; }
        [Column("IS_FEC_LLEGADA_ING_PARTNER_REQUIRED")]
        public int? IsFecLlegadaIngPartnerRequired { get; set; }
        [Column("IS_REPORTE_SERVICIO_PARTNER_REQUIRED")]
        public int? IsReporteServicioPartnerRequired { get; set; }
        [Column("IS_IS_VALIDACION_ALARMAS_REQUIRED")]
        public int? IsIsValidacionAlarmasRequired { get; set; }
        [Column("IS_IS_INSTALACION_PLACA_FRONTAL_REQUIRED")]
        public int? IsIsInstalacionPlacaFrontalRequired { get; set; }
        [Column("IS_IS_INSTALACION_PLACA_LATERAL_REQUIRED")]
        public int? IsIsInstalacionPlacaLateralRequired { get; set; }
        [Column("IS_IS_BLINDAJE_TUERCA_SEGURIDAD_REQUIRED")]
        public int? IsIsBlindajeTuercaSeguridadRequired { get; set; }
        [Column("IS_IS_2_TAQUETES_ADICIONALES_REQUIRED")]
        public int? IsIs2TaquetesAdicionalesRequired { get; set; }
        [Column("IS_IS_SUSTITUCION_4_TUERCAS_REQUIRED")]
        public int? IsIsSustitucion4TuercasRequired { get; set; }
        [Column("IS_IS_FOTOGRAFIAS_REQUIRED")]
        public int? IsIsFotografiasRequired { get; set; }
        [Column("IS_MULTIPLE_TASK")]
        public int? IsMultipleTask { get; set; }
        [Column("IS_PREFACTURACION_IS_COBRABLE")]
        public int? IsPrefacturacionIsCobrable { get; set; }
        [Column("IS_PREFACTURACION_IS_RETIPIFICADO")]
        public int? IsPrefacturacionIsRetipificado { get; set; }
        [Column("IS_PREFACTURACION_AGENDADO")]
        public int? IsPrefacturacionAgendado { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_TIPO_LLAVE_REQUIRED")]
        public int? IsTipoLlaveRequired { get; set; }
        [Column("IS_DV_REQUIRED")]
        public int? IsDvRequired { get; set; }
        [Column("IS_ALERT_REINCIDENTE")]
        public int? IsAlertReincidente { get; set; }
        [Column("IS_REPORT_REINCIDENTE")]
        public int? IsReportReincidente { get; set; }
        [Column("IS_APLICACION_REQUIRED")]
        public int? IsAplicacionRequired { get; set; }
        [Column("IS_VERSION_REQUIRED")]
        public int? IsVersionRequired { get; set; }
        [Column("IS_CAJA_REQUIRED")]
        public int? IsCajaRequired { get; set; }
        [Column("REQUISITOS_SERVICIO")]
        [StringLength(400)]
        public string RequisitosServicio { get; set; }
        [Column("IS_LECTURA_VOLTAJE_REQUIRED")]
        public int? IsLecturaVoltajeRequired { get; set; }
        [Column("IS_FOLIO_VALIDACION_REQUIRED")]
        public int? IsFolioValidacionRequired { get; set; }
        [Column("IS_FOLIO_TIR_REQUIRED")]
        public int? IsFolioTirRequired { get; set; }
        [Column("IS_ESPECIFICA_TIPO_FALLA")]
        public int? IsEspecificaTipoFalla { get; set; }
        [Column("IS_ID_CAUSA_RECHAZO_REQUIRED")]
        public int? IsIdCausaRechazoRequired { get; set; }
        [Column("IS_ESPECIFICA_CAUSA_RECHAZO_REQUIRED")]
        public int? IsEspecificaCausaRechazoRequired { get; set; }
        [Column("MIN_TABLERO")]
        public int? MinTablero { get; set; }
        [Column("IS_DESC_TRABAJO_REQUIRED")]
        public int? IsDescTrabajoRequired { get; set; }
        [Column("IS_DESC_TRABAJO_CATALOGO_REQUIRED")]
        public int? IsDescTrabajoCatalogoRequired { get; set; }
        [Column("ID_CATEGORIA_VALIDA_DISPOSITIVOS")]
        [StringLength(50)]
        public string IdCategoriaValidaDispositivos { get; set; }
        [Column("request_type")]
        [StringLength(50)]
        public string RequestType { get; set; }
        [Column("IS_XML_ELAVON")]
        public int? IsXmlElavon { get; set; }
        [Column("isWarrantyDays")]
        public int? IsWarrantyDays { get; set; }
        [Column("isCourtSchedule")]
        public int? IsCourtSchedule { get; set; }
        [Column("IS_ASIGNACION_AUTO")]
        public int? IsAsignacionAuto { get; set; }
        [Column("needNoSim")]
        public int? NeedNoSim { get; set; }
        [Column("needClaveRechazo")]
        public int? NeedClaveRechazo { get; set; }
        [Column("IdARNeedNOcheckup")]
        public int? IdArneedNocheckup { get; set; }
        [Column("IdARNeedFile")]
        public int? IdArneedFile { get; set; }
        [Column("IdARReopen")]
        public int? IdArreopen { get; set; }
        [Column("IS_FALLA_ENCONTRADA_CATALOGO_REQUIRED")]
        public int? IsFallaEncontradaCatalogoRequired { get; set; }
        [Column("IS_HORARIO_GARANTIA")]
        public int? IsHorarioGarantia { get; set; }
        [Column("IS_MINUTOS_GARANTIA")]
        public int? IsMinutosGarantia { get; set; }
        [Column("KIT_INSUMO")]
        public int? KitInsumo { get; set; }
        [Column("NEED_KIT")]
        public int? NeedKit { get; set; }
        [Column("IS_EMAIL_SERVICE_CHARGE")]
        public int? IsEmailServiceCharge { get; set; }
        [Column("IS_REGLA_DUPLICADO")]
        public int? IsReglaDuplicado { get; set; }
        [Column("IS_PROYECTO")]
        public int? IsProyecto { get; set; }
        [Column("NO_DIAS")]
        public int? NoDias { get; set; }
        [Column("IS_CALL_CENTER")]
        public int? IsCallCenter { get; set; }

        [ForeignKey("IdMoneda")]
        [InverseProperty("CServicios")]
        public virtual CMonedas IdMonedaNavigation { get; set; }
        [ForeignKey("IdTipoPrecio")]
        [InverseProperty("CServicios")]
        public virtual CTipoPrecio IdTipoPrecioNavigation { get; set; }
        [ForeignKey("IdTipoServicio")]
        [InverseProperty("CServicios")]
        public virtual CTipoServicio IdTipoServicioNavigation { get; set; }
        [InverseProperty("IdServicioNavigation")]
        public virtual ICollection<BdServicioCausa> BdServicioCausa { get; set; }
        [InverseProperty("IdServicioNavigation")]
        public virtual ICollection<BdServicioSolucion> BdServicioSolucion { get; set; }
    }
}

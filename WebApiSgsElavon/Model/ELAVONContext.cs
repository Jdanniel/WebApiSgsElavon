using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApiSgsElavon.Entities;

namespace WebApiSgsElavon.Model
{
    public partial class ELAVONContext : DbContext
    {
        public ELAVONContext()
        {
        }

        public ELAVONContext(DbContextOptions<ELAVONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BdActasAdmin> BdActasAdmin { get; set; }
        public virtual DbSet<BdAfiliacionesProyectoEspecial> BdAfiliacionesProyectoEspecial { get; set; }
        public virtual DbSet<BdAjustesInsumosPaso> BdAjustesInsumosPaso { get; set; }
        public virtual DbSet<BdAltaFecGarantia> BdAltaFecGarantia { get; set; }
        public virtual DbSet<BdAltaMasivaUnidadCa> BdAltaMasivaUnidadCa { get; set; }
        public virtual DbSet<BdAr> BdAr { get; set; }
        public virtual DbSet<BdArAccesorios> BdArAccesorios { get; set; }
        public virtual DbSet<BdArArchivosVarios> BdArArchivosVarios { get; set; }
        public virtual DbSet<BdArCausasCancelacion> BdArCausasCancelacion { get; set; }
        public virtual DbSet<BdArCierreManual> BdArCierreManual { get; set; }
        public virtual DbSet<BdArDatosComerciosExtra> BdArDatosComerciosExtra { get; set; }
        public virtual DbSet<BdArDesviacion> BdArDesviacion { get; set; }
        public virtual DbSet<BdArDiasAtencion> BdArDiasAtencion { get; set; }
        public virtual DbSet<BdArExtension> BdArExtension { get; set; }
        public virtual DbSet<BdArFecGarantia> BdArFecGarantia { get; set; }
        public virtual DbSet<BdArInsumo> BdArInsumo { get; set; }
        public virtual DbSet<BdArLogWs> BdArLogWs { get; set; }
        public virtual DbSet<BdArMiComercio> BdArMiComercio { get; set; }
        public virtual DbSet<BdArPaso> BdArPaso { get; set; }
        public virtual DbSet<BdArPrefacturacion> BdArPrefacturacion { get; set; }
        public virtual DbSet<BdArSlaInventarios> BdArSlaInventarios { get; set; }
        public virtual DbSet<BdArSparePart> BdArSparePart { get; set; }
        public virtual DbSet<BdArTerminalAsociadaAmex> BdArTerminalAsociadaAmex { get; set; }
        public virtual DbSet<BdArViatico> BdArViatico { get; set; }
        public virtual DbSet<BdArViaticoMotivo> BdArViaticoMotivo { get; set; }
        public virtual DbSet<BdArVisitas> BdArVisitas { get; set; }
        public virtual DbSet<BdArchivoDispersionSolicitudViaticos> BdArchivoDispersionSolicitudViaticos { get; set; }
        public virtual DbSet<BdArchivosConfirmaciones> BdArchivosConfirmaciones { get; set; }
        public virtual DbSet<BdArchivosDispersion> BdArchivosDispersion { get; set; }
        public virtual DbSet<BdArchivosPrefacturacion> BdArchivosPrefacturacion { get; set; }
        public virtual DbSet<BdAsignacionAutomaticaPaso> BdAsignacionAutomaticaPaso { get; set; }
        public virtual DbSet<BdAttach> BdAttach { get; set; }
        public virtual DbSet<BdAttachAcciones> BdAttachAcciones { get; set; }
        public virtual DbSet<BdAttachDhl> BdAttachDhl { get; set; }
        public virtual DbSet<BdAuditoriaCierres> BdAuditoriaCierres { get; set; }
        public virtual DbSet<BdAuditoriaProcesosInternos> BdAuditoriaProcesosInternos { get; set; }
        public virtual DbSet<BdAuditoriaReporte> BdAuditoriaReporte { get; set; }
        public virtual DbSet<BdAuditorias> BdAuditorias { get; set; }
        public virtual DbSet<BdBbvaPaso> BdBbvaPaso { get; set; }
        public virtual DbSet<BdBitacoraAcceso> BdBitacoraAcceso { get; set; }
        public virtual DbSet<BdBitacoraAgendados> BdBitacoraAgendados { get; set; }
        public virtual DbSet<BdBitacoraAlmacenResponsable> BdBitacoraAlmacenResponsable { get; set; }
        public virtual DbSet<BdBitacoraAlmacenStatus> BdBitacoraAlmacenStatus { get; set; }
        public virtual DbSet<BdBitacoraAplicativoUnidad> BdBitacoraAplicativoUnidad { get; set; }
        public virtual DbSet<BdBitacoraAr> BdBitacoraAr { get; set; }
        public virtual DbSet<BdBitacoraArAlta> BdBitacoraArAlta { get; set; }
        public virtual DbSet<BdBitacoraBdNegocios> BdBitacoraBdNegocios { get; set; }
        public virtual DbSet<BdBitacoraBorrarUnidad> BdBitacoraBorrarUnidad { get; set; }
        public virtual DbSet<BdBitacoraCambioMensajeria> BdBitacoraCambioMensajeria { get; set; }
        public virtual DbSet<BdBitacoraCambioNoInventario> BdBitacoraCambioNoInventario { get; set; }
        public virtual DbSet<BdBitacoraCambioSerie> BdBitacoraCambioSerie { get; set; }
        public virtual DbSet<BdBitacoraCambioUnidadNueva> BdBitacoraCambioUnidadNueva { get; set; }
        public virtual DbSet<BdBitacoraCierresOdt> BdBitacoraCierresOdt { get; set; }
        public virtual DbSet<BdBitacoraCompromisos> BdBitacoraCompromisos { get; set; }
        public virtual DbSet<BdBitacoraConectividadUnidad> BdBitacoraConectividadUnidad { get; set; }
        public virtual DbSet<BdBitacoraDiagnostico> BdBitacoraDiagnostico { get; set; }
        public virtual DbSet<BdBitacoraDoctosPrefacturacion> BdBitacoraDoctosPrefacturacion { get; set; }
        public virtual DbSet<BdBitacoraEnvio> BdBitacoraEnvio { get; set; }
        public virtual DbSet<BdBitacoraIgualas> BdBitacoraIgualas { get; set; }
        public virtual DbSet<BdBitacoraInsumos> BdBitacoraInsumos { get; set; }
        public virtual DbSet<BdBitacoraItemsBorrados> BdBitacoraItemsBorrados { get; set; }
        public virtual DbSet<BdBitacoraItemsSolicitudAlmacen> BdBitacoraItemsSolicitudAlmacen { get; set; }
        public virtual DbSet<BdBitacoraJobs> BdBitacoraJobs { get; set; }
        public virtual DbSet<BdBitacoraModeloUnidad> BdBitacoraModeloUnidad { get; set; }
        public virtual DbSet<BdBitacoraMovimientosRetornosInsumos> BdBitacoraMovimientosRetornosInsumos { get; set; }
        public virtual DbSet<BdBitacoraNegociosCoordenadas> BdBitacoraNegociosCoordenadas { get; set; }
        public virtual DbSet<BdBitacoraNoInsumoAr> BdBitacoraNoInsumoAr { get; set; }
        public virtual DbSet<BdBitacoraOdtOnbaseConfirmacion> BdBitacoraOdtOnbaseConfirmacion { get; set; }
        public virtual DbSet<BdBitacoraProcedure> BdBitacoraProcedure { get; set; }
        public virtual DbSet<BdBitacoraProducto> BdBitacoraProducto { get; set; }
        public virtual DbSet<BdBitacoraPropiedadCliente> BdBitacoraPropiedadCliente { get; set; }
        public virtual DbSet<BdBitacoraReasignacionTecnicos> BdBitacoraReasignacionTecnicos { get; set; }
        public virtual DbSet<BdBitacoraRechazosEnvios> BdBitacoraRechazosEnvios { get; set; }
        public virtual DbSet<BdBitacoraServicios> BdBitacoraServicios { get; set; }
        public virtual DbSet<BdBitacoraServiciosFalla> BdBitacoraServiciosFalla { get; set; }
        public virtual DbSet<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucion { get; set; }
        public virtual DbSet<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccion { get; set; }
        public virtual DbSet<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacen { get; set; }
        public virtual DbSet<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticos { get; set; }
        public virtual DbSet<BdBitacoraStatusTipoUsuario> BdBitacoraStatusTipoUsuario { get; set; }
        public virtual DbSet<BdBitacoraSubServicios> BdBitacoraSubServicios { get; set; }
        public virtual DbSet<BdBitacoraTipoCausaCancelacion> BdBitacoraTipoCausaCancelacion { get; set; }
        public virtual DbSet<BdBitacoraTipoCusasRechazo> BdBitacoraTipoCusasRechazo { get; set; }
        public virtual DbSet<BdBitacoraTipoPlazaCliente> BdBitacoraTipoPlazaCliente { get; set; }
        public virtual DbSet<BdBitacoraTipoProductoNegocio> BdBitacoraTipoProductoNegocio { get; set; }
        public virtual DbSet<BdBitacoraTipoSubrechazo> BdBitacoraTipoSubrechazo { get; set; }
        public virtual DbSet<BdBitacoraTransferencias> BdBitacoraTransferencias { get; set; }
        public virtual DbSet<BdBitacoraUnidad> BdBitacoraUnidad { get; set; }
        public virtual DbSet<BdBitacoraUnidadDanada> BdBitacoraUnidadDanada { get; set; }
        public virtual DbSet<BdBitacoraUnidadesFaltantesRecibo> BdBitacoraUnidadesFaltantesRecibo { get; set; }
        public virtual DbSet<BdBitacoraUsuariosActivos> BdBitacoraUsuariosActivos { get; set; }
        public virtual DbSet<BdBitacoraValidacionDevoluciones> BdBitacoraValidacionDevoluciones { get; set; }
        public virtual DbSet<BdBitacoraValidacionPrefacturacion> BdBitacoraValidacionPrefacturacion { get; set; }
        public virtual DbSet<BdBloqueos> BdBloqueos { get; set; }
        public virtual DbSet<BdBloqueosPaso> BdBloqueosPaso { get; set; }
        public virtual DbSet<BdBloqueosRespaldo> BdBloqueosRespaldo { get; set; }
        public virtual DbSet<BdCallCenterQ1> BdCallCenterQ1 { get; set; }
        public virtual DbSet<BdCallCenterSeguimiento> BdCallCenterSeguimiento { get; set; }
        public virtual DbSet<BdCallcenterRQ1> BdCallcenterRQ1 { get; set; }
        public virtual DbSet<BdCallcenterRQ10> BdCallcenterRQ10 { get; set; }
        public virtual DbSet<BdCallcenterRQ11> BdCallcenterRQ11 { get; set; }
        public virtual DbSet<BdCallcenterRQ12> BdCallcenterRQ12 { get; set; }
        public virtual DbSet<BdCallcenterRQ13> BdCallcenterRQ13 { get; set; }
        public virtual DbSet<BdCallcenterRQ14> BdCallcenterRQ14 { get; set; }
        public virtual DbSet<BdCallcenterRQ2> BdCallcenterRQ2 { get; set; }
        public virtual DbSet<BdCallcenterRQ3> BdCallcenterRQ3 { get; set; }
        public virtual DbSet<BdCallcenterRQ4> BdCallcenterRQ4 { get; set; }
        public virtual DbSet<BdCallcenterRQ5> BdCallcenterRQ5 { get; set; }
        public virtual DbSet<BdCallcenterRQ6> BdCallcenterRQ6 { get; set; }
        public virtual DbSet<BdCallcenterRQ7> BdCallcenterRQ7 { get; set; }
        public virtual DbSet<BdCallcenterRQ8> BdCallcenterRQ8 { get; set; }
        public virtual DbSet<BdCallcenterRQ9> BdCallcenterRQ9 { get; set; }
        public virtual DbSet<BdCambioStatusAr> BdCambioStatusAr { get; set; }
        public virtual DbSet<BdCambiosEstatusPermititdosUnidades> BdCambiosEstatusPermititdosUnidades { get; set; }
        public virtual DbSet<BdCargaChangeComentarios> BdCargaChangeComentarios { get; set; }
        public virtual DbSet<BdCargaChangeStatus> BdCargaChangeStatus { get; set; }
        public virtual DbSet<BdCargaCierresMasivosTexto> BdCargaCierresMasivosTexto { get; set; }
        public virtual DbSet<BdCargaCierresMasivosTextoMit> BdCargaCierresMasivosTextoMit { get; set; }
        public virtual DbSet<BdCargaCodigoRechazo> BdCargaCodigoRechazo { get; set; }
        public virtual DbSet<BdCargaEnviosDhlErrores> BdCargaEnviosDhlErrores { get; set; }
        public virtual DbSet<BdCargaEnviosDhlPaso> BdCargaEnviosDhlPaso { get; set; }
        public virtual DbSet<BdCargaEnviosEstafetaPaso> BdCargaEnviosEstafetaPaso { get; set; }
        public virtual DbSet<BdCargaUnidadNoInventario> BdCargaUnidadNoInventario { get; set; }
        public virtual DbSet<BdCargas> BdCargas { get; set; }
        public virtual DbSet<BdCargasConfirmaciones> BdCargasConfirmaciones { get; set; }
        public virtual DbSet<BdCargasEquipo> BdCargasEquipo { get; set; }
        public virtual DbSet<BdCargasMasivas> BdCargasMasivas { get; set; }
        public virtual DbSet<BdCargasOdtElavon> BdCargasOdtElavon { get; set; }
        public virtual DbSet<BdChangeMassiveStatus> BdChangeMassiveStatus { get; set; }
        public virtual DbSet<BdChangeStatusArPaso> BdChangeStatusArPaso { get; set; }
        public virtual DbSet<BdClaveEstado> BdClaveEstado { get; set; }
        public virtual DbSet<BdClienteModelo> BdClienteModelo { get; set; }
        public virtual DbSet<BdClienteModeloCambioStatusUnidad> BdClienteModeloCambioStatusUnidad { get; set; }
        public virtual DbSet<BdClienteProductoStatusAr> BdClienteProductoStatusAr { get; set; }
        public virtual DbSet<BdClienteWeekhour> BdClienteWeekhour { get; set; }
        public virtual DbSet<BdComentarioAr> BdComentarioAr { get; set; }
        public virtual DbSet<BdComprobacionSolicitudesViaticos> BdComprobacionSolicitudesViaticos { get; set; }
        public virtual DbSet<BdComprobacionViaticos> BdComprobacionViaticos { get; set; }
        public virtual DbSet<BdComprobacionViaticos2> BdComprobacionViaticos2 { get; set; }
        public virtual DbSet<BdCompromisoBlog> BdCompromisoBlog { get; set; }
        public virtual DbSet<BdCompromisoResponsable> BdCompromisoResponsable { get; set; }
        public virtual DbSet<BdCompromisos> BdCompromisos { get; set; }
        public virtual DbSet<BdCompromisosAcciones> BdCompromisosAcciones { get; set; }
        public virtual DbSet<BdCompromisosCompromiso> BdCompromisosCompromiso { get; set; }
        public virtual DbSet<BdConfiguracionMensajeria> BdConfiguracionMensajeria { get; set; }
        public virtual DbSet<BdConfirmaciones> BdConfirmaciones { get; set; }
        public virtual DbSet<BdConfirmacionesIntermedia> BdConfirmacionesIntermedia { get; set; }
        public virtual DbSet<BdConjuntoModeloConectividad> BdConjuntoModeloConectividad { get; set; }
        public virtual DbSet<BdConsumiblesUnidad> BdConsumiblesUnidad { get; set; }
        public virtual DbSet<BdControlAlertasAr> BdControlAlertasAr { get; set; }
        public virtual DbSet<BdControlInsumos> BdControlInsumos { get; set; }
        public virtual DbSet<BdControlInsumosDetalle> BdControlInsumosDetalle { get; set; }
        public virtual DbSet<BdControlInsumosEnvios> BdControlInsumosEnvios { get; set; }
        public virtual DbSet<BdControlKitTecnico> BdControlKitTecnico { get; set; }
        public virtual DbSet<BdControlMasivoDevoluciones> BdControlMasivoDevoluciones { get; set; }
        public virtual DbSet<BdCotizaciones3m> BdCotizaciones3m { get; set; }
        public virtual DbSet<BdCotizaciones3mDet> BdCotizaciones3mDet { get; set; }
        public virtual DbSet<BdCpAsignacionAutomatica> BdCpAsignacionAutomatica { get; set; }
        public virtual DbSet<BdCuentasBancarias> BdCuentasBancarias { get; set; }
        public virtual DbSet<BdCursos> BdCursos { get; set; }
        public virtual DbSet<BdCursosAsignados> BdCursosAsignados { get; set; }
        public virtual DbSet<BdDatosCierresAplicacion> BdDatosCierresAplicacion { get; set; }
        public virtual DbSet<BdDbBackup> BdDbBackup { get; set; }
        public virtual DbSet<BdDevoluciones> BdDevoluciones { get; set; }
        public virtual DbSet<BdDirecciones> BdDirecciones { get; set; }
        public virtual DbSet<BdDireccionesRelaciones> BdDireccionesRelaciones { get; set; }
        public virtual DbSet<BdDirectorioTelefonicoAr> BdDirectorioTelefonicoAr { get; set; }
        public virtual DbSet<BdElavonDispatches> BdElavonDispatches { get; set; }
        public virtual DbSet<BdElavonRecoveries> BdElavonRecoveries { get; set; }
        public virtual DbSet<BdEmails> BdEmails { get; set; }
        public virtual DbSet<BdEmails2> BdEmails2 { get; set; }
        public virtual DbSet<BdEnvioDoctosDocto> BdEnvioDoctosDocto { get; set; }
        public virtual DbSet<BdEnvioElavon> BdEnvioElavon { get; set; }
        public virtual DbSet<BdEnvioInsumos> BdEnvioInsumos { get; set; }
        public virtual DbSet<BdEnvioSims> BdEnvioSims { get; set; }
        public virtual DbSet<BdEnvioUnidad> BdEnvioUnidad { get; set; }
        public virtual DbSet<BdEnvios> BdEnvios { get; set; }
        public virtual DbSet<BdEnviosDoctos> BdEnviosDoctos { get; set; }
        public virtual DbSet<BdEquivaleciasModelo> BdEquivaleciasModelo { get; set; }
        public virtual DbSet<BdEquivalenciaEstado> BdEquivalenciaEstado { get; set; }
        public virtual DbSet<BdEspecificacionCausaRechazo> BdEspecificacionCausaRechazo { get; set; }
        public virtual DbSet<BdEspecificacionTipoFalla> BdEspecificacionTipoFalla { get; set; }
        public virtual DbSet<BdEtiquetaInformacionUnidadCliente> BdEtiquetaInformacionUnidadCliente { get; set; }
        public virtual DbSet<BdExistenciasConsumiblesTecnicos> BdExistenciasConsumiblesTecnicos { get; set; }
        public virtual DbSet<BdExitoLayoutLog> BdExitoLayoutLog { get; set; }
        public virtual DbSet<BdExtravioPorMensajeriaCargaPdf> BdExtravioPorMensajeriaCargaPdf { get; set; }
        public virtual DbSet<BdFallaConFallaEncontrada> BdFallaConFallaEncontrada { get; set; }
        public virtual DbSet<BdFallaEspecificaTipoFalla> BdFallaEspecificaTipoFalla { get; set; }
        public virtual DbSet<BdFestivos> BdFestivos { get; set; }
        public virtual DbSet<BdFotoAr> BdFotoAr { get; set; }
        public virtual DbSet<BdGarantiaAlmacen> BdGarantiaAlmacen { get; set; }
        public virtual DbSet<BdGastosOperacion> BdGastosOperacion { get; set; }
        public virtual DbSet<BdGruposClientes> BdGruposClientes { get; set; }
        public virtual DbSet<BdHistoricoPassword> BdHistoricoPassword { get; set; }
        public virtual DbSet<BdHorarioHorasMes> BdHorarioHorasMes { get; set; }
        public virtual DbSet<BdHorarioWeekhour> BdHorarioWeekhour { get; set; }
        public virtual DbSet<BdIgualas> BdIgualas { get; set; }
        public virtual DbSet<BdIgualasAlta> BdIgualasAlta { get; set; }
        public virtual DbSet<BdInformacionUnidadAr> BdInformacionUnidadAr { get; set; }
        public virtual DbSet<BdIngresoArchivoInsumos> BdIngresoArchivoInsumos { get; set; }
        public virtual DbSet<BdIngresoArchivosAlmacen> BdIngresoArchivosAlmacen { get; set; }
        public virtual DbSet<BdIngresoArchivosAsignacion> BdIngresoArchivosAsignacion { get; set; }
        public virtual DbSet<BdIngresoArchivosExito> BdIngresoArchivosExito { get; set; }
        public virtual DbSet<BdIngresoArchivosRechazo> BdIngresoArchivosRechazo { get; set; }
        public virtual DbSet<BdIngresoMovInventariosLog> BdIngresoMovInventariosLog { get; set; }
        public virtual DbSet<BdInstalaciones> BdInstalaciones { get; set; }
        public virtual DbSet<BdInsumos> BdInsumos { get; set; }
        public virtual DbSet<BdInsumosAlta> BdInsumosAlta { get; set; }
        public virtual DbSet<BdItemsSolicitudAlmacen> BdItemsSolicitudAlmacen { get; set; }
        public virtual DbSet<BdKitInsumos> BdKitInsumos { get; set; }
        public virtual DbSet<BdLoadFilterDhl> BdLoadFilterDhl { get; set; }
        public virtual DbSet<BdLoadFilterEstafeta> BdLoadFilterEstafeta { get; set; }
        public virtual DbSet<BdLogErroresEmailSolicitudes> BdLogErroresEmailSolicitudes { get; set; }
        public virtual DbSet<BdLoginUsers> BdLoginUsers { get; set; }
        public virtual DbSet<BdLogroBlog> BdLogroBlog { get; set; }
        public virtual DbSet<BdLogros> BdLogros { get; set; }
        public virtual DbSet<BdLogrosResponsables> BdLogrosResponsables { get; set; }
        public virtual DbSet<BdMcSims> BdMcSims { get; set; }
        public virtual DbSet<BdMcViaGeozonaCoordenadas> BdMcViaGeozonaCoordenadas { get; set; }
        public virtual DbSet<BdMcViaGeozonaCoordenadasZona> BdMcViaGeozonaCoordenadasZona { get; set; }
        public virtual DbSet<BdMcViaGeozonaTecnico> BdMcViaGeozonaTecnico { get; set; }
        public virtual DbSet<BdMenu> BdMenu { get; set; }
        public virtual DbSet<BdMenuTipoUsuario> BdMenuTipoUsuario { get; set; }
        public virtual DbSet<BdModeloAccesorio> BdModeloAccesorio { get; set; }
        public virtual DbSet<BdModeloCategoria> BdModeloCategoria { get; set; }
        public virtual DbSet<BdModeloCelular> BdModeloCelular { get; set; }
        public virtual DbSet<BdModeloConectividad> BdModeloConectividad { get; set; }
        public virtual DbSet<BdModeloInsumo> BdModeloInsumo { get; set; }
        public virtual DbSet<BdModeloLlave> BdModeloLlave { get; set; }
        public virtual DbSet<BdModeloModulo> BdModeloModulo { get; set; }
        public virtual DbSet<BdModeloPrecio> BdModeloPrecio { get; set; }
        public virtual DbSet<BdModeloServicio> BdModeloServicio { get; set; }
        public virtual DbSet<BdModeloSku> BdModeloSku { get; set; }
        public virtual DbSet<BdModeloSoftware> BdModeloSoftware { get; set; }
        public virtual DbSet<BdModeloSparePart> BdModeloSparePart { get; set; }
        public virtual DbSet<BdModeloSustituto> BdModeloSustituto { get; set; }
        public virtual DbSet<BdNegocioHorasMes> BdNegocioHorasMes { get; set; }
        public virtual DbSet<BdNegocios> BdNegocios { get; set; }
        public virtual DbSet<BdNegocios2> BdNegocios2 { get; set; }
        public virtual DbSet<BdNegociosAlta> BdNegociosAlta { get; set; }
        public virtual DbSet<BdNegociosPaso2> BdNegociosPaso2 { get; set; }
        public virtual DbSet<BdNegociosServiciosDobles> BdNegociosServiciosDobles { get; set; }
        public virtual DbSet<BdOnbaseInbox> BdOnbaseInbox { get; set; }
        public virtual DbSet<BdOnbaseInboxConfirmacion> BdOnbaseInboxConfirmacion { get; set; }
        public virtual DbSet<BdOpcionesReingenieriaTipoUsuario> BdOpcionesReingenieriaTipoUsuario { get; set; }
        public virtual DbSet<BdOrdenCompra> BdOrdenCompra { get; set; }
        public virtual DbSet<BdOrdenCompraInsumos> BdOrdenCompraInsumos { get; set; }
        public virtual DbSet<BdOrdenCompraNoFactura> BdOrdenCompraNoFactura { get; set; }
        public virtual DbSet<BdOrdenCompraUnidades> BdOrdenCompraUnidades { get; set; }
        public virtual DbSet<BdOrdenCompraVendedor> BdOrdenCompraVendedor { get; set; }
        public virtual DbSet<BdPaseListaTecnico> BdPaseListaTecnico { get; set; }
        public virtual DbSet<BdPasoArNumber> BdPasoArNumber { get; set; }
        public virtual DbSet<BdPasoCambioStatusUnidadMasivo> BdPasoCambioStatusUnidadMasivo { get; set; }
        public virtual DbSet<BdPeriodoUsuarioInactivo> BdPeriodoUsuarioInactivo { get; set; }
        public virtual DbSet<BdPestanasBitacoraAr> BdPestanasBitacoraAr { get; set; }
        public virtual DbSet<BdPlazaCp> BdPlazaCp { get; set; }
        public virtual DbSet<BdPreciosLicenciaAndroid> BdPreciosLicenciaAndroid { get; set; }
        public virtual DbSet<BdPreciosLicenciaWeb> BdPreciosLicenciaWeb { get; set; }
        public virtual DbSet<BdPresupuestos> BdPresupuestos { get; set; }
        public virtual DbSet<BdPresupuestosEjercido> BdPresupuestosEjercido { get; set; }
        public virtual DbSet<BdPresupuestosRegional> BdPresupuestosRegional { get; set; }
        public virtual DbSet<BdProactivas> BdProactivas { get; set; }
        public virtual DbSet<BdProductoStatusAr> BdProductoStatusAr { get; set; }
        public virtual DbSet<BdPruebasUnitarias> BdPruebasUnitarias { get; set; }
        public virtual DbSet<BdRecepcionElavon> BdRecepcionElavon { get; set; }
        public virtual DbSet<BdRecepcionInsumos> BdRecepcionInsumos { get; set; }
        public virtual DbSet<BdRecoverPassword> BdRecoverPassword { get; set; }
        public virtual DbSet<BdReglasAsignacionAutomatica> BdReglasAsignacionAutomatica { get; set; }
        public virtual DbSet<BdReglasModelos> BdReglasModelos { get; set; }
        public virtual DbSet<BdReglasStatusAlmacen> BdReglasStatusAlmacen { get; set; }
        public virtual DbSet<BdReglasStatusAr> BdReglasStatusAr { get; set; }
        public virtual DbSet<BdReingresoSim> BdReingresoSim { get; set; }
        public virtual DbSet<BdReingresoUnidad> BdReingresoUnidad { get; set; }
        public virtual DbSet<BdRelacionFacturaEnvio> BdRelacionFacturaEnvio { get; set; }
        public virtual DbSet<BdReparacionUnidad> BdReparacionUnidad { get; set; }
        public virtual DbSet<BdReparecionesCargaPdf> BdReparecionesCargaPdf { get; set; }
        public virtual DbSet<BdReporteCierre> BdReporteCierre { get; set; }
        public virtual DbSet<BdReporteCierreAr> BdReporteCierreAr { get; set; }
        public virtual DbSet<BdReporteMovInventario> BdReporteMovInventario { get; set; }
        public virtual DbSet<BdRetiros> BdRetiros { get; set; }
        public virtual DbSet<BdServicioCausa> BdServicioCausa { get; set; }
        public virtual DbSet<BdServicioCausaRechazoPrecio> BdServicioCausaRechazoPrecio { get; set; }
        public virtual DbSet<BdServicioMovInv> BdServicioMovInv { get; set; }
        public virtual DbSet<BdServicioSegmento> BdServicioSegmento { get; set; }
        public virtual DbSet<BdServicioSolucion> BdServicioSolucion { get; set; }
        public virtual DbSet<BdServicioSolucionPrecio> BdServicioSolucionPrecio { get; set; }
        public virtual DbSet<BdServicioTipoFalla> BdServicioTipoFalla { get; set; }
        public virtual DbSet<BdServicioWeekhour> BdServicioWeekhour { get; set; }
        public virtual DbSet<BdServiciosFallas> BdServiciosFallas { get; set; }
        public virtual DbSet<BdServiciosFallasProyEspeciales> BdServiciosFallasProyEspeciales { get; set; }
        public virtual DbSet<BdSims> BdSims { get; set; }
        public virtual DbSet<BdSimsAlta> BdSimsAlta { get; set; }
        public virtual DbSet<BdSoftelPaso> BdSoftelPaso { get; set; }
        public virtual DbSet<BdSolicitudAlmacenComentario> BdSolicitudAlmacenComentario { get; set; }
        public virtual DbSet<BdSolicitudCorreo> BdSolicitudCorreo { get; set; }
        public virtual DbSet<BdSolicitudCorreoLog> BdSolicitudCorreoLog { get; set; }
        public virtual DbSet<BdSolicitudCorreoOki> BdSolicitudCorreoOki { get; set; }
        public virtual DbSet<BdSolicitudRecoleccion> BdSolicitudRecoleccion { get; set; }
        public virtual DbSet<BdSolicitudRecoleccionInsumos> BdSolicitudRecoleccionInsumos { get; set; }
        public virtual DbSet<BdSolicitudRecoleccionModelo> BdSolicitudRecoleccionModelo { get; set; }
        public virtual DbSet<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        public virtual DbSet<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
        public virtual DbSet<BdSolicitudesDevolucion> BdSolicitudesDevolucion { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionInsumos> BdSolicitudesDevolucionInsumos { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionItems> BdSolicitudesDevolucionItems { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionModelo> BdSolicitudesDevolucionModelo { get; set; }
        public virtual DbSet<BdSolicitudesDevolucionUnidad> BdSolicitudesDevolucionUnidad { get; set; }
        public virtual DbSet<BdSolicitudesViaticos> BdSolicitudesViaticos { get; set; }
        public virtual DbSet<BdSolicitudesViaticosConceptos> BdSolicitudesViaticosConceptos { get; set; }
        public virtual DbSet<BdSoporteTecnico> BdSoporteTecnico { get; set; }
        public virtual DbSet<BdSparePartPrecio> BdSparePartPrecio { get; set; }
        public virtual DbSet<BdStatusDoctoTipoResponsablePrefacturacion> BdStatusDoctoTipoResponsablePrefacturacion { get; set; }
        public virtual DbSet<BdStatusTipoUsuario> BdStatusTipoUsuario { get; set; }
        public virtual DbSet<BdStoreAltaManual> BdStoreAltaManual { get; set; }
        public virtual DbSet<BdSustituciones> BdSustituciones { get; set; }
        public virtual DbSet<BdTempActualizaTipoPlazaCliente> BdTempActualizaTipoPlazaCliente { get; set; }
        public virtual DbSet<BdTempCorreccion> BdTempCorreccion { get; set; }
        public virtual DbSet<BdTempServicioCierrePda> BdTempServicioCierrePda { get; set; }
        public virtual DbSet<BdTerminales> BdTerminales { get; set; }
        public virtual DbSet<BdTipoPlan> BdTipoPlan { get; set; }
        public virtual DbSet<BdTipoPlazaClienteCp> BdTipoPlazaClienteCp { get; set; }
        public virtual DbSet<BdTipoServicioProducto> BdTipoServicioProducto { get; set; }
        public virtual DbSet<BdTpvsAlta> BdTpvsAlta { get; set; }
        public virtual DbSet<BdTransacciones> BdTransacciones { get; set; }
        public virtual DbSet<BdTransaccionesPaso> BdTransaccionesPaso { get; set; }
        public virtual DbSet<BdTransaccionesRespaldo> BdTransaccionesRespaldo { get; set; }
        public virtual DbSet<BdTransferencias> BdTransferencias { get; set; }
        public virtual DbSet<BdTransferenciasPaso> BdTransferenciasPaso { get; set; }
        public virtual DbSet<BdTransferenciasUnidad> BdTransferenciasUnidad { get; set; }
        public virtual DbSet<BdUnidadAccesorio> BdUnidadAccesorio { get; set; }
        public virtual DbSet<BdUnidades> BdUnidades { get; set; }
        public virtual DbSet<BdUnidadesNoReportadas> BdUnidadesNoReportadas { get; set; }
        public virtual DbSet<BdUnidadesPasoTest> BdUnidadesPasoTest { get; set; }
        public virtual DbSet<BdUnidadesPorRecibirAlmacen> BdUnidadesPorRecibirAlmacen { get; set; }
        public virtual DbSet<BdUnidadesProcesadasAlmacen> BdUnidadesProcesadasAlmacen { get; set; }
        public virtual DbSet<BdUnidadesRefaccionesAlta> BdUnidadesRefaccionesAlta { get; set; }
        public virtual DbSet<BdUnidadesReportadas> BdUnidadesReportadas { get; set; }
        public virtual DbSet<BdUniversoSims> BdUniversoSims { get; set; }
        public virtual DbSet<BdUniversoUnidades> BdUniversoUnidades { get; set; }
        public virtual DbSet<BdUpdateIsContractNegocios> BdUpdateIsContractNegocios { get; set; }
        public virtual DbSet<BdUploadDhl> BdUploadDhl { get; set; }
        public virtual DbSet<BdUploadEstafeta> BdUploadEstafeta { get; set; }
        public virtual DbSet<BdUsuarioAlmacen> BdUsuarioAlmacen { get; set; }
        public virtual DbSet<BdUsuarioArchivosVarios> BdUsuarioArchivosVarios { get; set; }
        public virtual DbSet<BdUsuarioCelular> BdUsuarioCelular { get; set; }
        public virtual DbSet<BdUsuarioCliente> BdUsuarioCliente { get; set; }
        public virtual DbSet<BdUsuarioProducto> BdUsuarioProducto { get; set; }
        public virtual DbSet<BdUsuarioStatusUnidad> BdUsuarioStatusUnidad { get; set; }
        public virtual DbSet<BdUsuarioTecnico> BdUsuarioTecnico { get; set; }
        public virtual DbSet<BdUsuarioVistaEscalamiento> BdUsuarioVistaEscalamiento { get; set; }
        public virtual DbSet<BdUsuarioZona> BdUsuarioZona { get; set; }
        public virtual DbSet<BdUsuariosEnviarEmail> BdUsuariosEnviarEmail { get; set; }
        public virtual DbSet<BdUsuariosEnviorEmail2> BdUsuariosEnviorEmail2 { get; set; }
        public virtual DbSet<BdVacaciones> BdVacaciones { get; set; }
        public virtual DbSet<BdValMovimientosInvServicioFalla> BdValMovimientosInvServicioFalla { get; set; }
        public virtual DbSet<BdVistaEscalamientoStatusAr> BdVistaEscalamientoStatusAr { get; set; }
        public virtual DbSet<BdWincorClientes> BdWincorClientes { get; set; }
        public virtual DbSet<BdWincorClientesServicios> BdWincorClientesServicios { get; set; }
        public virtual DbSet<BdWincorServicios> BdWincorServicios { get; set; }
        public virtual DbSet<BdWorkload> BdWorkload { get; set; }
        public virtual DbSet<BdWsBancomer> BdWsBancomer { get; set; }
        public virtual DbSet<BdZonaCp> BdZonaCp { get; set; }
        public virtual DbSet<CAccesorios> CAccesorios { get; set; }
        public virtual DbSet<CActasAdmin> CActasAdmin { get; set; }
        public virtual DbSet<CAlmacenes> CAlmacenes { get; set; }
        public virtual DbSet<CArchivos> CArchivos { get; set; }
        public virtual DbSet<CAreas> CAreas { get; set; }
        public virtual DbSet<CBbvaMicroformasServicios> CBbvaMicroformasServicios { get; set; }
        public virtual DbSet<CBitacoraAgendadosComentarios> CBitacoraAgendadosComentarios { get; set; }
        public virtual DbSet<CCalifJunta> CCalifJunta { get; set; }
        public virtual DbSet<CCanales> CCanales { get; set; }
        public virtual DbSet<CCarrier> CCarrier { get; set; }
        public virtual DbSet<CCategoria> CCategoria { get; set; }
        public virtual DbSet<CCategoriaValidaDispositivos> CCategoriaValidaDispositivos { get; set; }
        public virtual DbSet<CCausaCancelacion> CCausaCancelacion { get; set; }
        public virtual DbSet<CCausaCancelacionSolicitudAlmacen> CCausaCancelacionSolicitudAlmacen { get; set; }
        public virtual DbSet<CCausaRetiro> CCausaRetiro { get; set; }
        public virtual DbSet<CCausas> CCausas { get; set; }
        public virtual DbSet<CCausasRechazo> CCausasRechazo { get; set; }
        public virtual DbSet<CCausasRechazoDefinitivoDoctoPrefacturacion> CCausasRechazoDefinitivoDoctoPrefacturacion { get; set; }
        public virtual DbSet<CCausasRechazoSegmento> CCausasRechazoSegmento { get; set; }
        public virtual DbSet<CChoferes> CChoferes { get; set; }
        public virtual DbSet<CClientes> CClientes { get; set; }
        public virtual DbSet<CClientesPmo> CClientesPmo { get; set; }
        public virtual DbSet<CCodigosIntervencionNivel0> CCodigosIntervencionNivel0 { get; set; }
        public virtual DbSet<CCodigosIntervencionNivel1> CCodigosIntervencionNivel1 { get; set; }
        public virtual DbSet<CCodigosIntervencionNivel2> CCodigosIntervencionNivel2 { get; set; }
        public virtual DbSet<CConceptoAr> CConceptoAr { get; set; }
        public virtual DbSet<CConceptosPmo> CConceptosPmo { get; set; }
        public virtual DbSet<CConectividad> CConectividad { get; set; }
        public virtual DbSet<CConsumibles> CConsumibles { get; set; }
        public virtual DbSet<CCpDarBbva94> CCpDarBbva94 { get; set; }
        public virtual DbSet<CCpProsa> CCpProsa { get; set; }
        public virtual DbSet<CDescripcionTrabajo> CDescripcionTrabajo { get; set; }
        public virtual DbSet<CDesviaciones> CDesviaciones { get; set; }
        public virtual DbSet<CDirecciones> CDirecciones { get; set; }
        public virtual DbSet<CDocsTir> CDocsTir { get; set; }
        public virtual DbSet<CDominiosEmail> CDominiosEmail { get; set; }
        public virtual DbSet<CElavonSantanderServicios> CElavonSantanderServicios { get; set; }
        public virtual DbSet<CEquipoCliente> CEquipoCliente { get; set; }
        public virtual DbSet<CEstadosDarBbva94> CEstadosDarBbva94 { get; set; }
        public virtual DbSet<CEtiquetaInformacionCierre> CEtiquetaInformacionCierre { get; set; }
        public virtual DbSet<CEtiquetaInformacionRechazo> CEtiquetaInformacionRechazo { get; set; }
        public virtual DbSet<CEtiquetaInformacionUnidad> CEtiquetaInformacionUnidad { get; set; }
        public virtual DbSet<CFallas> CFallas { get; set; }
        public virtual DbSet<CFallasEncontradas> CFallasEncontradas { get; set; }
        public virtual DbSet<CGrupos> CGrupos { get; set; }
        public virtual DbSet<CHorarios> CHorarios { get; set; }
        public virtual DbSet<CHoras> CHoras { get; set; }
        public virtual DbSet<CInsumos> CInsumos { get; set; }
        public virtual DbSet<CInsumosAlta> CInsumosAlta { get; set; }
        public virtual DbSet<CInsumosOld> CInsumosOld { get; set; }
        public virtual DbSet<CLlaves> CLlaves { get; set; }
        public virtual DbSet<CLogros> CLogros { get; set; }
        public virtual DbSet<CMarcas> CMarcas { get; set; }
        public virtual DbSet<CMcAutomoviles> CMcAutomoviles { get; set; }
        public virtual DbSet<CMcBoletos> CMcBoletos { get; set; }
        public virtual DbSet<CMcCasetas> CMcCasetas { get; set; }
        public virtual DbSet<CMcEstacionEvaluar> CMcEstacionEvaluar { get; set; }
        public virtual DbSet<CMcEstacionEvaluarReglas> CMcEstacionEvaluarReglas { get; set; }
        public virtual DbSet<CMcMedioTransporte> CMcMedioTransporte { get; set; }
        public virtual DbSet<CMcRutas> CMcRutas { get; set; }
        public virtual DbSet<CMcTopesMaximos> CMcTopesMaximos { get; set; }
        public virtual DbSet<CMcViaticosMotivos> CMcViaticosMotivos { get; set; }
        public virtual DbSet<CMcViaticosRazonesCancelacion> CMcViaticosRazonesCancelacion { get; set; }
        public virtual DbSet<CMenu> CMenu { get; set; }
        public virtual DbSet<CMenuCopia> CMenuCopia { get; set; }
        public virtual DbSet<CMinutos> CMinutos { get; set; }
        public virtual DbSet<CModelos> CModelos { get; set; }
        public virtual DbSet<CMonedas> CMonedas { get; set; }
        public virtual DbSet<CMovInv> CMovInv { get; set; }
        public virtual DbSet<CMovimientosInv> CMovimientosInv { get; set; }
        public virtual DbSet<CNivelReparacion> CNivelReparacion { get; set; }
        public virtual DbSet<CNombreCurso> CNombreCurso { get; set; }
        public virtual DbSet<CNombreJunta> CNombreJunta { get; set; }
        public virtual DbSet<CNotificacionesEmail> CNotificacionesEmail { get; set; }
        public virtual DbSet<COperadores> COperadores { get; set; }
        public virtual DbSet<CPlazas> CPlazas { get; set; }
        public virtual DbSet<CPrioridades> CPrioridades { get; set; }
        public virtual DbSet<CProductoDhl> CProductoDhl { get; set; }
        public virtual DbSet<CProductos> CProductos { get; set; }
        public virtual DbSet<CProductosNegocios> CProductosNegocios { get; set; }
        public virtual DbSet<CProveedoresUsuarios> CProveedoresUsuarios { get; set; }
        public virtual DbSet<CProyectos> CProyectos { get; set; }
        public virtual DbSet<CProyectosEspeciales> CProyectosEspeciales { get; set; }
        public virtual DbSet<CProyectosPmo> CProyectosPmo { get; set; }
        public virtual DbSet<CPuestos> CPuestos { get; set; }
        public virtual DbSet<CRazonDevolucion> CRazonDevolucion { get; set; }
        public virtual DbSet<CRegiones> CRegiones { get; set; }
        public virtual DbSet<CReparaciones> CReparaciones { get; set; }
        public virtual DbSet<CReporteMovInventario> CReporteMovInventario { get; set; }
        public virtual DbSet<CReportesRetipificados> CReportesRetipificados { get; set; }
        public virtual DbSet<CResponsables> CResponsables { get; set; }
        public virtual DbSet<CResponsablesAgendados> CResponsablesAgendados { get; set; }
        public virtual DbSet<CSedeCurso> CSedeCurso { get; set; }
        public virtual DbSet<CSegmentos> CSegmentos { get; set; }
        public virtual DbSet<CServicioMensajeria> CServicioMensajeria { get; set; }
        public virtual DbSet<CServicios> CServicios { get; set; }
        public virtual DbSet<CServiciosBancomer> CServiciosBancomer { get; set; }
        public virtual DbSet<CServiciosDobles> CServiciosDobles { get; set; }
        public virtual DbSet<CSoftware> CSoftware { get; set; }
        public virtual DbSet<CSoluciones> CSoluciones { get; set; }
        public virtual DbSet<CSpareParts> CSpareParts { get; set; }
        public virtual DbSet<CStatusAccesorio> CStatusAccesorio { get; set; }
        public virtual DbSet<CStatusAr> CStatusAr { get; set; }
        public virtual DbSet<CStatusArEq> CStatusArEq { get; set; }
        public virtual DbSet<CStatusCarga> CStatusCarga { get; set; }
        public virtual DbSet<CStatusCot3m> CStatusCot3m { get; set; }
        public virtual DbSet<CStatusCurso> CStatusCurso { get; set; }
        public virtual DbSet<CStatusDoctosPrefacturacion> CStatusDoctosPrefacturacion { get; set; }
        public virtual DbSet<CStatusEnvio> CStatusEnvio { get; set; }
        public virtual DbSet<CStatusInsumos> CStatusInsumos { get; set; }
        public virtual DbSet<CStatusItemsSolicitudAlmacen> CStatusItemsSolicitudAlmacen { get; set; }
        public virtual DbSet<CStatusJunta> CStatusJunta { get; set; }
        public virtual DbSet<CStatusOrdenCompra> CStatusOrdenCompra { get; set; }
        public virtual DbSet<CStatusReasonCodes> CStatusReasonCodes { get; set; }
        public virtual DbSet<CStatusReparacion> CStatusReparacion { get; set; }
        public virtual DbSet<CStatusReporteCierre> CStatusReporteCierre { get; set; }
        public virtual DbSet<CStatusSolicitudAlmacen> CStatusSolicitudAlmacen { get; set; }
        public virtual DbSet<CStatusSolicitudDevolucion> CStatusSolicitudDevolucion { get; set; }
        public virtual DbSet<CStatusSolicitudRecoleccion> CStatusSolicitudRecoleccion { get; set; }
        public virtual DbSet<CStatusSolicitudViaticos> CStatusSolicitudViaticos { get; set; }
        public virtual DbSet<CStatusUnidad> CStatusUnidad { get; set; }
        public virtual DbSet<CStatusUsuario> CStatusUsuario { get; set; }
        public virtual DbSet<CStatusValidacionPrefacturacion> CStatusValidacionPrefacturacion { get; set; }
        public virtual DbSet<CSubAlmacenes> CSubAlmacenes { get; set; }
        public virtual DbSet<CSubrechazo> CSubrechazo { get; set; }
        public virtual DbSet<CTecnicos> CTecnicos { get; set; }
        public virtual DbSet<CTiempoMedicion> CTiempoMedicion { get; set; }
        public virtual DbSet<CTiempoReferencia> CTiempoReferencia { get; set; }
        public virtual DbSet<CTiempos> CTiempos { get; set; }
        public virtual DbSet<CTimestamp> CTimestamp { get; set; }
        public virtual DbSet<CTipoAB> CTipoAB { get; set; }
        public virtual DbSet<CTipoArchivo> CTipoArchivo { get; set; }
        public virtual DbSet<CTipoAuditoria> CTipoAuditoria { get; set; }
        public virtual DbSet<CTipoCalculoUptime> CTipoCalculoUptime { get; set; }
        public virtual DbSet<CTipoCobro> CTipoCobro { get; set; }
        public virtual DbSet<CTipoCobroNegocio> CTipoCobroNegocio { get; set; }
        public virtual DbSet<CTipoDowntimeTrigger> CTipoDowntimeTrigger { get; set; }
        public virtual DbSet<CTipoFalla> CTipoFalla { get; set; }
        public virtual DbSet<CTipoFallaSegmento> CTipoFallaSegmento { get; set; }
        public virtual DbSet<CTipoInsumo> CTipoInsumo { get; set; }
        public virtual DbSet<CTipoInventario> CTipoInventario { get; set; }
        public virtual DbSet<CTipoItemOrdenCompra> CTipoItemOrdenCompra { get; set; }
        public virtual DbSet<CTipoItemSolicitudAlmacen> CTipoItemSolicitudAlmacen { get; set; }
        public virtual DbSet<CTipoLocalidad> CTipoLocalidad { get; set; }
        public virtual DbSet<CTipoPart> CTipoPart { get; set; }
        public virtual DbSet<CTipoPlaza> CTipoPlaza { get; set; }
        public virtual DbSet<CTipoPlazaCliente> CTipoPlazaCliente { get; set; }
        public virtual DbSet<CTipoPlazaNegocio> CTipoPlazaNegocio { get; set; }
        public virtual DbSet<CTipoPrecio> CTipoPrecio { get; set; }
        public virtual DbSet<CTipoProducto> CTipoProducto { get; set; }
        public virtual DbSet<CTipoResponsable> CTipoResponsable { get; set; }
        public virtual DbSet<CTipoResponsablePrefacturacion> CTipoResponsablePrefacturacion { get; set; }
        public virtual DbSet<CTipoServicio> CTipoServicio { get; set; }
        public virtual DbSet<CTipoServicioSolicitudAlmacen> CTipoServicioSolicitudAlmacen { get; set; }
        public virtual DbSet<CTipoSolicitudAlmacen> CTipoSolicitudAlmacen { get; set; }
        public virtual DbSet<CTipoSoporteTecnico> CTipoSoporteTecnico { get; set; }
        public virtual DbSet<CTipoSparePart> CTipoSparePart { get; set; }
        public virtual DbSet<CTipoUsuario> CTipoUsuario { get; set; }
        public virtual DbSet<CTipoZonaOld> CTipoZonaOld { get; set; }
        public virtual DbSet<CUnidadMensajeria> CUnidadMensajeria { get; set; }
        public virtual DbSet<CUpdateTablasBb> CUpdateTablasBb { get; set; }
        public virtual DbSet<CUrgenciaEnvio> CUrgenciaEnvio { get; set; }
        public virtual DbSet<CUrgenciaSolicitudAlmacen> CUrgenciaSolicitudAlmacen { get; set; }
        public virtual DbSet<CUsuarios> CUsuarios { get; set; }
        public virtual DbSet<CUsuariosCorporativo> CUsuariosCorporativo { get; set; }
        public virtual DbSet<CVendedores> CVendedores { get; set; }
        public virtual DbSet<CViaticos> CViaticos { get; set; }
        public virtual DbSet<CVistasEscalamiento> CVistasEscalamiento { get; set; }
        public virtual DbSet<CWeekDays> CWeekDays { get; set; }
        public virtual DbSet<CWeekhours> CWeekhours { get; set; }
        public virtual DbSet<CWincorEquivalenciasSgs> CWincorEquivalenciasSgs { get; set; }
        public virtual DbSet<CZonaAtencionSantander> CZonaAtencionSantander { get; set; }
        public virtual DbSet<CZonas> CZonas { get; set; }
        public virtual DbSet<CZonasAgenteCallCenter> CZonasAgenteCallCenter { get; set; }
        public virtual DbSet<CierresElavon> CierresElavon { get; set; }
        public virtual DbSet<ElavonInbox> ElavonInbox { get; set; }
        public virtual DbSet<ElavonOutbox> ElavonOutbox { get; set; }
        public virtual DbSet<Equipos> Equipos { get; set; }
        public virtual DbSet<ErroresArPrefacturacion> ErroresArPrefacturacion { get; set; }
        public virtual DbSet<HistoricoElavon> HistoricoElavon { get; set; }
        public virtual DbSet<HistoricoElavonPaso> HistoricoElavonPaso { get; set; }
        public virtual DbSet<NegociosBanamex> NegociosBanamex { get; set; }
        public virtual DbSet<NegociosBansefi> NegociosBansefi { get; set; }
        public virtual DbSet<NegociosBbva> NegociosBbva { get; set; }
        public virtual DbSet<NegociosBbvaWincor> NegociosBbvaWincor { get; set; }
        public virtual DbSet<NegociosBmxAtm> NegociosBmxAtm { get; set; }
        public virtual DbSet<NegociosBmxpl> NegociosBmxpl { get; set; }
        public virtual DbSet<NegociosBmxtnm> NegociosBmxtnm { get; set; }
        public virtual DbSet<NegociosFujitsuBajio> NegociosFujitsuBajio { get; set; }
        public virtual DbSet<NegociosFujitsuBanjercito> NegociosFujitsuBanjercito { get; set; }
        public virtual DbSet<NegociosFujitsuHsbc> NegociosFujitsuHsbc { get; set; }
        public virtual DbSet<NegociosFujitsuInd> NegociosFujitsuInd { get; set; }
        public virtual DbSet<NegociosGnp> NegociosGnp { get; set; }
        public virtual DbSet<NegociosHsbc> NegociosHsbc { get; set; }
        public virtual DbSet<NegociosHsbcFujitsu> NegociosHsbcFujitsu { get; set; }
        public virtual DbSet<NegociosHsbcWincor> NegociosHsbcWincor { get; set; }
        public virtual DbSet<NegociosMontepio> NegociosMontepio { get; set; }
        public virtual DbSet<NegociosSantander> NegociosSantander { get; set; }
        public virtual DbSet<NegociosSantanderWincor> NegociosSantanderWincor { get; set; }
        public virtual DbSet<NegociosSat> NegociosSat { get; set; }
        public virtual DbSet<NegociosSoftel> NegociosSoftel { get; set; }
        public virtual DbSet<NegociosTelefonica> NegociosTelefonica { get; set; }
        public virtual DbSet<ReporteHojaServicios> ReporteHojaServicios { get; set; }
        public virtual DbSet<SantanderOutbox> SantanderOutbox { get; set; }
        public virtual DbSet<SantanderOutboxCierre> SantanderOutboxCierre { get; set; }
        public virtual DbSet<Sepomex> Sepomex { get; set; }
        public virtual DbSet<SepomexEstados> SepomexEstados { get; set; }
        public virtual DbSet<SepomexOld> SepomexOld { get; set; }
        public virtual DbSet<SiBdLog> SiBdLog { get; set; }
        public virtual DbSet<SiCServicios> SiCServicios { get; set; }
        public virtual DbSet<TempAfiliaciones> TempAfiliaciones { get; set; }
        public virtual DbSet<TempHorarios> TempHorarios { get; set; }
        public virtual DbSet<TempNegocios> TempNegocios { get; set; }
        public virtual DbSet<TempUpdateNoInventario> TempUpdateNoInventario { get; set; }
        public virtual DbSet<UnidadesBnmAtm> UnidadesBnmAtm { get; set; }

        // Unable to generate entity type for table 'dbo.TABLA_BANCO_BBVA_REPORTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ABREVIATURA_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ERRORES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TablaTemporalPMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEST_DEPURA_INSUMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIO_MULTIVA_FECHA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PRUEBA_A'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DHL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_UPDATE_FEC_CIERRE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_TAREA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_TIPO_PLAZA_CLIENTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PREPORTE_INVENTARIOS_TPV_VERIFONE_SUSTITUCIONES_FECHA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_CALIFICA_PDF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_TEMO_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_PRODUCTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TABLA_REMESA_BBVA_REPORTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_NEGOCIOS_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_INGENICO_BANBAJIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ALTA_CANCELACION_AR_MASIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PRUEBAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_licencias_dhl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_INGENICO_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NO_SERIES_FALTANTES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_NOMINA_DETALLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SEPOMEX_ANTERIOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_segmento_banamex'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_INGENICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_WINCOR_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PRUEBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_horarios_santander'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_MIT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_OKI_SERVICIOS_CORRECTIVOS_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_CONSECUTIVO_3M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.respaldo_adam'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_SOLUCION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ASIENTOS_REGIONALES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ENVIO_UNIDAD_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIPO_CIERRE_TAREA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_TEDISA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temporal_respaldo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_CONSOLIDADO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PROSA_CORREGIDO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_VERIFON_ELAVON_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SLA_TEMP_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SLA_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO_FABRICANTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_STATUS_MODELO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICIOS_FEBRERO_2015'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO_INSTALADO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MOVMIENTOS_INV_ARCHIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICIOS_ENERO_2015'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PASO_TPV_REPORTE_SANTANDER_DIARIO_STOCK'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ENVIOS_CONSOLIDADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_CANCELAR_AR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERROR_UNIDADES_DANIADAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERVICIOS_CERRADOS_MES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pruebas_errores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.log_bd_negocios'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_TIPOS_DE_SERVICIOS_COSTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERV_TEC_CLTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.log_bd_negocios_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ENVIOS_SERVICIO_MENSAJERIAS_PRECIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SERV_TEC_CLT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.log_bd_negocios_3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.REFACCIONES_INSTALADAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_adam'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_CARGAS_MOV_RENGENIERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_SERVICIO_RETIRO_SIMS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_PRODUCTOS_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DIRECCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CANT_SERV_PROD_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_respaldo_afiliaciones'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AR_PDF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERRORES_CAMBIO_MODELOS_MASIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERROR_MASIVO_CONECTIVIDAD_APLICATIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPO_UNIDADES_SIM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_ALTA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VEHICULOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXISTENCIA_2_ALMACEN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_errores_carga'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_INSUMOS_AR_TECNICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PROVISION_INGRESO_REGION_PROD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRODUCTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERRORES_MASIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FILL_RATE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_POR_RECIBIR_ALMACEN2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MODELO_CONECT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PRUEBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_VIATICOS_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WINCOR_OUTBOX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Query'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MF_DISPERSION_INGENIERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PRUEBA_SP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WINCOR_INBOX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_STATUS_DOCTOS_PREFACTURACION_archivo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.INGRESOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_BODY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_REFACCIONES_ALMACEN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GUIAS_COSTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_FALLAS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GASOLINA_AVION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_QUESTS_CALLCENTER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_cARGAS_ARCHIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ARCHIVO1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ENVIOS_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_RESPONSABLE_CANCELACION_PROGRAMADO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EDO_RESULTADOS_REGION_PRODUCTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXISTENCIA_1_ALMACEN'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOG_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_UNIDADES_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EDO_RESULTADOS_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EDO_RESULTADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MODELOS_VALIDOS_EGLOBAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DISPERSION_NOMINA_CLIENTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_CARGA_LAYOUD_MASIVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DISPERSION_NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.costo_ref_ms'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_STATUS_UNIDAD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERRORES_CAMBIO_NO_SERIE_ACTUAL_NUEVO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_REF_MICROSIP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_IS_2015_02_BIS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_IS_2015_02'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REP_TPV_EGLOBAL_GRAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_IS_2015_01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_INGENIERO_2015_01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SANTANDER_INBOX_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_INGENIERO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bd_iata'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CLIENTE_PROD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_respaldo_c_usuarios'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_FUJITSU'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_CONSUMO_TRIMESTRAL_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_TESTIGO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AUDITORIA_REPORTE_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTE_AUDITORIA_INSUMOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_OKI_SERVICIOS_CORRECTIVOS_OKI'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_STATUS_SIM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AUDITORIA_REPORTE_2_TRASH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTE_AUDITORIA_UNIDAD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AUDITORIA_REPORTE_INSUMO_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_NEW_PRODUCTO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTE_AUDITORIA_UNIDAD_TRASH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_CONCEPTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TABLA_TEMPORAL_RETIRADA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIEMPOS_SERVICIOS_WINCOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_NEGOCIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_WINCOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUDITORIAS_REALIZADAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTE_TIPO_USUARIOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_OKI'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_BD_PRESUPUESTO_EJERCIDO_MENSUAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_MODEM_SOFTEL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ZONA_ESTADO_SEPOMEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTES_AUDITORIA_INSUMO_ING_ALM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MC_CASETAS_RUTAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_REPORTES_AUDITORIA_UNIDAD_ING_ALM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_WINCOR_FUJITSU'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ZONA_DAR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_RESPONSABLE_STATUS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ZONAS_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_MC_BOLETOS_RUTAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BITACORA_ERROR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ERROR_ASIGANACION_AUTOMATICA_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CAMBIO_ID_SEGMENTO_BANAMEX_TNM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BITACORA_MENSAJERIA_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_INGRESOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_COMPARATIVO_WINCOR_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BITACORA_SOLUCION_ERRORES_LEBERACION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_CLIENTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_inv_insumos_paso'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SERVICIO_SEGMENTO_TAREA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_inv_unidades_paso'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPO_MARCA_MODELO_BANAMEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DAR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LICENCIAS_REPORTE_ELAVON_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO_ACTUALIZACION_FECHA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIPO_OUTBOX_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_PRESUPUESTOS_CUBO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_COSTOS_MENSAJERIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SERVICIOS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DIAGNOSTICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO_MENU'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESULTADO_DIFERENCIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DIFERENCIAS_ULTIMA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEM_RESPALDO_BD_MENSAJERIA_COSTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_REGIONES_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_EMBARQUES_MENSAJERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEM_RESPALDO_COSTO_KG_ADD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_SIM_5'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SIMS_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_INFO_ERRORES_CARGA_MASIVA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CambioMasivoBdUnidades'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_ERROR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SI_DASHBOARD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_CONECTIVIDAD_SANTANDER_REPORTE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_ERRORES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CambioMasivoBdUnidades2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AR_PRODUCTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_HORARIOS_PERSONAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_F11_4'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOG_CARGA_MASIVA_TABLA_TOTAL_PROCESADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_FILL_RATE_BANCOMER_DISPONIBLE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_TIPO_REPARACION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO_C_PRODUCTOS_NEGOCIOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_EXTRAVIO_POR_MENSAJERIA_CARGA_MASIVA_PDF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_NEGOCIOS_BANAMEX_ATM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_FILL_RATE_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_ERRORES_CORREO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_CONSUMO_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_UPDATE_DIRECCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_PROCESADOS_CORREO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DISPONIBLE_BANCOMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_AR_TECNICO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DIR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_FILL_RATE_BBVA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CADENA_NOMINA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_CONTROL_INSUMOS_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_WINCOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MENSAJERIA_COSTOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_REGION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MENSAJERIA_CP_ZONAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_DIRECCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_OKI_SERVICIOS_CORRECTIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_INGRESO_MOV_INVENTARIOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SOLICITUD_VIATICOS_CONCEPTOS_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_COSTO_REFACCIONES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cdosysmail_failures'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_COSTO_VIATICOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_Carga_unidades'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BACKUP_BD_ZONAS_CP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ERRORES_PMO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.HISTORICO_BBVA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_QUERY_MODELO_CONECTIVIDAD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_LOGS_CARGA_MASIVA_TABLA_ERRORES_CORREO2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRESUPUESTOS_CUBO_NEW'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_MEDIDA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_PRUEBA_NO_SERIES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_MODULO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_SUBMODULO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tabla_prueba_consolidado'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_WINCOR_TIPO_MEDIDA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_REPORTE_RETIROS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_DISPONIBLES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RESPALDO_TABLA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMPORAL_2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UNIDADES_TRANSITO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FILL_RATE_ELAVON'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FILL_RATE_OTROS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COSTO_KG_ADD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.REPORTE_F11'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_OPCIONES_REINGENIERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_ORDENES_COMPRA_EVIDENCIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_SOLICITUDES_VIATICOS_CONCEPTOS_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_STATUS_USUARIO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_SURTIDO_MENSAJERIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MODELOS_HOMOLOGADOS_SANTANDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.C_BANCOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MODELOS_MODIFICADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_3M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_MULTIVA_DIARIO_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BD_BITACORA_CAMBIO_MASIVO_DANIADA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_NEGOCIOS_BANAMEX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TABLA_PRUEBA_PASO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TEMP_REPORTE_INVENTARIOS_BANAMEX_TNM_FECHA'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.100.56;Persist Security Info=True;connect timeout=400000;Database=ELAVON;User Id=sa;Password=b4ckl45h;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BdActasAdmin>(entity =>
            {
                entity.HasKey(e => e.IdActaAdmin)
                    .HasName("PK_BD_ACTA_ADMIN");

                entity.Property(e => e.Comentarios).IsUnicode(false);

                entity.Property(e => e.StatusActaAdmin).IsUnicode(false);
            });

            modelBuilder.Entity<BdAfiliacionesProyectoEspecial>(entity =>
            {
                entity.Property(e => e.IsProcesado).IsUnicode(false);
            });

            modelBuilder.Entity<BdAjustesInsumosPaso>(entity =>
            {
                entity.HasKey(e => e.IdAjuste)
                    .HasName("PK__BD_AJUST__7C4D8AC8DBD55290");
            });

            modelBuilder.Entity<BdAltaFecGarantia>(entity =>
            {
                entity.HasKey(e => e.IdAlta)
                    .HasName("PK__BD_ALTA___149699216FD7BF73");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdAltaMasivaUnidadCa>(entity =>
            {
                entity.HasKey(e => e.IdUnidadCa)
                    .HasName("PK__BD_ALTA___052710832B92C76C");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdAr>(entity =>
            {
                entity.HasIndex(e => e.HorasGarantia)
                    .HasName("IX_BD_AR");

                entity.HasIndex(e => e.IdCarga)
                    .HasName("missing_index_2708_2707");

                entity.HasIndex(e => e.IdProveedor)
                    .HasName("IX_BD_AR_1");

                entity.HasIndex(e => e.IdRegion)
                    .HasName("missing_index_4018_4017");

                entity.HasIndex(e => e.IdTecnico)
                    .HasName("missing_index_3618_3617");

                entity.HasIndex(e => e.IdZona)
                    .HasName("missing_index_61_60");

                entity.HasIndex(e => e.MiComercio)
                    .HasName("IX_BD_AR_3");

                entity.HasIndex(e => e.NoAfiliacion)
                    .HasName("missing_index_3491_3490");

                entity.HasIndex(e => e.NoAr)
                    .HasName("missing_index_167_166");

                entity.HasIndex(e => e.Rp)
                    .HasName("IX_BD_AR_4");

                entity.HasIndex(e => e.Rs)
                    .HasName("IX_BD_AR_5");

                entity.HasIndex(e => e.VoltajeNeutro)
                    .HasName("IX_BD_AR_6");

                entity.HasIndex(e => e.VoltajeTierra)
                    .HasName("IX_BD_AR_7");

                entity.HasIndex(e => e.VoltajeTierraNeutro)
                    .HasName("IX_BD_AR_8");

                entity.HasIndex(e => new { e.Cp, e.NoAr })
                    .HasName("missing_index_3318_3317");

                entity.HasIndex(e => new { e.FecAlta, e.NoAr })
                    .HasName("missing_index_1762_1761");

                entity.HasIndex(e => new { e.IdAr, e.IdStatusAr })
                    .HasName("missing_index_2815_2814");

                entity.HasIndex(e => new { e.IdAr, e.NoAr })
                    .HasName("missing_index_1760_1759");

                entity.HasIndex(e => new { e.IdCarga, e.Status })
                    .HasName("missing_index_903_902");

                entity.HasIndex(e => new { e.IdStatusAr, e.Status })
                    .HasName("missing_index_1096_1095");

                entity.HasIndex(e => new { e.NoAr, e.IdStatusAr })
                    .HasName("missing_index_2860_2859");

                entity.HasIndex(e => new { e.NoAr, e.Status })
                    .HasName("missing_index_6_5");

                entity.HasIndex(e => new { e.Status, e.IdCarga })
                    .HasName("missing_index_187_186");

                entity.HasIndex(e => new { e.Status, e.IdStatusAr })
                    .HasName("missing_index_118_117");

                entity.HasIndex(e => new { e.Status, e.NoAr })
                    .HasName("missing_index_2_1");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.Status })
                    .HasName("missing_index_184_183");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.IdCarga })
                    .HasName("missing_index_180_179");

                entity.HasIndex(e => new { e.IdCarga, e.IdCliente, e.NoAr })
                    .HasName("missing_index_161_160");

                entity.HasIndex(e => new { e.IdCarga, e.NoAr, e.IdStatusAr })
                    .HasName("missing_index_122_121");

                entity.HasIndex(e => new { e.IdCliente, e.NoAr, e.IdAr })
                    .HasName("missing_index_159_158");

                entity.HasIndex(e => new { e.IdCliente, e.NoAr, e.IdCarga })
                    .HasName("missing_index_178_177");

                entity.HasIndex(e => new { e.IdFalla, e.IdStatusAr, e.NoAfiliacion })
                    .HasName("missing_index_46_45");

                entity.HasIndex(e => new { e.IdServicio, e.Status, e.IdStatusAr })
                    .HasName("missing_index_1224_1223");

                entity.HasIndex(e => new { e.IdStatusAr, e.Status, e.IdProveedor })
                    .HasName("missing_index_1157_1156");

                entity.HasIndex(e => new { e.NoAfiliacion, e.IdFalla, e.IdStatusAr })
                    .HasName("missing_index_49_48");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Status, e.IdStatusAr })
                    .HasName("missing_index_2932_2931");

                entity.HasIndex(e => new { e.NoAr, e.IdStatusAr, e.Status })
                    .HasName("missing_index_3476_3475");

                entity.HasIndex(e => new { e.NoAr, e.Status, e.IdStatusAr })
                    .HasName("missing_index_252_251");

                entity.HasIndex(e => new { e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_63_62");

                entity.HasIndex(e => new { e.TerminalAmex, e.Status, e.IdStatusAr })
                    .HasName("missing_index_3478_3477");

                entity.HasIndex(e => new { e.IdNegocio, e.IdProyecto, e.FecCierre, e.IdStatusAr })
                    .HasName("missing_index_165_164");

                entity.HasIndex(e => new { e.IdServicio, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_2743_2742");

                entity.HasIndex(e => new { e.IdServicio, e.TerminalAmex, e.Status, e.IdStatusAr })
                    .HasName("missing_index_4016_4015");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_3487_3486");

                entity.HasIndex(e => new { e.NoAr, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_1145_1144");

                entity.HasIndex(e => new { e.IdAr, e.FecInicio, e.HorasGarantia, e.FecAlta, e.FecAtencion, e.FecGarantia, e.IdStatusAr, e.IdProyecto })
                    .HasName("missing_index_4135_4134");

                entity.HasIndex(e => new { e.IdAr, e.FecInicio, e.HorasGarantia, e.FecAlta, e.FecAtencion, e.FecGarantia, e.IdStatusAr, e.IdProyecto, e.IdServicio, e.IdFalla })
                    .HasName("missing_index_4132_4131");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.NoAr, e.Cp, e.IdSegmento, e.IdServicio, e.IdFalla, e.HorasGarantia, e.IdTecnico, e.IdCarga, e.Status })
                    .HasName("missing_index_189_188");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.NoAr, e.NoAfiliacion, e.DescNegocio, e.Poblacion, e.Estado, e.Cp, e.IdSegmento, e.IdServicio, e.IdFalla, e.HorasGarantia, e.IdTecnico, e.IdCarga, e.Status })
                    .HasName("missing_index_192_191");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.NoAr, e.NoAfiliacion, e.Telefono, e.DescNegocio, e.Direccion, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.Segmento, e.TipoServicio, e.TipoFalla, e.IdProyecto, e.IdCarga, e.Status })
                    .HasName("missing_index_157_156");

                entity.HasIndex(e => new { e.IdAr, e.IdCliente, e.NoAr, e.NoAfiliacion, e.Cp, e.Segmento, e.TipoServicio, e.TipoFalla, e.IdSegmento, e.IdServicio, e.IdFalla, e.HorasGarantia, e.PrecioExito, e.IdEstado, e.IdRegion, e.IdZona, e.IdTecnico, e.IdProyecto, e.IdCarga, e.Status })
                    .HasName("missing_index_198_197");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.IdCliente, e.NoAr, e.Concepto, e.DescCorta, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.DescNegocio, e.FecInicio, e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.IdTecnico, e.FecGarantia, e.FecCierre, e.DescripcionTrabajo, e.IsExito, e.IdProducto, e.ClaveRechazo, e.IdStatusAr, e.Status, e.IdProveedor })
                    .HasName("missing_index_4101_4100");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.IdCliente, e.NoAr, e.Concepto, e.DescCorta, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.DescNegocio, e.FecInicio, e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.IdTecnico, e.FecGarantia, e.FecCierre, e.DescripcionTrabajo, e.IsExito, e.IdProducto, e.ClaveRechazo, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_4098_4097");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.IdCliente, e.NoAr, e.Concepto, e.DescCorta, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.DescNegocio, e.FecInicio, e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.IdTecnico, e.FecAlta, e.FecGarantia, e.FecCierre, e.DescripcionTrabajo, e.IsExito, e.IdProducto, e.ClaveRechazo, e.IdProveedor, e.IdStatusAr, e.Status })
                    .HasName("missing_index_3806_3805");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.IdCliente, e.NoAr, e.Concepto, e.DescCorta, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.DescNegocio, e.FecInicio, e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.IdTecnico, e.FecAlta, e.FecGarantia, e.FecCierre, e.DescripcionTrabajo, e.IsExito, e.IdProducto, e.ClaveRechazo, e.Status, e.IdProveedor, e.IdStatusAr })
                    .HasName("missing_index_4007_4006");

                entity.HasIndex(e => new { e.IdAr, e.NoAr, e.Sintoma, e.Bitacora, e.NoAfiliacion, e.Telefono, e.DescNegocio, e.Direccion, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.Equipo, e.DescEquipo, e.FecInicio, e.IdSegmento, e.IdServicio, e.IdFalla, e.IdTecnico, e.FecAtencion, e.FecGarantia, e.FecCierre, e.IntensidadSenial, e.DescripcionTrabajo, e.Atiende, e.IdCausaRechazo, e.IdProyecto, e.IdProducto, e.MotivoRetipificado, e.DigitoVerificador, e.Insumos, e.Caja, e.ClaveRechazo, e.IdTipoEquipo, e.CorreoEjecutivo, e.TerminalAmex, e.DireccionAlternaComercio, e.IdProveedor, e.IdRegion, e.Status, e.IdStatusAr })
                    .HasName("missing_index_4014_4013");

                entity.HasIndex(e => new { e.IdAr, e.IdCarga, e.IdCliente, e.NoAr, e.NoAfiliacion, e.Estado, e.Cp, e.Equipo, e.Segmento, e.NoSerie, e.FecInicio, e.FecConvenio, e.IdSegmento, e.IdServicio, e.IdFalla, e.IdRegion, e.IdZona, e.IdTipoPlaza, e.IdPlaza, e.IdTecnico, e.FecAlta, e.FecAtencion, e.FecGarantia, e.FecCierre, e.FecAltaHorasAtencion, e.IdUsuarioCierre, e.IdCausa, e.IdSolucion, e.NoEquipo, e.IsSimRemplazada, e.IdCausaRechazo, e.CausaRechazo, e.CausaCancelacion, e.IsExito, e.IdProyecto, e.VoltajeTierra, e.NoSim, e.IdConectividad, e.IdAplicativo, e.FolioTelecarga, e.IdTipoEquipo, e.CorreoEjecutivo, e.IdProveedor, e.Status, e.IdStatusAr })
                    .HasName("missing_index_3620_3619");

                entity.Property(e => e.Atiende).IsUnicode(false);

                entity.Property(e => e.AutorizadorRechazo).IsUnicode(false);

                entity.Property(e => e.Bitacora).IsUnicode(false);

                entity.Property(e => e.CadenaCierre).IsUnicode(false);

                entity.Property(e => e.CadenaCierreEscrita).IsUnicode(false);

                entity.Property(e => e.Caja).IsUnicode(false);

                entity.Property(e => e.CausaCancelacion).IsUnicode(false);

                entity.Property(e => e.CausaRechazo).IsUnicode(false);

                entity.Property(e => e.ClaveRechazo).IsUnicode(false);

                entity.Property(e => e.CodigoIntervencion).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Concepto).IsUnicode(false);

                entity.Property(e => e.CorreoEjecutivo).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.DescCorta).IsUnicode(false);

                entity.Property(e => e.DescEquipo).IsUnicode(false);

                entity.Property(e => e.DescNegocio).IsUnicode(false);

                entity.Property(e => e.DescripcionTrabajo).IsUnicode(false);

                entity.Property(e => e.DigitoVerificador).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.DueBy).IsUnicode(false);

                entity.Property(e => e.Duracion).IsUnicode(false);

                entity.Property(e => e.Equipo).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.FallaEncontrada).IsUnicode(false);

                entity.Property(e => e.FolioServicio).IsUnicode(false);

                entity.Property(e => e.FolioTas).IsUnicode(false);

                entity.Property(e => e.FolioTir).IsUnicode(false);

                entity.Property(e => e.FolioValidacion).IsUnicode(false);

                entity.Property(e => e.IntensidadSenial).IsUnicode(false);

                entity.Property(e => e.MinsDowntime).HasDefaultValueSql("((0))");

                entity.Property(e => e.MotivoCobro).IsUnicode(false);

                entity.Property(e => e.MotivoRetipificado).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.NoAr).IsUnicode(false);

                entity.Property(e => e.NoEquipo).IsUnicode(false);

                entity.Property(e => e.NoInventario).IsUnicode(false);

                entity.Property(e => e.NoInventarioFalla).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.NoSerieFalla).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.NotasRemedy).IsUnicode(false);

                entity.Property(e => e.OtorganteSoporteCliente).IsUnicode(false);

                entity.Property(e => e.OtorganteTas).IsUnicode(false);

                entity.Property(e => e.OtorganteVobo).IsUnicode(false);

                entity.Property(e => e.OtorganteVoboCliente).IsUnicode(false);

                entity.Property(e => e.OtorganteVoboTerceros).IsUnicode(false);

                entity.Property(e => e.PersonaAtenderaComercio).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.ProveedorAtenderaComercio).IsUnicode(false);

                entity.Property(e => e.Responsable).IsUnicode(false);

                entity.Property(e => e.Sintoma).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.TelefonoComercio).IsUnicode(false);

                entity.Property(e => e.VoltajeNeutro).IsUnicode(false);

                entity.Property(e => e.VoltajeTierra).IsUnicode(false);

                entity.Property(e => e.VoltajeTierraNeutro).IsUnicode(false);
            });

            modelBuilder.Entity<BdArAccesorios>(entity =>
            {
                entity.HasKey(e => e.IdArAccesorio)
                    .HasName("PK__BD_AR_AC__3C0DB632687A5639");

                entity.HasIndex(e => e.IdAr)
                    .HasName("missing_index_ACCESORIOS_ID_AR");

                entity.Property(e => e.Base).IsUnicode(false);

                entity.Property(e => e.Bateria).IsUnicode(false);

                entity.Property(e => e.CableAc).IsUnicode(false);

                entity.Property(e => e.Eliminador).IsUnicode(false);

                entity.Property(e => e.Tapa).IsUnicode(false);
            });

            modelBuilder.Entity<BdArArchivosVarios>(entity =>
            {
                entity.HasIndex(e => new { e.IdAr, e.Status, e.NombreArchivoUsuario })
                    .HasName("IX_BD_AR_ARCHIVOS_VARIOS_ID_AR, STATUS");

                entity.HasIndex(e => new { e.IdArArchivoVarios, e.IdAr, e.NombreArchivoSistema, e.NombreArchivoUsuario, e.Status })
                    .HasName("IX_BD_AR_ARCHIVOS_VARIOS");

                entity.Property(e => e.NombreArchivoSistema).IsUnicode(false);

                entity.Property(e => e.NombreArchivoUsuario).IsUnicode(false);

                entity.Property(e => e.Ruta).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdArCausasCancelacion>(entity =>
            {
                entity.HasKey(e => e.IdArCausaCancelacion)
                    .HasName("PK__BD_AR_CA__DCE7FEACEBEBAB20");
            });

            modelBuilder.Entity<BdArCierreManual>(entity =>
            {
                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_BD_AR_CIERRE_MANUAL");

                entity.HasIndex(e => e.IdCierreMasivo)
                    .HasName("IX_BD_AR_CIERRE_MANUAL_1");
            });

            modelBuilder.Entity<BdArDatosComerciosExtra>(entity =>
            {
                entity.HasKey(e => e.IdArDatoComercioExtra)
                    .HasName("PK__BD_AR_DA__F4BBDEAE0F219F6C");

                entity.Property(e => e.NoAr).IsUnicode(false);

                entity.Property(e => e.PersonaAtendera).IsUnicode(false);

                entity.Property(e => e.ProveedorAtendera).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<BdArDesviacion>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.HasOne(d => d.IdDesviacionNavigation)
                    .WithMany(p => p.BdArDesviacion)
                    .HasForeignKey(d => d.IdDesviacion)
                    .HasConstraintName("FK_BD_AR_DESVIACION_C_DESVIACIONES");
            });

            modelBuilder.Entity<BdArDiasAtencion>(entity =>
            {
                entity.HasKey(e => e.IdArDiasAtencion)
                    .HasName("PK__BD_AR_DI__1FA76D7F34B45D23");

                entity.HasIndex(e => e.FecAlta)
                    .HasName("IX_BD_AR_DIAS_ATENCION_1");

                entity.HasIndex(e => e.IdAr)
                    .HasName("missing_index_448_447");

                entity.HasIndex(e => new { e.Lunes, e.Martes, e.Miercoles, e.Jueves, e.Viernes, e.Sabado, e.Domingo, e.IdUsuarioAlta, e.FecAlta, e.IdAr })
                    .HasName("missing_index_1843_1842");
            });

            modelBuilder.Entity<BdArExtension>(entity =>
            {
                entity.Property(e => e.Motivo2TaquetesAdicionales).IsUnicode(false);

                entity.Property(e => e.MotivoBlindajeTuercaSeguridad).IsUnicode(false);

                entity.Property(e => e.MotivoFotografias).IsUnicode(false);

                entity.Property(e => e.MotivoInstalacionPlacaFrontal).IsUnicode(false);

                entity.Property(e => e.MotivoInstalacionPlacaLateral).IsUnicode(false);

                entity.Property(e => e.MotivoSustitucion4Tuercas).IsUnicode(false);

                entity.Property(e => e.OtorganteVoboIngPartner).IsUnicode(false);

                entity.Property(e => e.PersonalBanco).IsUnicode(false);

                entity.Property(e => e.ReporteServicioPartner).IsUnicode(false);
            });

            modelBuilder.Entity<BdArFecGarantia>(entity =>
            {
                entity.HasKey(e => e.IdArFecGarantia)
                    .HasName("PK__BD_AR_FE__8E7CE109CCF2D87C");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdArInsumo>(entity =>
            {
                entity.HasIndex(e => new { e.IsMicrosip, e.ControlMicrosip })
                    .HasName("IX_BD_AR_INSUMO");
            });

            modelBuilder.Entity<BdArLogWs>(entity =>
            {
                entity.HasKey(e => e.IdArLogWs)
                    .HasName("PK__BD_AR_LO__198419D80AD9AB5B");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.Estatus).IsUnicode(false);

                entity.Property(e => e.NoAr).IsUnicode(false);
            });

            modelBuilder.Entity<BdArMiComercio>(entity =>
            {
                entity.HasKey(e => e.IdArMiComercio)
                    .HasName("PK__BD_AR_MI__75E1F5CA2ED5E011");

                entity.Property(e => e.Telefono1).IsUnicode(false);

                entity.Property(e => e.Telefono2).IsUnicode(false);
            });

            modelBuilder.Entity<BdArPaso>(entity =>
            {
                entity.HasKey(e => e.IdArPaso)
                    .HasName("PK__BD_AR_PA__74E2F80DC95D8C1E");

                entity.Property(e => e.AfiliacionTerminalAmex).IsUnicode(false);

                entity.Property(e => e.AsociadaTerminal).IsUnicode(false);

                entity.Property(e => e.CajaId).IsUnicode(false);

                entity.Property(e => e.CantidadRollos).IsUnicode(false);

                entity.Property(e => e.Contacto).IsUnicode(false);

                entity.Property(e => e.CorreoEjecutivo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DiasAtencion).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.DireccionAlterna).IsUnicode(false);

                entity.Property(e => e.Dom).IsUnicode(false);

                entity.Property(e => e.FecInicio).IsUnicode(false);

                entity.Property(e => e.FolioTelecarga).IsUnicode(false);

                entity.Property(e => e.Hri).IsUnicode(false);

                entity.Property(e => e.Htf).IsUnicode(false);

                entity.Property(e => e.IdProducto).IsUnicode(false);

                entity.Property(e => e.IdTecnico).IsUnicode(false);

                entity.Property(e => e.IdTerminalAmex).IsUnicode(false);

                entity.Property(e => e.IsProgramado).IsUnicode(false);

                entity.Property(e => e.Jue).IsUnicode(false);

                entity.Property(e => e.Lun).IsUnicode(false);

                entity.Property(e => e.Mar).IsUnicode(false);

                entity.Property(e => e.Mie).IsUnicode(false);

                entity.Property(e => e.Minf).IsUnicode(false);

                entity.Property(e => e.Mini).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.NombreComercio).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Odt).IsUnicode(false);

                entity.Property(e => e.PersonaAtiendeComercio).IsUnicode(false);

                entity.Property(e => e.ProveedorComercio).IsUnicode(false);

                entity.Property(e => e.ProveedorServicio).IsUnicode(false);

                entity.Property(e => e.Responsable).IsUnicode(false);

                entity.Property(e => e.Sab).IsUnicode(false);

                entity.Property(e => e.SubtipoServicio).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.TelefonoComercio).IsUnicode(false);

                entity.Property(e => e.Timeh).IsUnicode(false);

                entity.Property(e => e.Timem).IsUnicode(false);

                entity.Property(e => e.TipoAb).IsUnicode(false);

                entity.Property(e => e.TipoComercio).IsUnicode(false);

                entity.Property(e => e.TipoServicio).IsUnicode(false);

                entity.Property(e => e.Vie).IsUnicode(false);
            });

            modelBuilder.Entity<BdArPrefacturacion>(entity =>
            {
                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdAr, e.Counter, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.Status })
                    .HasName("IX_BD_AR_PREFACTURACION_ID_TIPO_RESPONSABLE_DOCTO_PREFACTURACION_FISICO, ID_STATUS_DOCTO_PREFACTURACION_FISICO, STATUS");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdAr, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.IdTipoResponsableDoctoPrefacturacionDigital, e.IdStatusDoctoPrefacturacionDigital, e.Status })
                    .HasName("IX_MI_BD_AR_PREFACTURACION_6509_6508");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdAr, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.IdTipoResponsableDoctoPrefacturacionDigital, e.IdStatusDoctoPrefacturacionDigital, e.Status })
                    .HasName("IX_MI_BD_AR_PREFACTURACION_13804_13803");

                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdTipoResponsableDoctoPrefacturacionFisico, e.IdResponsableDoctoPrefacturacionFisico, e.IdStatusDoctoPrefacturacionFisico, e.IdTipoResponsableDoctoPrefacturacionDigital, e.IdStatusDoctoPrefacturacionDigital, e.IdAr, e.Status })
                    .HasName("IX_BD_AR_PREFACTURACION_ID_AR, STATUS");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdArSparePart>(entity =>
            {
                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdArSparePart)
                    .HasForeignKey(d => d.IdSparePart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_AR_SPARE_PART_C_SPARE_PARTS");
            });

            modelBuilder.Entity<BdArTerminalAsociadaAmex>(entity =>
            {
                entity.HasKey(e => e.IdArTerminalAsociadaAmex)
                    .HasName("PK__BD_AR_TE__007BB9C43669A860");

                entity.HasIndex(e => e.AfiliacionTerminalAmex)
                    .HasName("IX_BD_AR_TERMINAL_ASOCIADA_AMEX_1");

                entity.HasIndex(e => e.FecAlta)
                    .HasName("IX_BD_AR_TERMINAL_ASOCIADA_AMEX");

                entity.HasIndex(e => e.IdAr)
                    .HasName("missing_index_260_259");

                entity.HasIndex(e => e.IdUsuarioAlta)
                    .HasName("IX_BD_AR_TERMINAL_ASOCIADA_AMEX_2");

                entity.Property(e => e.AfiliacionTerminalAmex).IsUnicode(false);

                entity.Property(e => e.IdTerminalAmex).IsUnicode(false);
            });

            modelBuilder.Entity<BdArViatico>(entity =>
            {
                entity.HasOne(d => d.IdViaticoNavigation)
                    .WithMany(p => p.BdArViatico)
                    .HasForeignKey(d => d.IdViatico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_AR_VIATICO_C_VIATICOS");
            });

            modelBuilder.Entity<BdArViaticoMotivo>(entity =>
            {
                entity.Property(e => e.NoAr).IsUnicode(false);
            });

            modelBuilder.Entity<BdArVisitas>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoCobroNavigation)
                    .WithMany(p => p.BdArVisitas)
                    .HasForeignKey(d => d.IdTipoCobro)
                    .HasConstraintName("FK_BD_AR_VISITAS_C_TIPO_COBRO");
            });

            modelBuilder.Entity<BdArchivoDispersionSolicitudViaticos>(entity =>
            {
                entity.HasIndex(e => e.IdArchivoDispersion)
                    .HasName("IX_MI_BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS_5743_5742");

                entity.HasIndex(e => e.IdSolicitudViaticos);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdArchivoDispersionNavigation)
                    .WithMany(p => p.BdArchivoDispersionSolicitudViaticos)
                    .HasForeignKey(d => d.IdArchivoDispersion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS_BD_ARCHIVOS_DISPERSION");

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdArchivoDispersionSolicitudViaticos)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdArchivosConfirmaciones>(entity =>
            {
                entity.Property(e => e.NombreArchivoConfirmacionesSystem).IsUnicode(false);

                entity.Property(e => e.NombreArchivoConfirmacionesUser).IsUnicode(false);

                entity.HasOne(d => d.IdCargaConfirmacionesNavigation)
                    .WithMany(p => p.BdArchivosConfirmaciones)
                    .HasForeignKey(d => d.IdCargaConfirmaciones)
                    .HasConstraintName("FK_BD_ARCHIVOS_CONFIRMACIONES_BD_CARGAS_CONFIRMACIONES");
            });

            modelBuilder.Entity<BdArchivosDispersion>(entity =>
            {
                entity.HasKey(e => e.IdArchivoDispersion)
                    .HasName("PK_BD_ARCHIVO_DISPERSION");

                entity.Property(e => e.Carpeta).IsUnicode(false);

                entity.Property(e => e.NombreArchivoDispersion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdArchivosPrefacturacion>(entity =>
            {
                entity.HasIndex(e => new { e.IdArchivoPrefacturacion, e.NombreArchivoPrefacturacionSystem, e.IdArPrefacturacion })
                    .HasName("IX_BD_ARCHIVOS_PREFACTURACION_ID_AR_PREFACTURACION");

                entity.Property(e => e.NombreArchivoPrefacturacionSystem).IsUnicode(false);

                entity.Property(e => e.NombreArchivoPrefacturacionUser).IsUnicode(false);
            });

            modelBuilder.Entity<BdAsignacionAutomaticaPaso>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionAutomaticaPaso)
                    .HasName("PK__BD_ASIGN__E220F956EE46FDF0");

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Mensaje).IsUnicode(false);
            });

            modelBuilder.Entity<BdAttach>(entity =>
            {
                entity.HasIndex(e => new { e.DescAttach, e.SystemFilename, e.IdUsuarioAlta })
                    .HasName("IX_MI_BD_ATTACH_26_25");

                entity.Property(e => e.DescAttach).IsUnicode(false);

                entity.Property(e => e.SystemFilename).IsUnicode(false);

                entity.Property(e => e.UserFilename).IsUnicode(false);
            });

            modelBuilder.Entity<BdAttachAcciones>(entity =>
            {
                entity.Property(e => e.DescAttach).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.SystemFilename).IsUnicode(false);

                entity.Property(e => e.UserFilename).IsUnicode(false);
            });

            modelBuilder.Entity<BdAttachDhl>(entity =>
            {
                entity.HasKey(e => e.IdAttachDhl)
                    .HasName("PK__BD_ATTAC__9661FD0AB2A16046");

                entity.Property(e => e.NoFactura).IsUnicode(false);

                entity.Property(e => e.NombreArchivoSistema).IsUnicode(false);

                entity.Property(e => e.NombreArchivoUsuario).IsUnicode(false);
            });

            modelBuilder.Entity<BdAuditoriaCierres>(entity =>
            {
                entity.HasKey(e => e.IdAuditoriaCierres)
                    .HasName("PK__BD_AUDIT__C883666ED8295865");

                entity.Property(e => e.Accion).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Proceso).IsUnicode(false);

                entity.Property(e => e.TablaAfectada).IsUnicode(false);
            });

            modelBuilder.Entity<BdAuditoriaProcesosInternos>(entity =>
            {
                entity.Property(e => e.Proceso).IsUnicode(false);
            });

            modelBuilder.Entity<BdAuditoriaReporte>(entity =>
            {
                entity.Property(e => e.Reporte).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdAuditoriaNavigation)
                    .WithMany(p => p.BdAuditoriaReporte)
                    .HasForeignKey(d => d.IdAuditoria)
                    .HasConstraintName("FK_BD_AUDITORIA_REPORTE_BD_AUDITORIAS");

                entity.HasOne(d => d.IdTipoInventarioNavigation)
                    .WithMany(p => p.BdAuditoriaReporte)
                    .HasForeignKey(d => d.IdTipoInventario)
                    .HasConstraintName("FK_BD_AUDITORIA_REPORTE_C_TIPO_INVENTARIO");
            });

            modelBuilder.Entity<BdAuditorias>(entity =>
            {
                entity.Property(e => e.DescAuditoria).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoAuditoriaNavigation)
                    .WithMany(p => p.BdAuditorias)
                    .HasForeignKey(d => d.IdTipoAuditoria)
                    .HasConstraintName("FK_BD_AUDITORIAS_C_TIPO_AUDITORIA");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdAuditorias)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_AUDITORIAS_C_USUARIOS");
            });

            modelBuilder.Entity<BdBbvaPaso>(entity =>
            {
                entity.HasKey(e => e.IdBbvaPaso)
                    .HasName("PK__BD_BBVA___E65BC1FA0EFA7622");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.From).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraAcceso>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK_BD_BITACORA");

                entity.HasIndex(e => new { e.IdUsuario, e.Status })
                    .HasName("IX_BD_BITACORA_ACCESO_STATUS");

                entity.HasIndex(e => new { e.IdBitacora, e.Status, e.IdUsuario })
                    .HasName("IX_BD_BITACORA_ACCESO_ID_USUARIO");

                entity.Property(e => e.Host).IsUnicode(false);

                entity.Property(e => e.IpCliente).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraAgendados>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraAgendado)
                    .HasName("PK_BD_BITACORA_AGENDADO");

                entity.Property(e => e.Autorizador).IsUnicode(false);

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.FolioTir).IsUnicode(false);

                entity.HasOne(d => d.IdResponsableAgendadoNavigation)
                    .WithMany(p => p.BdBitacoraAgendados)
                    .HasForeignKey(d => d.IdResponsableAgendado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_AGENDADOS_C_RESPONSABLES_AGENDADOS");
            });

            modelBuilder.Entity<BdBitacoraAlmacenResponsable>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraAlmacenResponsable)
                    .HasName("PK__BD_BITAC__C7B56735102FD125");
            });

            modelBuilder.Entity<BdBitacoraAlmacenStatus>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK__BD_BITAC__44E70BF3CBD33EC1");

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraAplicativoUnidad>(entity =>
            {
                entity.HasKey(e => e.IdAplicativoUnidad)
                    .HasName("PK__BD_BITAC__5AD934711BCD189D");

                entity.HasIndex(e => e.IdUnidad)
                    .HasName("missing_index_3577761_3577760");
            });

            modelBuilder.Entity<BdBitacoraAr>(entity =>
            {
                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_BD_BITACORA_AR");

                entity.HasIndex(e => e.IdUsuarioAlta)
                    .HasName("IX_BD_BITACORA_AR_3");

                entity.HasIndex(e => new { e.FecAlta, e.IdAr })
                    .HasName("IX_BD_BITACORA_AR_2");

                entity.HasIndex(e => new { e.IdAr, e.Comentario })
                    .HasName("IX_BD_BITACORA_AR_1");

                entity.HasIndex(e => new { e.IdAr, e.FecAlta, e.IdStatusArFin })
                    .HasName("IX_BD_BITACORA_AR_ID_STATUS_AR_FIN");

                entity.HasIndex(e => new { e.IdBitacoraAr, e.IdAr, e.Comentario, e.IdStatusArFin })
                    .HasName("IX_BD_BITACORA_AR_4");

                entity.HasIndex(e => new { e.IdAr, e.FecAlta, e.IdStatusArIni, e.IdStatusArFin, e.Comentario })
                    .HasName("IX_BD_BITACORA_AR_ID_AR_FEC_ALTA");

                entity.Property(e => e.Comentario).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraArAlta>(entity =>
            {
                entity.HasKey(e => e.IdArBitacoraArAlta)
                    .HasName("PK__BD_BITAC__98F6235C730E7EEE");

                entity.HasIndex(e => e.IdAr)
                    .HasName("missing_index_170_169");
            });

            modelBuilder.Entity<BdBitacoraBdNegocios>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraBdNegocios)
                    .HasName("PK__BD_BITAC__0E4591F6D23E286C");

                entity.Property(e => e.ColoniaActual).IsUnicode(false);

                entity.Property(e => e.ColoniaAnterior).IsUnicode(false);

                entity.Property(e => e.CpActual).IsUnicode(false);

                entity.Property(e => e.CpAnterior).IsUnicode(false);

                entity.Property(e => e.DescNegocioActual).IsUnicode(false);

                entity.Property(e => e.DescNegocioAnterior).IsUnicode(false);

                entity.Property(e => e.DireccionActual).IsUnicode(false);

                entity.Property(e => e.DireccionAnterior).IsUnicode(false);

                entity.Property(e => e.EstadoActual).IsUnicode(false);

                entity.Property(e => e.EstadoAnterior).IsUnicode(false);

                entity.Property(e => e.LatitudActual).IsUnicode(false);

                entity.Property(e => e.LatitudAnterior).IsUnicode(false);

                entity.Property(e => e.LongitudActual).IsUnicode(false);

                entity.Property(e => e.LongitudAnterior).IsUnicode(false);

                entity.Property(e => e.NoAfiliacionActual).IsUnicode(false);

                entity.Property(e => e.NoAfiliacionAnterior).IsUnicode(false);

                entity.Property(e => e.PoblacionActual).IsUnicode(false);

                entity.Property(e => e.PoblacionAnterior).IsUnicode(false);

                entity.Property(e => e.PrecioActual).IsUnicode(false);

                entity.Property(e => e.PrecioAnterior).IsUnicode(false);

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);

                entity.Property(e => e.TelefonoActual).IsUnicode(false);

                entity.Property(e => e.TelefonoAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraCambioMensajeria>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCambioMensajeria)
                    .HasName("PK__BD_BITAC__DE3FA500EC2545D0");
            });

            modelBuilder.Entity<BdBitacoraCambioNoInventario>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCambioNoInventario)
                    .HasName("PK__BD_BITAC__F428328E38F56859");

                entity.Property(e => e.NoInventario).IsUnicode(false);

                entity.Property(e => e.Serie).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraCambioSerie>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK__BD_BITAC__44E70BF307B4B974");

                entity.Property(e => e.NoSerieNew).IsUnicode(false);

                entity.Property(e => e.Serie).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraCambioUnidadNueva>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCambioUnidadNueva)
                    .HasName("PK__BD_BITAC__26B9B0F3A536F58F");

                entity.HasIndex(e => new { e.IdUnidad, e.IsNueva })
                    .HasName("missing_index_55770_55769");
            });

            modelBuilder.Entity<BdBitacoraCierresOdt>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraCierresOdt)
                    .HasName("PK__BD_BITAC__5CC8F318F131E199");

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraCompromisos>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraConectividadUnidad>(entity =>
            {
                entity.HasKey(e => e.IdConectividadUnidad)
                    .HasName("PK__BD_BITAC__0532997335CA4CCA");

                entity.HasIndex(e => e.IdUnidad)
                    .HasName("missing_index_3577759_3577758");
            });

            modelBuilder.Entity<BdBitacoraDiagnostico>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraDiagnostico)
                    .HasName("PK_BD_BITACORA_DIAGNOSTICO_1");

                entity.HasIndex(e => e.IdUnidad);
            });

            modelBuilder.Entity<BdBitacoraDoctosPrefacturacion>(entity =>
            {
                entity.HasIndex(e => new { e.IdArPrefacturacion, e.IdStatusDoctoPrefacturacionFin })
                    .HasName("IX_BD_BITACORA_DOCTOS_PREFACTURACION_ID_AR_PREFACTURACION, ID_STATUS_DOCTO_PREFACTURACION_FIN");

                entity.Property(e => e.Comentario).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraEnvio>(entity =>
            {
                entity.HasIndex(e => e.IdEnvio)
                    .HasName("IX_MI_BD_BITACORA_ENVIO_9263_9262");

                entity.Property(e => e.Comentario).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraIgualas>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.StatusFin).IsUnicode(false);

                entity.Property(e => e.StatusIni).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraInsumo)
                    .HasName("PK_BD_BITACORA_INSUMO");

                entity.HasOne(d => d.IdStatusInsumoFinNavigation)
                    .WithMany(p => p.BdBitacoraInsumosIdStatusInsumoFinNavigation)
                    .HasForeignKey(d => d.IdStatusInsumoFin)
                    .HasConstraintName("FK_BD_BITACORA_INSUMOS_C_STATUS_INSUMOS1");

                entity.HasOne(d => d.IdStatusInsumoIniNavigation)
                    .WithMany(p => p.BdBitacoraInsumosIdStatusInsumoIniNavigation)
                    .HasForeignKey(d => d.IdStatusInsumoIni)
                    .HasConstraintName("FK_BD_BITACORA_INSUMOS_C_STATUS_INSUMOS");

                entity.HasOne(d => d.IdTipoResponsableNavigation)
                    .WithMany(p => p.BdBitacoraInsumos)
                    .HasForeignKey(d => d.IdTipoResponsable)
                    .HasConstraintName("FK_BD_BITACORA_INSUMOS_C_TIPO_RESPONSABLE");
            });

            modelBuilder.Entity<BdBitacoraItemsBorrados>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraItemsBorrados)
                    .HasName("PK__BD_BITAC__7B29BB006838319E");
            });

            modelBuilder.Entity<BdBitacoraItemsSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraItemsSolicitudAlmacen)
                    .HasName("PK_C_BITACORA_ITEMS_SOLICITUD_ALMACEN");

                entity.HasIndex(e => e.IdItemsSolicitudAlmacen);

                entity.Property(e => e.Comentario).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraModeloUnidad>(entity =>
            {
                entity.HasIndex(e => e.IdUnidad);

                entity.HasOne(d => d.IdModeloNuevoNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidadIdModeloNuevoNavigation)
                    .HasForeignKey(d => d.IdModeloNuevo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_C_MODELOS");

                entity.HasOne(d => d.IdModeloViejoNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidadIdModeloViejoNavigation)
                    .HasForeignKey(d => d.IdModeloViejo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_C_MODELOS1");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_BD_UNIDADES");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdBitacoraModeloUnidad)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_MODELO_UNIDAD_C_USUARIOS");
            });

            modelBuilder.Entity<BdBitacoraMovimientosRetornosInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraMri)
                    .HasName("PK__BD_BITAC__8E656FDB0DD2385A");

                entity.Property(e => e.IdConsolidado)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(((((CONVERT([varchar],datepart(day,getdate()),(0))+CONVERT([varchar],datepart(month,getdate()),(0)))+CONVERT([varchar],datepart(year,getdate()),(0)))+'_')+CONVERT([varchar],datepart(hour,getdate()),(0)))+CONVERT([varchar],datepart(minute,getdate()),(0)))");
            });

            modelBuilder.Entity<BdBitacoraNegociosCoordenadas>(entity =>
            {
                entity.HasKey(e => e.IdBitcoraNegocioCoordenada)
                    .HasName("PK__BD_BITAC__BA413A8D76CC7CD8");
            });

            modelBuilder.Entity<BdBitacoraNoInsumoAr>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraNoInsumoAr)
                    .HasName("PK__BD_BITAC__126B50BDE7877995");

                entity.Property(e => e.Causa).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraOdtOnbaseConfirmacion>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraOdtOnbaseConfirmacion)
                    .HasName("PK__BD_BITAC__CB69D503EFF88BFD");
            });

            modelBuilder.Entity<BdBitacoraProcedure>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraProcedure)
                    .HasName("PK__BD_BITAC__2A24B496DD081A42");

                entity.Property(e => e.Descripcion).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraProducto>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraProducto)
                    .HasName("PK__BD_BITAC__586DE537DD73E260");

                entity.Property(e => e.DescProducto).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraPropiedadCliente>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraPropiedadCliente)
                    .HasName("PK__BD_BITAC__D07251D722B0844E");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraPropiedadCliente)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK__BD_BITACO__ID_UN__258CF0F9");
            });

            modelBuilder.Entity<BdBitacoraReasignacionTecnicos>(entity =>
            {
                entity.HasIndex(e => new { e.IdBitacora, e.IdUsuarioAnterior, e.IdUsuarioAsignado, e.IdUsuarioCambio, e.IdReparacionUnidad })
                    .HasName("IX_MI_BD_BITACORA_REASIGNACION_TECNICOS_85_84");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraRechazosEnvios>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraRechazo)
                    .HasName("PK__BD_BITAC__F048B2F65F2362EA");
            });

            modelBuilder.Entity<BdBitacoraServicios>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraServicios)
                    .HasName("PK__BD_BITAC__E2FFADA2928C1D14");

                entity.Property(e => e.CodigoActual).IsUnicode(false);

                entity.Property(e => e.CodigoAnterior).IsUnicode(false);

                entity.Property(e => e.DescServicioActual).IsUnicode(false);

                entity.Property(e => e.DescServicioAnterior).IsUnicode(false);

                entity.Property(e => e.IsCallCenterActual).IsUnicode(false);

                entity.Property(e => e.IsCallCenterAnterior).IsUnicode(false);

                entity.Property(e => e.IsProyectoActual).IsUnicode(false);

                entity.Property(e => e.IsProyectoAnterior).IsUnicode(false);

                entity.Property(e => e.MinPromedioActual).IsUnicode(false);

                entity.Property(e => e.MinPromedioAnterior).IsUnicode(false);

                entity.Property(e => e.NoDiasActual).IsUnicode(false);

                entity.Property(e => e.NoDiasAnterior).IsUnicode(false);

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraServiciosFalla>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraServiciosFalla)
                    .HasName("PK__BD_BITAC__7C30246C0ED2DBD8");

                entity.Property(e => e.Accion).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraSolicitudDevolucion>(entity =>
            {
                entity.HasOne(d => d.IdStatusSolicitudDevolucionFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudDevolucionFin)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_DEVOLUCION_C_STATUS_SOLICITUD_DEVOLUCION1");

                entity.HasOne(d => d.IdStatusSolicitudDevolucionIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudDevolucionIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_DEVOLUCION_C_STATUS_SOLICITUD_DEVOLUCION");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudDevolucion)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_DEVOLUCION_C_USUARIOS");
            });

            modelBuilder.Entity<BdBitacoraSolicitudRecoleccion>(entity =>
            {
                entity.HasIndex(e => new { e.IdBitacoraSolicitudRecoleccion, e.IdUsuarioAlta, e.IdSolicitudRecoleccion })
                    .HasName("IX_MI_BD_BITACORA_SOLICITUD_RECOLECCION_132815_132814");

                entity.HasIndex(e => new { e.IdBitacoraSolicitudRecoleccion, e.IdStatusSolicitudRecoleccionIni, e.IdStatusSolicitudRecoleccionFin, e.IdUsuarioAlta, e.FecAlta, e.IdSolicitudRecoleccion })
                    .HasName("IX_BD_BITACORA_SOLICITUD_RECOLECCION_ID_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdSolicitudRecoleccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_RECOLECCION_BD_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdStatusSolicitudRecoleccionFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudRecoleccionFin)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_RECOLECCION_C_STATUS_SOLICITUD_RECOLECCION1");

                entity.HasOne(d => d.IdStatusSolicitudRecoleccionIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudRecoleccionIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUD_RECOLECCION_C_STATUS_SOLICITUD_RECOLECCION");
            });

            modelBuilder.Entity<BdBitacoraSolicitudesAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraSolicitudAlmacen)
                    .HasName("PK_BD_BITACORA_SOLICITUD_ALMACEN");

                entity.HasIndex(e => e.IdSolicitudAlmacen);

                entity.HasOne(d => d.IdStatusSolicitudAlmacenFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudAlmacenFin)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_ALMACEN_C_STATUS_SOLICITUD_ALMACEN1");

                entity.HasOne(d => d.IdStatusSolicitudAlmacenIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudAlmacenIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_ALMACEN_C_STATUS_SOLICITUD_ALMACEN");
            });

            modelBuilder.Entity<BdBitacoraSolicitudesViaticos>(entity =>
            {
                entity.HasIndex(e => e.IdSolicitudViaticos);

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesViaticos)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_VIATICOS_BD_SOLICITUDES_VIATICOS1");

                entity.HasOne(d => d.IdStatusSolicitudViaticosFinNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosFinNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudViaticosFin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_VIATICOS_C_STATUS_SOLICITUD_VIATICOS");

                entity.HasOne(d => d.IdStatusSolicitudViaticosIniNavigation)
                    .WithMany(p => p.BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosIniNavigation)
                    .HasForeignKey(d => d.IdStatusSolicitudViaticosIni)
                    .HasConstraintName("FK_BD_BITACORA_SOLICITUDES_VIATICOS_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdBitacoraStatusTipoUsuario>(entity =>
            {
                entity.Property(e => e.Cambio).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraSubServicios>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraSubServicios)
                    .HasName("PK__BD_BITAC__09FA6FC819490277");

                entity.Property(e => e.DescFallaActual).IsUnicode(false);

                entity.Property(e => e.DescFallaAnterior).IsUnicode(false);

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraTipoCausaCancelacion>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraTipoCausaCancelacion)
                    .HasName("PK__BD_BITAC__CE758421A9725650");

                entity.Property(e => e.DescCausaCancelacionActual).IsUnicode(false);

                entity.Property(e => e.DescCausaCancelacionAnterior).IsUnicode(false);

                entity.Property(e => e.IdTipoCanceladoActual).IsUnicode(false);

                entity.Property(e => e.IdTipoCanceladoAnterior).IsUnicode(false);

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraTipoCusasRechazo>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraTipoCusasRechazo)
                    .HasName("PK__BD_BITAC__1C11FD8D75AF8607");

                entity.Property(e => e.DescCausaRechazoActual).IsUnicode(false);

                entity.Property(e => e.DescCausaRechazoAnterior).IsUnicode(false);

                entity.Property(e => e.IdTrechazoActual).IsUnicode(false);

                entity.Property(e => e.IdTrechazoAnterior).IsUnicode(false);

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraTipoPlazaCliente>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraTipoPlazaCliente)
                    .HasName("PK__BD_BITAC__1337F659E1B53E23");

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraTipoProductoNegocio>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraTipoProductoNegocio)
                    .HasName("PK__BD_BITAC__8636BE2695A8E7FD");

                entity.Property(e => e.DescProductoNegocioActual).IsUnicode(false);

                entity.Property(e => e.DescProductoNegocioAnterior).IsUnicode(false);

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraTipoSubrechazo>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraTipoSubrechazo)
                    .HasName("PK__BD_BITAC__3D8C8A32A70B2E1A");

                entity.Property(e => e.IdActual).IsUnicode(false);

                entity.Property(e => e.IdAnterior).IsUnicode(false);

                entity.Property(e => e.StatusActual).IsUnicode(false);

                entity.Property(e => e.StatusAnterior).IsUnicode(false);

                entity.Property(e => e.SubrechazoActual).IsUnicode(false);

                entity.Property(e => e.SubrechazoAnterior).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraTransferencias>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraTransferencia)
                    .HasName("PK__BD_BITAC__02A9C9E40A0794DC");

                entity.Property(e => e.Comentarios).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraUnidad>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraUnidad)
                    .HasName("PK_BD_BITACORA_UNDIAD");

                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdUnidad, e.IdUsuarioAlta, e.IdStatusUnidadIni, e.IdStatusUnidadFin })
                    .HasName("IX_BD_BITACORA_UNIDAD_ID_STATUS_UNIDAD_INI, ID_STATUS_UNIDAD_FIN");

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.HasOne(d => d.IdStatusUnidadFinNavigation)
                    .WithMany(p => p.BdBitacoraUnidadIdStatusUnidadFinNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadFin)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_C_STATUS_UNIDAD1");

                entity.HasOne(d => d.IdStatusUnidadIniNavigation)
                    .WithMany(p => p.BdBitacoraUnidadIdStatusUnidadIniNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadIni)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_C_STATUS_UNIDAD");

                entity.HasOne(d => d.IdTipoResponsableNavigation)
                    .WithMany(p => p.BdBitacoraUnidad)
                    .HasForeignKey(d => d.IdTipoResponsable)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_BITACORA_UNIDAD_BD_UNIDADES");
            });

            modelBuilder.Entity<BdBitacoraUnidadDanada>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraUnidadDanada)
                    .HasName("PK__BD_BITAC__628C55831EDFF36A");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdBitacoraUnidadDanada)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK__BD_BITACO__ID_UN__2498CCC0");
            });

            modelBuilder.Entity<BdBitacoraUnidadesFaltantesRecibo>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraUnidadFaltante)
                    .HasName("PK__BD_BITAC__69286212EA1FF754");

                entity.Property(e => e.FecEnvio).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraValidacionDevoluciones>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);
            });

            modelBuilder.Entity<BdBitacoraValidacionPrefacturacion>(entity =>
            {
                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_MI_BD_BITACORA_VALIDACION_PREFACTURACION_22_21");

                entity.HasIndex(e => new { e.IdAr, e.IdStatusFin })
                    .HasName("IX_MI_BD_BITACORA_VALIDACION_PREFACTURACION_7149_7148");

                entity.HasIndex(e => new { e.IdBitacoraValidacionPrefacturacion, e.FecAlta, e.IdAr })
                    .HasName("IX_MI_BD_BITACORA_VALIDACION_PREFACTURACION_20_19");

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Documento).IsUnicode(false);
            });

            modelBuilder.Entity<BdBloqueos>(entity =>
            {
                entity.HasIndex(e => e.NoAfiliacion)
                    .HasName("IX_BD_BLOQUEOS_2");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Bloqueo })
                    .HasName("missing_index_149702_149701");

                entity.HasIndex(e => new { e.NoAfiliacion, e.TotalRollos })
                    .HasName("missing_index_145827_145826");

                entity.HasIndex(e => new { e.Proveedor, e.Territorio, e.NoAfiliacion })
                    .HasName("IX_BD_BLOQUEOS_1");

                entity.HasIndex(e => new { e.Month, e.Year, e.NoAfiliacion, e.Bloqueo })
                    .HasName("IX_BD_BLOQUEOS");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Proveedor, e.Bloqueo, e.Mensaje, e.TotalRollos })
                    .HasName("missing_index_139814_139813");

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);
            });

            modelBuilder.Entity<BdBloqueosPaso>(entity =>
            {
                entity.HasIndex(e => e.NoAfiliacion)
                    .HasName("missing_index_411720_411719");

                entity.HasIndex(e => new { e.IdBloqueoPaso, e.IdCarga })
                    .HasName("missing_index_656385_656384");

                entity.HasIndex(e => new { e.IsError, e.IdCarga })
                    .HasName("missing_index_139437_139436");

                entity.HasIndex(e => new { e.IdBloqueoPaso, e.Cp, e.IdCarga })
                    .HasName("missing_index_139426_139425");

                entity.HasIndex(e => new { e.Month, e.Year, e.NoAfiliacion, e.Cp, e.Proveedor, e.Territorio, e.TotalRollos, e.Bloqueo, e.Mensaje, e.IdCarga, e.IsError })
                    .HasName("missing_index_139428_139427");

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);
            });

            modelBuilder.Entity<BdBloqueosRespaldo>(entity =>
            {
                entity.HasKey(e => e.IdBloqueoRespaldo)
                    .HasName("PK__BD_BLOQU__5AB20C33E2465819");

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Mensaje).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Proveedor).IsUnicode(false);

                entity.Property(e => e.Territorio).IsUnicode(false);
            });

            modelBuilder.Entity<BdCambioStatusAr>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdStatusArFinNavigation)
                    .WithMany(p => p.BdCambioStatusArIdStatusArFinNavigation)
                    .HasForeignKey(d => d.IdStatusArFin)
                    .HasConstraintName("FK_BD_CAMBIO_STATUS_AR_C_STATUS_AR1");

                entity.HasOne(d => d.IdStatusArIniNavigation)
                    .WithMany(p => p.BdCambioStatusArIdStatusArIniNavigation)
                    .HasForeignKey(d => d.IdStatusArIni)
                    .HasConstraintName("FK_BD_CAMBIO_STATUS_AR_C_STATUS_AR");
            });

            modelBuilder.Entity<BdCambiosEstatusPermititdosUnidades>(entity =>
            {
                entity.HasKey(e => e.IdCambioEstatusPermitido)
                    .HasName("PK__BD_CAMBI__1400EDE2B204FB6C");
            });

            modelBuilder.Entity<BdCargaChangeComentarios>(entity =>
            {
                entity.HasKey(e => e.IdCarga)
                    .HasName("PK__BD_CARGA__6F4DBE3D4BF698DC");
            });

            modelBuilder.Entity<BdCargaChangeStatus>(entity =>
            {
                entity.HasKey(e => e.IdCarga)
                    .HasName("PK__BD_CARGA__6F4DBE3DE5A8AF5D");
            });

            modelBuilder.Entity<BdCargaCierresMasivosTexto>(entity =>
            {
                entity.Property(e => e.AfiliacionAmex).IsUnicode(false);

                entity.Property(e => e.Comentarios).IsUnicode(false);

                entity.Property(e => e.IdAmex).IsUnicode(false);

                entity.Property(e => e.MensajeError).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaCierresMasivosTextoMit>(entity =>
            {
                entity.Property(e => e.AfiliacionAmex).IsUnicode(false);

                entity.Property(e => e.Comentarios).IsUnicode(false);

                entity.Property(e => e.IdAmex).IsUnicode(false);

                entity.Property(e => e.MensajeError).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaCodigoRechazo>(entity =>
            {
                entity.HasKey(e => e.IdCargaCodigoRechazo)
                    .HasName("PK__BD_CARGA__9461935AF3B0596E");

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.NoAr).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaEnviosDhlErrores>(entity =>
            {
                entity.HasKey(e => e.IdCargaEnvioDhlError)
                    .HasName("PK__BD_CARGA__62D6306DF418DE4F");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.NoGuia).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaEnviosDhlPaso>(entity =>
            {
                entity.HasKey(e => e.IdCargaEnvioDhl)
                    .HasName("PK__BD_CARGA__BC7F1400F3F8A6F1");

                entity.Property(e => e.Des).IsUnicode(false);

                entity.Property(e => e.Destinatario).IsUnicode(false);

                entity.Property(e => e.Moneda).IsUnicode(false);

                entity.Property(e => e.NoFactura).IsUnicode(false);

                entity.Property(e => e.NoGuia).IsUnicode(false);

                entity.Property(e => e.NoReferencia).IsUnicode(false);

                entity.Property(e => e.Org).IsUnicode(false);

                entity.Property(e => e.Producto).IsUnicode(false);

                entity.Property(e => e.Proyecto).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);

                entity.Property(e => e.Remitente).IsUnicode(false);

                entity.Property(e => e.ZonaProd).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaEnviosEstafetaPaso>(entity =>
            {
                entity.HasKey(e => e.IdCargaEnvioEstafetaPaso)
                    .HasName("PK__BD_CARGA__020B7B5CABCED9CF");

                entity.Property(e => e.Dest).IsUnicode(false);

                entity.Property(e => e.Guia).IsUnicode(false);

                entity.Property(e => e.Orig).IsUnicode(false);

                entity.Property(e => e.Recibe).IsUnicode(false);

                entity.Property(e => e.Referencia).IsUnicode(false);

                entity.Property(e => e.TipoEmpaque).IsUnicode(false);

                entity.Property(e => e.VolReal).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargaUnidadNoInventario>(entity =>
            {
                entity.HasKey(e => e.IdCargaUnidadNoInventario)
                    .HasName("PK__BD_CARGA__E3B81BA20B8F49BE");

                entity.Property(e => e.NoInventarion).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargas>(entity =>
            {
                entity.HasIndex(e => new { e.IdCarga, e.IdCliente, e.IdUsuarioAlta, e.Status })
                    .HasName("IX_BD_CARGAS_ID_USUARIO_ALTA, STATUS");

                entity.HasIndex(e => new { e.IdCarga, e.IdCliente, e.IdUsuarioAlta, e.Status, e.IdStatusCarga })
                    .HasName("IX_MI_BD_CARGAS_4850_4849");

                entity.HasIndex(e => new { e.IdCarga, e.IdUsuarioAlta, e.IdCliente, e.Status, e.IdStatusCarga })
                    .HasName("IX_MI_BD_CARGAS_8_7");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargasConfirmaciones>(entity =>
            {
                entity.HasKey(e => e.IdCargaConfirmaciones)
                    .HasName("PK_BD_CARGAS_CONFIRMACION");

                entity.HasIndex(e => new { e.IdCargaConfirmaciones, e.IdUsuarioAlta, e.Status, e.IdStatusCargaConfirmaciones })
                    .HasName("IX_MI_BD_CARGAS_CONFIRMACIONES_5628_5627");

                entity.Property(e => e.NombreCargaConfirmaciones).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargasEquipo>(entity =>
            {
                entity.HasKey(e => e.IdCargaEquipo)
                    .HasName("PK__BD_CARGA__CD35B7D4765C8BF8");
            });

            modelBuilder.Entity<BdCargasMasivas>(entity =>
            {
                entity.Property(e => e.DescAttach).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCargasOdtElavon>(entity =>
            {
                entity.HasIndex(e => e.Afiliacion)
                    .HasName("missing_index_4092_4091");

                entity.HasIndex(e => e.Ar)
                    .HasName("missing_index_3630_3629");

                entity.HasIndex(e => new { e.Afiliacion, e.Idproyecto })
                    .HasName("missing_index_4104_4103");

                entity.HasIndex(e => new { e.Ar, e.Estatus })
                    .HasName("missing_index_3722_3721");

                entity.HasIndex(e => new { e.IdCarga, e.Estatus })
                    .HasName("missing_index_3986_3985");

                entity.HasIndex(e => new { e.IdProceso, e.Ar })
                    .HasName("missing_index_4_3");

                entity.HasIndex(e => new { e.IdProceso, e.Estatus })
                    .HasName("missing_index_3669_3668");

                entity.HasIndex(e => new { e.Afiliacion, e.Estado, e.IdProceso })
                    .HasName("missing_index_24_23");

                entity.HasIndex(e => new { e.Estado, e.IdProceso, e.Afiliacion })
                    .HasName("missing_index_21_20");

                entity.HasIndex(e => new { e.IdProceso, e.Ar, e.Estatus })
                    .HasName("missing_index_3628_3627");

                entity.HasIndex(e => new { e.IdCarga, e.Ar, e.Concepto, e.DescCorta, e.Bitacora, e.Afiliacion, e.Cp, e.Producto, e.Estatus, e.IdProceso })
                    .HasName("missing_index_3663_3662");

                entity.HasIndex(e => new { e.IdCarga, e.Ar, e.Concepto, e.DescCorta, e.Bitacora, e.Afiliacion, e.Cp, e.Producto, e.Estatus, e.Mensaje, e.IdProceso })
                    .HasName("missing_index_4082_4081");

                entity.HasIndex(e => new { e.IdCarga, e.FileName, e.Ruta, e.Ar, e.Concepto, e.Caja, e.Correo, e.Contacto1, e.AfiliacionAmex, e.FolioTelecargaAmex, e.Producto, e.Sucursal, e.Estatus, e.Mensaje, e.Rfc, e.IdEquipo, e.DescEquipo, e.Contacto2, e.TAfiliacion, e.Ejecutivo, e.Direccion, e.Colonia, e.Poblacion, e.Idproyecto, e.EmailChgb, e.Rollos, e.DescCorta, e.Sintoma, e.Bitacora, e.IdSegmento, e.FechaInicio, e.Vip, e.Afiliacion, e.Telefono, e.Negocio, e.Estado, e.Cp, e.NotasRemedy, e.IdProceso })
                    .HasName("missing_index_3658_3657");

                entity.HasIndex(e => new { e.IdCarga, e.IdProceso, e.FileName, e.Ruta, e.Ar, e.Ejecutivo, e.Sucursal, e.Mensaje, e.IdUsuario, e.Rollos, e.Correo, e.Extra, e.Contacto1, e.Contacto2, e.Vip, e.TAfiliacion, e.FolioTelecargaAmex, e.Producto, e.Idproyecto, e.EmailChgb, e.NotasRemedy, e.Caja, e.IdEquipo, e.DescEquipo, e.IdSegmento, e.FechaInicio, e.Negocio, e.AfiliacionAmex, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.Concepto, e.Rfc, e.DescCorta, e.Sintoma, e.Bitacora, e.Afiliacion, e.Telefono, e.Direccion, e.Estatus })
                    .HasName("missing_index_3632_3631");

                entity.HasIndex(e => new { e.IdCarga, e.IdProceso, e.FileName, e.Ruta, e.Ar, e.Sucursal, e.Estatus, e.Mensaje, e.IdUsuario, e.Caja, e.Extra, e.Contacto1, e.Contacto2, e.TAfiliacion, e.AfiliacionAmex, e.Ejecutivo, e.Producto, e.Idproyecto, e.EmailChgb, e.Rollos, e.NotasRemedy, e.Correo, e.IdEquipo, e.DescEquipo, e.FechaInicio, e.Vip, e.Negocio, e.FolioTelecargaAmex, e.Colonia, e.Poblacion, e.Estado, e.Cp, e.Concepto, e.Rfc, e.DescCorta, e.Sintoma, e.Bitacora, e.Afiliacion, e.Telefono, e.Direccion, e.IdSegmento })
                    .HasName("missing_index_3899_3898");

                entity.HasIndex(e => new { e.IdCarga, e.IdProceso, e.FileName, e.Ruta, e.Ar, e.Sucursal, e.Estatus, e.Mensaje, e.IdUsuario, e.Caja, e.Extra, e.Contacto1, e.Contacto2, e.TAfiliacion, e.AfiliacionAmex, e.Ejecutivo, e.Producto, e.Idproyecto, e.EmailChgb, e.Rollos, e.Rfc, e.Correo, e.DescEquipo, e.IdSegmento, e.FechaInicio, e.Vip, e.Direccion, e.FolioTelecargaAmex, e.Poblacion, e.Estado, e.Cp, e.NotasRemedy, e.Concepto, e.IdEquipo, e.Sintoma, e.Bitacora, e.Afiliacion, e.Telefono, e.Negocio, e.Colonia, e.DescCorta })
                    .HasName("missing_index_3829_3828");

                entity.HasIndex(e => new { e.IdCarga, e.IdProceso, e.FileName, e.Ruta, e.Ar, e.Sucursal, e.Estatus, e.Mensaje, e.IdUsuario, e.Caja, e.Extra, e.Contacto1, e.Contacto2, e.TAfiliacion, e.AfiliacionAmex, e.Ejecutivo, e.Producto, e.Idproyecto, e.EmailChgb, e.Rollos, e.Rfc, e.Correo, e.DescEquipo, e.IdSegmento, e.FechaInicio, e.Vip, e.Direccion, e.FolioTelecargaAmex, e.Poblacion, e.Estado, e.Cp, e.NotasRemedy, e.DescCorta, e.IdEquipo, e.Sintoma, e.Bitacora, e.Afiliacion, e.Telefono, e.Negocio, e.Colonia, e.Concepto })
                    .HasName("missing_index_3831_3830");
            });

            modelBuilder.Entity<BdChangeMassiveStatus>(entity =>
            {
                entity.HasKey(e => e.IdChangeMassiveStatus)
                    .HasName("PK__BD_CHANG__46371A5FC374BDB2");

                entity.HasIndex(e => new { e.IdCarga, e.NoSerie })
                    .HasName("missing_index_2242516_2242515");

                entity.Property(e => e.Errores).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);
            });

            modelBuilder.Entity<BdChangeStatusArPaso>(entity =>
            {
                entity.HasKey(e => e.IdChangeStatusAr)
                    .HasName("PK__BD_CHANG__08C1AF99A16E8898");

                entity.Property(e => e.Error).IsUnicode(false);
            });

            modelBuilder.Entity<BdClaveEstado>(entity =>
            {
                entity.HasKey(e => e.IdClaveEstado)
                    .HasName("PK_BD_ESTADO_CLAVE");

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.BdClaveEstado)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_BD_CLAVE_ESTADO_SEPOMEX_ESTADOS");
            });

            modelBuilder.Entity<BdClienteProductoStatusAr>(entity =>
            {
                entity.HasOne(d => d.IdProductoStatusArNavigation)
                    .WithMany(p => p.BdClienteProductoStatusAr)
                    .HasForeignKey(d => d.IdProductoStatusAr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_CLIENTE_PRODUCTO_STATUS_AR_BD_PRODUCTO_STATUS_AR");
            });

            modelBuilder.Entity<BdComentarioAr>(entity =>
            {
                entity.HasIndex(e => e.IdAr);

                entity.Property(e => e.DescComentarioAr).IsUnicode(false);
            });

            modelBuilder.Entity<BdComprobacionSolicitudesViaticos>(entity =>
            {
                entity.HasIndex(e => new { e.IdUsuarioSolicitado, e.Status, e.FecCorteSolicitudesViaticos })
                    .HasName("IX_MI_BD_COMPROBACION_SOLICITUDES_VIATICOS_1826_1825");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdComprobacionViaticos>(entity =>
            {
                entity.HasIndex(e => new { e.IdComprobacionViaticos, e.ArchivoPdf, e.Estatus, e.IdRazon, e.IdSolicitudViaticos, e.Status })
                    .HasName("IX_BD_COMPROBACION_VIATICOS");

                entity.Property(e => e.ArchivoPdf).IsUnicode(false);

                entity.Property(e => e.ArchivoXml).IsUnicode(false);
            });

            modelBuilder.Entity<BdComprobacionViaticos2>(entity =>
            {
                entity.Property(e => e.ArchivoPdf).IsUnicode(false);

                entity.Property(e => e.ArchivoXml).IsUnicode(false);

                entity.Property(e => e.Estatus).IsUnicode(false);
            });

            modelBuilder.Entity<BdCompromisoBlog>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);
            });

            modelBuilder.Entity<BdCompromisos>(entity =>
            {
                entity.Property(e => e.CodigoControl).IsUnicode(false);

                entity.Property(e => e.DescCompromiso).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.StatusCompromiso).IsUnicode(false);
            });

            modelBuilder.Entity<BdCompromisosAcciones>(entity =>
            {
                entity.Property(e => e.DescAccion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCompromisosCompromiso>(entity =>
            {
                entity.Property(e => e.Compromiso).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdConfiguracionMensajeria>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracion)
                    .HasName("PK__BD_CONFI__093CFA5F7A96450F");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdConfirmaciones>(entity =>
            {
                entity.HasIndex(e => new { e.IdCargaConfirmaciones, e.Status })
                    .HasName("IX_BD_CONFIRMACIONES_ID_CARGA_CONFIRMACIONES, STATUS");

                entity.Property(e => e.NumConfirmacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdCargaConfirmacionesNavigation)
                    .WithMany(p => p.BdConfirmaciones)
                    .HasForeignKey(d => d.IdCargaConfirmaciones)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_BD_CARGAS_CONFIRMACIONES");

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdConfirmaciones)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdConfirmacionesIntermedia>(entity =>
            {
                entity.HasIndex(e => e.IdCargaConfirmaciones);

                entity.Property(e => e.NumConfirmacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdCargaConfirmacionesNavigation)
                    .WithMany(p => p.BdConfirmacionesIntermedia)
                    .HasForeignKey(d => d.IdCargaConfirmaciones)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_INTERMEDIA_BD_CARGAS_CONFIRMACIONES");

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdConfirmacionesIntermedia)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .HasConstraintName("FK_BD_CONFIRMACIONES_INTERMEDIA_BD_SOLICITUDES_VIATICOS");
            });

            modelBuilder.Entity<BdConjuntoModeloConectividad>(entity =>
            {
                entity.HasKey(e => e.IdConjunto)
                    .HasName("PK__BD_CONJU__AFAEAB5FC394C4FA");
            });

            modelBuilder.Entity<BdConsumiblesUnidad>(entity =>
            {
                entity.HasIndex(e => new { e.IdUnidad, e.Autorizado })
                    .HasName("IX_BD_CONSUMIBLES_UNIDAD_ID_UNIDAD, AUTORIZADO");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdControlAlertasAr>(entity =>
            {
                entity.HasKey(e => e.IdControlAr)
                    .HasName("PK__BD_CONTR__AC29B6595032ECA8");

                entity.Property(e => e.NoAr).IsUnicode(false);
            });

            modelBuilder.Entity<BdControlInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBdControlInsumos)
                    .HasName("PK__BD_CONTR__A1BE29351BE96354");

                entity.Property(e => e.NoTarima).IsUnicode(false);

                entity.Property(e => e.PosicionInventario).IsUnicode(false);

                entity.Property(e => e.Total).HasComputedColumnSql("([ENTRADA]-[SALIDA])");
            });

            modelBuilder.Entity<BdControlInsumosDetalle>(entity =>
            {
                entity.HasOne(d => d.IdTipoReponsableNavigation)
                    .WithMany(p => p.BdControlInsumosDetalle)
                    .HasForeignKey(d => d.IdTipoReponsable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_CONTROL_INSUMOS_DETALLE_C_TIPO_RESPONSABLE");
            });

            modelBuilder.Entity<BdControlInsumosEnvios>(entity =>
            {
                entity.HasKey(e => e.IdControlInsumoEnvio)
                    .HasName("PK__BD_CONTR__85880945AA658A7F");
            });

            modelBuilder.Entity<BdControlKitTecnico>(entity =>
            {
                entity.HasKey(e => e.IdKitTecnico)
                    .HasName("PK__BD_CONTR__2C41134BD9207889");
            });

            modelBuilder.Entity<BdControlMasivoDevoluciones>(entity =>
            {
                entity.HasKey(e => e.IdControlMasivoDevolucion)
                    .HasName("PK__BD_CONTR__B4CFAE3C725FCD24");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCpAsignacionAutomatica>(entity =>
            {
                entity.HasKey(e => e.IdCpAsignacionAutomatica)
                    .HasName("PK__BD_CP_AS__0E6D66520FB31B61");

                entity.Property(e => e.Cp).IsUnicode(false);
            });

            modelBuilder.Entity<BdCuentasBancarias>(entity =>
            {
                entity.Property(e => e.NombreBanco).IsUnicode(false);

                entity.Property(e => e.NumeroCuenta).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCursos>(entity =>
            {
                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdCursosAsignados>(entity =>
            {
                entity.Property(e => e.Calificacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdDatosCierresAplicacion>(entity =>
            {
                entity.HasKey(e => e.IdDatoCierreAplicacion)
                    .HasName("PK__BD_DATOS__2E0887BFD68A2F6A");

                entity.Property(e => e.Datos).IsUnicode(false);

                entity.Property(e => e.TipoCierre).IsUnicode(false);
            });

            modelBuilder.Entity<BdDbBackup>(entity =>
            {
                entity.Property(e => e.FecAlta).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdDevoluciones>(entity =>
            {
                entity.Property(e => e.DescEncargadoRecepcion).IsUnicode(false);

                entity.Property(e => e.DescLugarRecepcion).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdDevoluciones)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_BD_DEVOLUCIONES_C_CLIENTES");

                entity.HasOne(d => d.IdRazonDevolucionNavigation)
                    .WithMany(p => p.BdDevoluciones)
                    .HasForeignKey(d => d.IdRazonDevolucion)
                    .HasConstraintName("FK_BD_DEVOLUCIONES_C_RAZON_DEVOLUCION");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdDevoluciones)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_DEVOLUCIONES_BD_UNIDADES");
            });

            modelBuilder.Entity<BdDirecciones>(entity =>
            {
                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.DireccionAbreviada).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Latitud).IsUnicode(false);

                entity.Property(e => e.Longitud).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<BdDirectorioTelefonicoAr>(entity =>
            {
                entity.HasKey(e => e.IdDirectorioTelefonicoAr)
                    .HasName("PK__BD_DIREC__44453E8A203664EC");

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<BdElavonDispatches>(entity =>
            {
                entity.Property(e => e.AccessoryAmt).IsUnicode(false);

                entity.Property(e => e.AccessoryType).IsUnicode(false);

                entity.Property(e => e.ConsumableAmt).IsUnicode(false);

                entity.Property(e => e.ConsumableType).IsUnicode(false);

                entity.Property(e => e.DeviceType).IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory).IsUnicode(false);

                entity.Property(e => e.RequestId).IsUnicode(false);

                entity.Property(e => e.SoftwareName).IsUnicode(false);

                entity.Property(e => e.SoftwareVendor).IsUnicode(false);

                entity.Property(e => e.SoftwareVersion).IsUnicode(false);
            });

            modelBuilder.Entity<BdElavonRecoveries>(entity =>
            {
                entity.Property(e => e.AccessoryType).IsUnicode(false);

                entity.Property(e => e.DeviceType).IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.RequestId).IsUnicode(false);

                entity.Property(e => e.Serial).IsUnicode(false);
            });

            modelBuilder.Entity<BdEmails>(entity =>
            {
                entity.HasIndex(e => new { e.IdEmail, e.Status })
                    .HasName("IX_BD_EMAILS_STATUS");

                entity.Property(e => e.Attachment).IsUnicode(false);

                entity.Property(e => e.DescEmail).IsUnicode(false);

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.EmailBody).IsUnicode(false);

                entity.Property(e => e.EmailBodytype).IsUnicode(false);

                entity.Property(e => e.EmailFrom).IsUnicode(false);

                entity.Property(e => e.EmailSubject).IsUnicode(false);

                entity.Property(e => e.EmailTo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdEmails2>(entity =>
            {
                entity.Property(e => e.Attachment).IsUnicode(false);

                entity.Property(e => e.DescEmail).IsUnicode(false);

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.EmailBody).IsUnicode(false);

                entity.Property(e => e.EmailBodytype).IsUnicode(false);

                entity.Property(e => e.EmailFrom).IsUnicode(false);

                entity.Property(e => e.EmailSubject).IsUnicode(false);

                entity.Property(e => e.EmailTo).IsUnicode(false);

                entity.Property(e => e.NoAr).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdEnvioDoctosDocto>(entity =>
            {
                entity.HasIndex(e => e.IdArPrefacturacion);

                entity.HasIndex(e => e.IdEnvioDoctos);

                entity.HasIndex(e => e.IsRecibido);
            });

            modelBuilder.Entity<BdEnvioElavon>(entity =>
            {
                entity.Property(e => e.NombreArchivo).IsUnicode(false);
            });

            modelBuilder.Entity<BdEnvioInsumos>(entity =>
            {
                entity.HasIndex(e => e.IdEnvio)
                    .HasName("IDX1");

                entity.HasOne(d => d.IdEnvioNavigation)
                    .WithMany(p => p.BdEnvioInsumos)
                    .HasForeignKey(d => d.IdEnvio)
                    .HasConstraintName("FK_BD_ENVIO_INSUMOS_BD_ENVIOS");
            });

            modelBuilder.Entity<BdEnvioSims>(entity =>
            {
                entity.HasOne(d => d.IdSimNavigation)
                    .WithMany(p => p.BdEnvioSims)
                    .HasForeignKey(d => d.IdSim)
                    .HasConstraintName("FK_BD_ENVIO_SIMS_BD_MC_SIMS");

                entity.HasOne(d => d.IdUsuarioRecepcionNavigation)
                    .WithMany(p => p.BdEnvioSims)
                    .HasForeignKey(d => d.IdUsuarioRecepcion)
                    .HasConstraintName("FK_BD_ENVIO_SIMS_C_USUARIOS");
            });

            modelBuilder.Entity<BdEnvioUnidad>(entity =>
            {
                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdUnidad, e.IdEnvio })
                    .HasName("IX_BD_ENVIO_UNIDAD_ID_ENVIO");

                entity.HasIndex(e => new { e.IdUnidad, e.IdEnvio, e.IsRecibida })
                    .HasName("IX_BD_ENVIO_UNIDAD_IS_RECIBIDA");

                entity.Property(e => e.IsRecibida).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdEnvioNavigation)
                    .WithMany(p => p.BdEnvioUnidad)
                    .HasForeignKey(d => d.IdEnvio)
                    .HasConstraintName("FK_BD_ENVIO_UNIDAD_BD_ENVIOS");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdEnvioUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_ENVIO_UNIDAD_BD_UNIDADES");

                entity.HasOne(d => d.IdUsuarioRecepcionNavigation)
                    .WithMany(p => p.BdEnvioUnidad)
                    .HasForeignKey(d => d.IdUsuarioRecepcion)
                    .HasConstraintName("FK_BD_ENVIO_UNIDAD_C_USUARIOS");
            });

            modelBuilder.Entity<BdEnvios>(entity =>
            {
                entity.HasIndex(e => e.NoGuia)
                    .HasName("NO_GUIA");

                entity.HasIndex(e => new { e.IdEnvio, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_1947_1946");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableDestino, e.IdResponsableDestino, e.IdStatusEnvio })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_DESTINO, ID_RESPONSABLE_DESTINO, ID_STATUS_ENVIO");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_ORIGEN, ID_RESPONSABLE_ORIGEN, ID_STATUS_ENVIO");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio, e.Status })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_ORIGEN, ID_RESPONSABLE_ORIGEN, ID_STATUS_ENVIO, STATUS");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdUrgenciaEnvio, e.FecEnvio, e.IdTipoResponsableDestino, e.IdStatusEnvio })
                    .HasName("IX_BD_ENVIOS_ID_TIPO_RESPONSABLE_DESTINO, ID_STATUS_ENVIO");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableOrigen, e.IdTipoResponsableOrigen, e.IdStatusEnvio, e.Status, e.FecEnvio })
                    .HasName("IX_MI_BD_ENVIOS_30334_30333");

                entity.HasIndex(e => new { e.IdEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio, e.Status, e.FecEnvio })
                    .HasName("IX_MI_BD_ENVIOS_30381_30380");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdUrgenciaEnvio, e.FecEnvio, e.IdTipoResponsableDestino, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_5596_5595");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdServicioMensajeriasPrecio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdTipoResponsableDestino, e.FecEnvio, e.IdStatusEnvio })
                    .HasName("INDX1");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdServicioMensajeria, e.NoGuia, e.IdUrgenciaEnvio, e.FecEnvio, e.FecRecepcion, e.IdTipoResponsableDestino, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_6182_6181");

                entity.HasIndex(e => new { e.IdEnvio, e.IdResponsableDestino, e.IdServicioMensajeria, e.NoGuia, e.Costo, e.IdUrgenciaEnvio, e.FecEnvio, e.FecRecepcion, e.IdTipoResponsableDestino, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_13806_13805");

                entity.Property(e => e.NoGuia).IsUnicode(false);

                entity.Property(e => e.OtraDireccionDestino).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdChoferNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdChofer)
                    .HasConstraintName("FK_BD_ENVIOS_C_USUARIOS");

                entity.HasOne(d => d.IdDireccionDestinoNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdDireccionDestino)
                    .HasConstraintName("FK_BD_ENVIOS_BD_DIRECCIONES");

                entity.HasOne(d => d.IdServicioMensajeriaNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdServicioMensajeria)
                    .HasConstraintName("FK_BD_ENVIOS_C_SERVICIO_MENSAJERIA");

                entity.HasOne(d => d.IdStatusEnvioNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdStatusEnvio)
                    .HasConstraintName("FK_BD_ENVIOS_C_STATUS_ENVIO");

                entity.HasOne(d => d.IdTipoResponsableDestinoNavigation)
                    .WithMany(p => p.BdEnviosIdTipoResponsableDestinoNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableDestino)
                    .HasConstraintName("FK_BD_ENVIOS_C_TIPO_RESPONSABLE1");

                entity.HasOne(d => d.IdTipoResponsableOrigenNavigation)
                    .WithMany(p => p.BdEnviosIdTipoResponsableOrigenNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableOrigen)
                    .HasConstraintName("FK_BD_ENVIOS_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdUrgenciaEnvioNavigation)
                    .WithMany(p => p.BdEnvios)
                    .HasForeignKey(d => d.IdUrgenciaEnvio)
                    .HasConstraintName("FK_BD_ENVIOS_C_URGENCIA_ENVIO");
            });

            modelBuilder.Entity<BdEnviosDoctos>(entity =>
            {
                entity.HasIndex(e => new { e.IdEnvioDoctos, e.IdUrgenciaEnvio, e.FecEnvio, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_DOCTOS_11883_11882");

                entity.HasIndex(e => new { e.IdEnvioDoctos, e.IdUrgenciaEnvio, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdStatusEnvio, e.Status })
                    .HasName("IX_MI_BD_ENVIOS_DOCTOS_5459_5458");

                entity.Property(e => e.NoGuia).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdEquivaleciasModelo>(entity =>
            {
                entity.HasKey(e => e.IdEquivaliencia)
                    .HasName("PK__BD_EQUIV__4C1C0899B71CD290");

                entity.Property(e => e.DescNuevoModelo).IsUnicode(false);
            });

            modelBuilder.Entity<BdEquivalenciaEstado>(entity =>
            {
                entity.HasKey(e => e.IdEquivalenciaEstado)
                    .HasName("PK__BD_EQUIV__F01D840CE759F49E");

                entity.Property(e => e.DescEstado).IsUnicode(false);

                entity.Property(e => e.DescEstadoEquivalencia).IsUnicode(false);
            });

            modelBuilder.Entity<BdEspecificacionCausaRechazo>(entity =>
            {
                entity.Property(e => e.DescEspecificacionCausaRechazo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdEspecificacionTipoFalla>(entity =>
            {
                entity.Property(e => e.DescEspecificacionFalla).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdEtiquetaInformacionUnidadCliente>(entity =>
            {
                entity.Property(e => e.DescEtiquetaInformacionUnidadCliente).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdExitoLayoutLog>(entity =>
            {
                entity.HasKey(e => e.IdExitoLayoutLog)
                    .HasName("PK__BD_EXITO__BA06730E8AA88E5C");

                entity.HasIndex(e => e.IdArchivoMasivo)
                    .HasName("missing_index_3810_3809");

                entity.HasIndex(e => new { e.IdExitoLayoutLog, e.IdArchivo })
                    .HasName("missing_index_4902_4901");

                entity.HasIndex(e => new { e.Odtexterna, e.IdCausaCancelacion, e.IdArchivo })
                    .HasName("missing_index_62986_62985");

                entity.HasIndex(e => new { e.Odtexterna, e.Subrechazo, e.Idrechazo, e.IdArchivo })
                    .HasName("missing_index_62988_62987");

                entity.HasIndex(e => new { e.Odtexterna, e.Subrechazo, e.IdCausaCancelacion, e.Idrechazo, e.IdArchivo })
                    .HasName("missing_index_62830_62829");

                entity.HasIndex(e => new { e.IdArchivoMasivo, e.Odtexterna, e.CierreServicio, e.Atiende, e.FechaCierre, e.HorasCierre, e.MinutoCierre, e.OtorganteVobo, e.OtorganteVoboRechazo, e.Subrechazo, e.IdCausaCancelacion, e.Estatus, e.Correo, e.TipoAtencion, e.Idrechazo, e.TelefonoCampo, e.Idcriteriocambio, e.Discover, e.IdAr, e.IdArchivo })
                    .HasName("missing_index_62319_62318");

                entity.Property(e => e.ActReferencias).IsUnicode(false);

                entity.Property(e => e.Afilamx).IsUnicode(false);

                entity.Property(e => e.AmexSiNo).IsUnicode(false);

                entity.Property(e => e.Aplicacion).IsUnicode(false);

                entity.Property(e => e.Base).IsUnicode(false);

                entity.Property(e => e.Bateria).IsUnicode(false);

                entity.Property(e => e.CableAc).IsUnicode(false);

                entity.Property(e => e.Caja).IsUnicode(false);

                entity.Property(e => e.ConclusionesAmex).IsUnicode(false);

                entity.Property(e => e.CorreoEnviado).IsUnicode(false);

                entity.Property(e => e.Eliminador).IsUnicode(false);

                entity.Property(e => e.Idamx).IsUnicode(false);

                entity.Property(e => e.InstalacionesElavonDescMarca).IsUnicode(false);

                entity.Property(e => e.InstalacionesElavonDescModelo).IsUnicode(false);

                entity.Property(e => e.InstalacionesElavonNoSerie).IsUnicode(false);

                entity.Property(e => e.IsApp).IsUnicode(false);

                entity.Property(e => e.IsComercioNotifado).IsUnicode(false);

                entity.Property(e => e.IsPromociones).IsUnicode(false);

                entity.Property(e => e.MarcaMantto).IsUnicode(false);

                entity.Property(e => e.Marcasime).IsUnicode(false);

                entity.Property(e => e.Marcasims).IsUnicode(false);

                entity.Property(e => e.ModeloMantto).IsUnicode(false);

                entity.Property(e => e.NoSerieMantto).IsUnicode(false);

                entity.Property(e => e.RetirosElavonDescMarca).IsUnicode(false);

                entity.Property(e => e.RetirosElavonDescModelo).IsUnicode(false);

                entity.Property(e => e.RetirosElavonNoSerie).IsUnicode(false);

                entity.Property(e => e.Rollosinst).IsUnicode(false);

                entity.Property(e => e.Simentra).IsUnicode(false);

                entity.Property(e => e.Simsale).IsUnicode(false);

                entity.Property(e => e.Tapa).IsUnicode(false);

                entity.Property(e => e.TecnologiaEntrada).IsUnicode(false);

                entity.Property(e => e.TecnologiaMantto).IsUnicode(false);

                entity.Property(e => e.TecnologiaSalida).IsUnicode(false);

                entity.Property(e => e.TelefonoComercio1).IsUnicode(false);

                entity.Property(e => e.TelefonoComercio2).IsUnicode(false);

                entity.Property(e => e.Ticket).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);

                entity.Property(e => e.Version2).IsUnicode(false);
            });

            modelBuilder.Entity<BdExtravioPorMensajeriaCargaPdf>(entity =>
            {
                entity.HasKey(e => e.IdReparacionCargaPdf)
                    .HasName("PK__BD_EXTRA__CEE12DE554AC5FAC");

                entity.Property(e => e.ArchivoSistema).IsUnicode(false);

                entity.Property(e => e.ArchivoUsuario).IsUnicode(false);
            });

            modelBuilder.Entity<BdFallaConFallaEncontrada>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdFallaEspecificaTipoFalla>(entity =>
            {
                entity.HasIndex(e => e.IdFalla)
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_4679_4678");

                entity.HasIndex(e => new { e.IdFalla, e.IdCliente })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_11848_11847");

                entity.HasIndex(e => new { e.IdFalla, e.IdEspecifTipoFalla })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_6167_6166");

                entity.HasIndex(e => new { e.IdEspecifTipoFalla, e.IdFalla, e.IdCliente })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_11852_11851");

                entity.HasIndex(e => new { e.IdFalla, e.IdCliente, e.IdTipoFalla })
                    .HasName("IX_MI_BD_FALLA_ESPECIFICA_TIPO_FALLA_11850_11849");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdFestivos>(entity =>
            {
                entity.HasIndex(e => e.IdFestivos)
                    .HasName("IX_BD_FESTIVOS")
                    .IsUnique();
            });

            modelBuilder.Entity<BdFotoAr>(entity =>
            {
                entity.HasOne(d => d.IdAttachNavigation)
                    .WithMany(p => p.BdFotoAr)
                    .HasForeignKey(d => d.IdAttach)
                    .HasConstraintName("FK_BD_FOTO_AR_BD_ATTACH");
            });

            modelBuilder.Entity<BdGarantiaAlmacen>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdGruposClientes>(entity =>
            {
                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdGruposClientes)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_BD_GRUPOS_CLIENTES_C_CLIENTES");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.BdGruposClientes)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK_BD_GRUPOS_CLIENTES_C_GRUPOS");
            });

            modelBuilder.Entity<BdHistoricoPassword>(entity =>
            {
                entity.Property(e => e.Password).IsUnicode(false);
            });

            modelBuilder.Entity<BdHorarioHorasMes>(entity =>
            {
                entity.HasIndex(e => new { e.HorasMes, e.IdHorario, e.Mes, e.Anio })
                    .HasName("IX_MI_BD_HORARIO_HORAS_MES_6690_6689");

                entity.HasIndex(e => new { e.IdHorario, e.HorasMes, e.Mes, e.Anio })
                    .HasName("IX_MI_BD_HORARIO_HORAS_MES_6692_6691");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.BdHorarioHorasMes)
                    .HasForeignKey(d => d.IdHorario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_HORARIO_HORAS_MES_C_HORARIOS");
            });

            modelBuilder.Entity<BdHorarioWeekhour>(entity =>
            {
                entity.HasKey(e => e.IdHorarioWeekhour)
                    .HasName("PK_BD_UPTIME_WEEKHOUR");

                entity.HasIndex(e => new { e.IdWeekhour, e.IdHorario })
                    .HasName("IX_BD_HORARIO_WEEKHOUR_ID_HORARIO");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.BdHorarioWeekhour)
                    .HasForeignKey(d => d.IdHorario)
                    .HasConstraintName("FK_BD_HORARIO_WEEKHOUR_C_HORARIOS");

                entity.HasOne(d => d.IdWeekhourNavigation)
                    .WithMany(p => p.BdHorarioWeekhour)
                    .HasForeignKey(d => d.IdWeekhour)
                    .HasConstraintName("FK_BD_UPTIME_WEEKHOUR_C_WEEKHOURS");
            });

            modelBuilder.Entity<BdIgualas>(entity =>
            {
                entity.HasIndex(e => new { e.Year, e.Month, e.NoAfiliacion })
                    .HasName("IX_BD_IGUALAS");

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdIgualasAlta>(entity =>
            {
                entity.Property(e => e.NoAfiliacion).IsUnicode(false);
            });

            modelBuilder.Entity<BdInformacionUnidadAr>(entity =>
            {
                entity.HasIndex(e => e.IdAr);

                entity.Property(e => e.Aplicacion).IsUnicode(false);

                entity.Property(e => e.CapacidadDiscoDuro).IsUnicode(false);

                entity.Property(e => e.InstalacionLlaves).IsUnicode(false);

                entity.Property(e => e.LectorTarjeta).IsUnicode(false);

                entity.Property(e => e.Memoria).IsUnicode(false);

                entity.Property(e => e.Monitor).IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesA).IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesB).IsUnicode(false);

                entity.Property(e => e.Procesador).IsUnicode(false);

                entity.Property(e => e.StatusInstalacionLlaves).IsUnicode(false);

                entity.Property(e => e.TipoLlave).IsUnicode(false);

                entity.Property(e => e.TipoPw).IsUnicode(false);

                entity.Property(e => e.TipoTeclado).IsUnicode(false);

                entity.Property(e => e.VelocidadProcesador).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);

                entity.Property(e => e.VersionTecladoEpp).IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivoInsumos>(entity =>
            {
                entity.HasKey(e => e.IdIngresoArchivoInsumo)
                    .HasName("PK__BD_INGRE__A2E7631D1449BC23");

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusArchivo).IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosAlmacen>(entity =>
            {
                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.NoImei).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.Serie).IsUnicode(false);

                entity.Property(e => e.StatusArchivo).IsUnicode(false);

                entity.Property(e => e.VersionAplicativo).IsUnicode(false);

                entity.Property(e => e.VersionKernel).IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosAsignacion>(entity =>
            {
                entity.HasIndex(e => new { e.IdArchivoMasivo, e.IdAr, e.IdArchivo, e.StatusArchivo })
                    .HasName("IX_MI_BD_INGRESO_ARCHIVOS_ASIGNACION_8589_8588");

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.HoraAtencion).IsUnicode(false);

                entity.Property(e => e.StatusArchivo).IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosExito>(entity =>
            {
                entity.HasKey(e => e.IdArchivoMasivo)
                    .HasName("PK_BD_INGRESO_ARCHIVOS");

                entity.HasIndex(e => e.IdArchivo);

                entity.Property(e => e.Aplicacion).IsUnicode(false);

                entity.Property(e => e.Atiende).IsUnicode(false);

                entity.Property(e => e.CadenaCierreEscrita).IsUnicode(false);

                entity.Property(e => e.Caja).IsUnicode(false);

                entity.Property(e => e.CapacidadDiscoDuro).IsUnicode(false);

                entity.Property(e => e.CodigoIntervencion).IsUnicode(false);

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.DescErrorMov).IsUnicode(false);

                entity.Property(e => e.DescripcionTrabajo).IsUnicode(false);

                entity.Property(e => e.DigitoVerificador).IsUnicode(false);

                entity.Property(e => e.FallaEncontrada).IsUnicode(false);

                entity.Property(e => e.FolioServicio).IsUnicode(false);

                entity.Property(e => e.FolioTas).IsUnicode(false);

                entity.Property(e => e.FolioTir).IsUnicode(false);

                entity.Property(e => e.FolioValidacion).IsUnicode(false);

                entity.Property(e => e.HoraCierre).IsUnicode(false);

                entity.Property(e => e.HoraFinIngeniero).IsUnicode(false);

                entity.Property(e => e.HoraIniIngeniero).IsUnicode(false);

                entity.Property(e => e.HoraLlegada).IsUnicode(false);

                entity.Property(e => e.HoraLlegadaTerceros).IsUnicode(false);

                entity.Property(e => e.InstalacionLlaves).IsUnicode(false);

                entity.Property(e => e.IntensidadSenial).IsUnicode(false);

                entity.Property(e => e.LectorTarjeta).IsUnicode(false);

                entity.Property(e => e.Memoria).IsUnicode(false);

                entity.Property(e => e.MinutoCierre).IsUnicode(false);

                entity.Property(e => e.MinutoFinIngeniero).IsUnicode(false);

                entity.Property(e => e.MinutoIniIngeniero).IsUnicode(false);

                entity.Property(e => e.MinutoLlegada).IsUnicode(false);

                entity.Property(e => e.MinutoLlegadaTercero).IsUnicode(false);

                entity.Property(e => e.Monitor).IsUnicode(false);

                entity.Property(e => e.MotivoCobro).IsUnicode(false);

                entity.Property(e => e.NoEquipo).IsUnicode(false);

                entity.Property(e => e.NoEquipoMov).IsUnicode(false);

                entity.Property(e => e.NoInventarioFalla).IsUnicode(false);

                entity.Property(e => e.NoSerieEntrada).IsUnicode(false);

                entity.Property(e => e.NoSerieFalla).IsUnicode(false);

                entity.Property(e => e.NoSerieSalida).IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesA).IsUnicode(false);

                entity.Property(e => e.NombrePersonaLlavesB).IsUnicode(false);

                entity.Property(e => e.OtorganteSoporteCliente).IsUnicode(false);

                entity.Property(e => e.OtorganteTas).IsUnicode(false);

                entity.Property(e => e.OtorganteVobo).IsUnicode(false);

                entity.Property(e => e.OtorganteVoboCliente).IsUnicode(false);

                entity.Property(e => e.OtorganteVoboTerceros).IsUnicode(false);

                entity.Property(e => e.Procesador).IsUnicode(false);

                entity.Property(e => e.StatusArchivo).IsUnicode(false);

                entity.Property(e => e.StatusInstalacionLlaves).IsUnicode(false);

                entity.Property(e => e.StatusMov).IsUnicode(false);

                entity.Property(e => e.TipoLlave).IsUnicode(false);

                entity.Property(e => e.TipoPw).IsUnicode(false);

                entity.Property(e => e.TipoTeclado).IsUnicode(false);

                entity.Property(e => e.VelocidadProcesador).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);

                entity.Property(e => e.VersionTecladoEpp).IsUnicode(false);

                entity.Property(e => e.VoltajeNeutro).IsUnicode(false);

                entity.Property(e => e.VoltajeTierra).IsUnicode(false);

                entity.Property(e => e.VoltajeTierraNeutro).IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoArchivosRechazo>(entity =>
            {
                entity.Property(e => e.AutorizacionRechazo).IsUnicode(false);

                entity.Property(e => e.DescError).IsUnicode(false);

                entity.Property(e => e.DescErrorMov).IsUnicode(false);

                entity.Property(e => e.DescripcionTrabajo).IsUnicode(false);

                entity.Property(e => e.FolioServicio).IsUnicode(false);

                entity.Property(e => e.HoraCierre).IsUnicode(false);

                entity.Property(e => e.MinutoCierre).IsUnicode(false);

                entity.Property(e => e.NoEquipoMov).IsUnicode(false);

                entity.Property(e => e.NoSerieEntrada).IsUnicode(false);

                entity.Property(e => e.NoSerieSalida).IsUnicode(false);

                entity.Property(e => e.OtorganteVobo).IsUnicode(false);

                entity.Property(e => e.StatusArchivo).IsUnicode(false);

                entity.Property(e => e.StatusMov).IsUnicode(false);
            });

            modelBuilder.Entity<BdIngresoMovInventariosLog>(entity =>
            {
                entity.HasKey(e => e.IdIngresoMovInventariosLog)
                    .HasName("PK__BD_INGRE__4482CC37D468DA0E");

                entity.Property(e => e.AplicativoEntrada).IsUnicode(false);

                entity.Property(e => e.AplicativoSalida).IsUnicode(false);

                entity.Property(e => e.Base).IsUnicode(false);

                entity.Property(e => e.Bateria).IsUnicode(false);

                entity.Property(e => e.CableAc).IsUnicode(false);

                entity.Property(e => e.ConectividadEntrada).IsUnicode(false);

                entity.Property(e => e.ConectividadSalida).IsUnicode(false);

                entity.Property(e => e.Eliminador).IsUnicode(false);

                entity.Property(e => e.IdAplicativoEntrada).IsUnicode(false);

                entity.Property(e => e.IdAplicativoSalida).IsUnicode(false);

                entity.Property(e => e.IdAr).IsUnicode(false);

                entity.Property(e => e.IdConectividadEntrada).IsUnicode(false);

                entity.Property(e => e.IdConectividadSalida).IsUnicode(false);

                entity.Property(e => e.IdInstalacionModelo).IsUnicode(false);

                entity.Property(e => e.IdRetiroModelo).IsUnicode(false);

                entity.Property(e => e.InstalacionIdUnidad).IsUnicode(false);

                entity.Property(e => e.InstalacionModelo).IsUnicode(false);

                entity.Property(e => e.InstalacionNoSerie).IsUnicode(false);

                entity.Property(e => e.MarcaMantto).IsUnicode(false);

                entity.Property(e => e.ModeloMantto).IsUnicode(false);

                entity.Property(e => e.NoSerieMantto).IsUnicode(false);

                entity.Property(e => e.Odt).IsUnicode(false);

                entity.Property(e => e.RetiroIdUnidad).IsUnicode(false);

                entity.Property(e => e.RetiroModelo).IsUnicode(false);

                entity.Property(e => e.RetiroNoSerie).IsUnicode(false);

                entity.Property(e => e.Tapa).IsUnicode(false);

                entity.Property(e => e.TecnologiaMantto).IsUnicode(false);
            });

            modelBuilder.Entity<BdInstalaciones>(entity =>
            {
                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_BD_INSTALACIONES");

                entity.HasIndex(e => e.IdUnidad)
                    .HasName("IX_BD_INSTALACIONES_1");

                entity.Property(e => e.Tipo).IsUnicode(false);

                entity.HasOne(d => d.IdClienteIniNavigation)
                    .WithMany(p => p.BdInstalaciones)
                    .HasForeignKey(d => d.IdClienteIni)
                    .HasConstraintName("FK_BD_INSTALACIONES_C_CLIENTES");

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdInstalaciones)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_INSTALACIONES_BD_NEGOCIOS");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.BdInstalacionesIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK_BD_INSTALACIONES_BD_UNIDADES1");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.BdInstalaciones)
                    .HasForeignKey(d => d.IdTecnico)
                    .HasConstraintName("FK_BD_INSTALACIONES_C_USUARIOS");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdInstalacionesIdUnidadNavigation)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_INSTALACIONES_BD_UNIDADES");
            });

            modelBuilder.Entity<BdInsumos>(entity =>
            {
                entity.HasKey(e => e.IdBdInsumo)
                    .HasName("PK__BD_INSUM__F768FC8BF5E6F90A");

                entity.Property(e => e.NoTarima).IsUnicode(false);

                entity.Property(e => e.PosicionInventario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdInsumosAlta>(entity =>
            {
                entity.HasKey(e => e.IdInsumosAlta)
                    .HasName("PK__BD_INSUM__FF7E81862DE23FD8");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdItemsSolicitudAlmacen>(entity =>
            {
                entity.HasIndex(e => e.IdSolicitudAlmacen);

                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdCliente })
                    .HasName("IX_MI_BD_ITEMS_SOLICITUD_ALMACEN_254_253");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdStatusItemsSolicitudAlmacen })
                    .HasName("IX_BD_ITEMS_SOLICITUD_ALMACEN_ID_STATUS_ITEMS_SOLICITUD_ALMACEN");

                entity.Property(e => e.IsSurtido).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notas).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdKitInsumos>(entity =>
            {
                entity.HasKey(e => e.IdKitInsumo)
                    .HasName("PK__BD_KIT_I__E3DEE2B0FF55C6D9");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdLoadFilterDhl>(entity =>
            {
                entity.HasKey(e => e.IdLoadFilterDhl)
                    .HasName("PK__BD_LOAD___34823661904E8C4E");

                entity.Property(e => e.Cliente).IsUnicode(false);

                entity.Property(e => e.NoGuia).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);
            });

            modelBuilder.Entity<BdLoadFilterEstafeta>(entity =>
            {
                entity.HasKey(e => e.IdLoadFilterEstafeta)
                    .HasName("PK__BD_LOAD___BFBA0BB9A829BB6E");

                entity.Property(e => e.Cliente).IsUnicode(false);

                entity.Property(e => e.NoGuia).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);
            });

            modelBuilder.Entity<BdLogErroresEmailSolicitudes>(entity =>
            {
                entity.HasKey(e => e.IdLogErrorEmail)
                    .HasName("PK_BD_LOG_ERROR_EMAIL_SOLICITUDES");
            });

            modelBuilder.Entity<BdLoginUsers>(entity =>
            {
                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.IpMachine).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserAgent).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<BdLogroBlog>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);
            });

            modelBuilder.Entity<BdLogros>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Cuantificacion).IsUnicode(false);

                entity.Property(e => e.DescLogro).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdMcSims>(entity =>
            {
                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdMcSims)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_MC_SIMS_BD_UNIDADES");
            });

            modelBuilder.Entity<BdMcViaGeozonaCoordenadas>(entity =>
            {
                entity.Property(e => e.Latitud).IsUnicode(false);

                entity.Property(e => e.Longitud).IsUnicode(false);
            });

            modelBuilder.Entity<BdMcViaGeozonaCoordenadasZona>(entity =>
            {
                entity.HasKey(e => e.IdGeozonaCoordenadasPlaza)
                    .HasName("PK_BD_MC_VIA_GEOZONA_COORDENADAS_PLAZA");

                entity.Property(e => e.Latitud).IsUnicode(false);

                entity.Property(e => e.Longitud).IsUnicode(false);
            });

            modelBuilder.Entity<BdMenu>(entity =>
            {
                entity.HasIndex(e => e.IdUsuario)
                    .HasName("missing_index_4077_4076");

                entity.HasIndex(e => new { e.IdMenu0, e.IdUsuario })
                    .HasName("IX_BD_MENU_ID_MENU0, ID_USUARIO");

                entity.HasIndex(e => new { e.IdMenu1, e.IdUsuario })
                    .HasName("IX_BD_MENU_ID_MENU1, ID_USUARIO");
            });

            modelBuilder.Entity<BdModeloAccesorio>(entity =>
            {
                entity.HasOne(d => d.IdAccesorioNavigation)
                    .WithMany(p => p.BdModeloAccesorio)
                    .HasForeignKey(d => d.IdAccesorio)
                    .HasConstraintName("FK_BD_MODELO_ACCESORIO_C_ACCESORIOS");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloAccesorio)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_ACCESORIO_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloCategoria>(entity =>
            {
                entity.HasKey(e => e.IdModeloCategoria)
                    .HasName("PK__BD_MODEL__E265EAC3F621A77B");
            });

            modelBuilder.Entity<BdModeloCelular>(entity =>
            {
                entity.Property(e => e.DescModeloCelular).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdModeloConectividad>(entity =>
            {
                entity.HasKey(e => e.IdModeloConectividad)
                    .HasName("PK__BD_MODEL__5B7BD33529C43DAE");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdModeloInsumo>(entity =>
            {
                entity.HasOne(d => d.IdInsumoNavigation)
                    .WithMany(p => p.BdModeloInsumo)
                    .HasForeignKey(d => d.IdInsumo)
                    .HasConstraintName("FK_BD_MODELO_INSUMO_C_INSUMOS");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloInsumo)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_INSUMO_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloLlave>(entity =>
            {
                entity.HasOne(d => d.IdLlaveNavigation)
                    .WithMany(p => p.BdModeloLlave)
                    .HasForeignKey(d => d.IdLlave)
                    .HasConstraintName("FK_BD_MODELO_LLAVE_C_LLAVES");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloLlave)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_LLAVE_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloModulo>(entity =>
            {
                entity.HasIndex(e => e.IdModeloModulo)
                    .HasName("IX_MI_BD_MODELO_MODULO_353_352");

                entity.HasIndex(e => new { e.IdModeloModulo, e.IdModelo })
                    .HasName("IX_MI_BD_MODELO_MODULO_269_268");

                entity.HasIndex(e => new { e.IdProductoModulo, e.IdModelo })
                    .HasName("IX_MI_BD_MODELO_MODULO_273_272");

                entity.HasIndex(e => new { e.IdProductoModulo, e.IdMarcaModulo, e.IdModeloModulo, e.IdModelo })
                    .HasName("IX_MI_BD_MODELO_MODULO_169_168");

                entity.HasIndex(e => new { e.Id, e.IdMarcaModulo, e.IdModeloModulo, e.IdUsuarioAlta, e.IdModelo, e.IdProductoModulo })
                    .HasName("IX_MI_BD_MODELO_MODULO_275_274");

                entity.HasOne(d => d.IdMarcaModuloNavigation)
                    .WithMany(p => p.BdModeloModulo)
                    .HasForeignKey(d => d.IdMarcaModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_MARCAS");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloModuloIdModeloNavigation)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_MODELOS");

                entity.HasOne(d => d.IdModeloModuloNavigation)
                    .WithMany(p => p.BdModeloModuloIdModeloModuloNavigation)
                    .HasForeignKey(d => d.IdModeloModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_MODELOS1");

                entity.HasOne(d => d.IdProductoModuloNavigation)
                    .WithMany(p => p.BdModeloModulo)
                    .HasForeignKey(d => d.IdProductoModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_MODULO_C_PRODUCTOS");
            });

            modelBuilder.Entity<BdModeloPrecio>(entity =>
            {
                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdModeloPrecio)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_PRECIO_C_CLIENTES");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloPrecio)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_PRECIO_C_MODELOS");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.BdModeloPrecio)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK_BD_MODELO_PRECIO_C_MONEDAS");
            });

            modelBuilder.Entity<BdModeloServicio>(entity =>
            {
                entity.HasKey(e => e.IdModeloServicio)
                    .HasName("PK__BD_MODEL__AFB1861684E18BC2");

                entity.Property(e => e.IsChecked).IsUnicode(false);
            });

            modelBuilder.Entity<BdModeloSku>(entity =>
            {
                entity.Property(e => e.Sku).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdModeloSku)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_SKU_C_CLIENTES");

                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloSku)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_MODELO_SKU_C_MODELOS");
            });

            modelBuilder.Entity<BdModeloSustituto>(entity =>
            {
                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdModeloSustitutoIdModeloNavigation)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_MODELO_SUSTITUTO_C_MODELOS");

                entity.HasOne(d => d.IdModeloSustitutoNavigation)
                    .WithMany(p => p.BdModeloSustitutoIdModeloSustitutoNavigation)
                    .HasForeignKey(d => d.IdModeloSustituto)
                    .HasConstraintName("FK_BD_MODELO_SUSTITUTO_C_MODELOS1");

                entity.HasOne(d => d.IdSoftwareNavigation)
                    .WithMany(p => p.BdModeloSustituto)
                    .HasForeignKey(d => d.IdSoftware)
                    .HasConstraintName("FK_BD_MODELO_SUSTITUTO_C_SOFTWARE");
            });

            modelBuilder.Entity<BdNegocioHorasMes>(entity =>
            {
                entity.HasKey(e => e.IdNegocioHorasMes)
                    .HasName("PK_BD_UNIDAD_HORAS_MES");

                entity.HasIndex(e => new { e.IdNegocio, e.Mes, e.Anio })
                    .HasName("IX_BD_NEGOCIO_HORAS_MES_ID_NEGOCIO, MES, ANIO");

                entity.HasIndex(e => new { e.IdNegocioHorasMes, e.IdNegocio, e.Mes, e.Anio })
                    .HasName("IX_BD_NEGOCIO_HORAS_MES_MES, ANIO");

                entity.Property(e => e.IsContract).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdNegocioHorasMes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_HORAS_MES_C_CLIENTES1");

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdNegocioHorasMes)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_HORAS_MES_BD_NEGOCIOS");
            });

            modelBuilder.Entity<BdNegocios>(entity =>
            {
                entity.HasIndex(e => e.Cp)
                    .HasName("missing_index_3671_3670");

                entity.HasIndex(e => e.DescNegocio)
                    .HasName("missing_index_2853_2852");

                entity.HasIndex(e => e.IdCargaAlta);

                entity.HasIndex(e => e.IdEstado);

                entity.HasIndex(e => e.IdRegion);

                entity.HasIndex(e => e.IdSegmento);

                entity.HasIndex(e => e.IdZona);

                entity.HasIndex(e => e.NoAfiliacion)
                    .HasName("IX_BD_NEGOCIOS_1");

                entity.HasIndex(e => e.RazonSocial)
                    .HasName("IX_BD_NEGOCIOS_3");

                entity.HasIndex(e => new { e.IdCliente, e.NoAfiliacion, e.Status })
                    .HasName("IX_BD_NEGOCIOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdNegocio, e.RfcFiscal, e.NoAfiliacion })
                    .HasName("IX_BD_NEGOCIOS_2");

                entity.HasIndex(e => new { e.NoAfiliacion, e.IdCliente, e.Status })
                    .HasName("missing_index_2739_2738");

                entity.HasIndex(e => new { e.NoAfiliacion, e.Status, e.IdCliente })
                    .HasName("missing_index_2737_2736");

                entity.HasIndex(e => new { e.IdNegocio, e.DescNegocio, e.IdCliente, e.Status })
                    .HasName("missing_index_2851_2850");

                entity.HasIndex(e => new { e.IdNegocio, e.IdCliente, e.IdRegion, e.IdZona, e.Status })
                    .HasName("missing_index_236342_236341");

                entity.HasIndex(e => new { e.IdNegocio, e.IdCliente, e.IdZona, e.IdRegion, e.Status })
                    .HasName("missing_index_236340_236339");

                entity.HasIndex(e => new { e.IdNegocio, e.IdRegion, e.IdZona, e.IdEstado, e.IdCliente, e.Status })
                    .HasName("missing_index_3872_3871");

                entity.HasIndex(e => new { e.DescNegocio, e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.Cp, e.IdCliente, e.Status })
                    .HasName("missing_index_1226_1225");

                entity.HasIndex(e => new { e.IdNegocio, e.IdCliente, e.IdRegion, e.IdZona, e.DescNegocio, e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.Cp, e.Status })
                    .HasName("missing_index_244574_244573");

                entity.HasIndex(e => new { e.IdNegocio, e.IdRegion, e.IdZona, e.DescNegocio, e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.Cp, e.IdCliente, e.Status })
                    .HasName("missing_index_244572_244571");

                entity.HasIndex(e => new { e.IdNegocio, e.IdCliente, e.IdRegion, e.DescNegocio, e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.Cp, e.RazonSocial, e.RfcFiscal, e.IdZona, e.Status })
                    .HasName("missing_index_145271_145270");

                entity.HasIndex(e => new { e.IdNegocio, e.IdRegion, e.IdZona, e.DescNegocio, e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.IdEstado, e.Cp, e.Latitud, e.Longitud, e.IdCliente, e.Status })
                    .HasName("missing_index_1231_1230");

                entity.HasIndex(e => new { e.IdNegocio, e.IdCliente, e.IdRegion, e.IdZona, e.IdSegmento, e.DescNegocio, e.NoAfiliacion, e.Telefono, e.Direccion, e.Colonia, e.Poblacion, e.IdEstado, e.Cp, e.IdHorarioUptime, e.IdHorarioAcceso, e.IdCargaAlta, e.IdCargaStatus, e.Latitud, e.Longitud, e.GradoError, e.IdUsuarioAlta, e.FecAlta, e.IdUsuarioUpdate, e.FecUpdate, e.Status, e.Precio, e.IdTipoCobroNegocio, e.IdMoneda, e.RazonSocial, e.NombreFiscal, e.RfcFiscal, e.CalleNumFiscal, e.CpFiscal, e.ColoniaFiscal, e.PoblacionFiscal, e.IdEstadoFiscal, e.FecAltaIguala, e.FecBajaIguala, e.Aproximado, e.CorreoEjecutivo, e.Estado })
                    .HasName("missing_index_256214_256213");

                entity.Property(e => e.CalleNumFiscal).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.ColoniaFiscal).IsUnicode(false);

                entity.Property(e => e.CorreoEjecutivo).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.CpFiscal).IsUnicode(false);

                entity.Property(e => e.DescNegocio).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.IdEstadoFiscal).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.NombreFiscal).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.PoblacionFiscal).IsUnicode(false);

                entity.Property(e => e.RazonSocial).IsUnicode(false);

                entity.Property(e => e.RfcFiscal).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.HasOne(d => d.IdCargaAltaNavigation)
                    .WithMany(p => p.BdNegociosIdCargaAltaNavigation)
                    .HasForeignKey(d => d.IdCargaAlta)
                    .HasConstraintName("FK_BD_NEGOCIOS_BD_CARGAS");

                entity.HasOne(d => d.IdCargaStatusNavigation)
                    .WithMany(p => p.BdNegociosIdCargaStatusNavigation)
                    .HasForeignKey(d => d.IdCargaStatus)
                    .HasConstraintName("FK_BD_NEGOCIOS_BD_CARGAS1");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.BdNegocios)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_BD_NEGOCIOS_SEPOMEX_ESTADOS");

                entity.HasOne(d => d.IdHorarioAccesoNavigation)
                    .WithMany(p => p.BdNegociosIdHorarioAccesoNavigation)
                    .HasForeignKey(d => d.IdHorarioAcceso)
                    .HasConstraintName("FK_BD_NEGOCIOS_C_HORARIOS1");

                entity.HasOne(d => d.IdHorarioUptimeNavigation)
                    .WithMany(p => p.BdNegociosIdHorarioUptimeNavigation)
                    .HasForeignKey(d => d.IdHorarioUptime)
                    .HasConstraintName("FK_BD_NEGOCIOS_C_HORARIOS");
            });

            modelBuilder.Entity<BdNegocios2>(entity =>
            {
                entity.Property(e => e.CalleNumFiscal).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.ColoniaFiscal).IsUnicode(false);

                entity.Property(e => e.CorreoEjecutivo).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.CpFiscal).IsUnicode(false);

                entity.Property(e => e.DescNegocio).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.IdEstadoFiscal).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.NombreFiscal).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.PoblacionFiscal).IsUnicode(false);

                entity.Property(e => e.RazonSocial).IsUnicode(false);

                entity.Property(e => e.RfcFiscal).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<BdNegociosAlta>(entity =>
            {
                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.DescNegocio).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdNegociosAlta)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_BD_NEGOCIOS_ALTA_C_CLIENTES");
            });

            modelBuilder.Entity<BdNegociosPaso2>(entity =>
            {
                entity.HasKey(e => e.IdBdNegocio)
                    .HasName("PK__BD_NEGOC__EFC6A90CA0497576");

                entity.Property(e => e.CalleNumFiscal).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.ColoniaFiscal).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.CpFiscal).IsUnicode(false);

                entity.Property(e => e.DescNegocio).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.IdEstadoFiscal).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.NombreFiscal).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.PoblacionFiscal).IsUnicode(false);

                entity.Property(e => e.RazonSocial).IsUnicode(false);

                entity.Property(e => e.RfcFiscal).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<BdNegociosServiciosDobles>(entity =>
            {
                entity.HasKey(e => e.IdNegocioServicioDoble)
                    .HasName("PK__BD_NEGOC__DD8FA290BCCE31A1");

                entity.Property(e => e.DescripcionServicioDoble).IsUnicode(false);

                entity.Property(e => e.Mensaje).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdOnbaseInbox>(entity =>
            {
                entity.HasKey(e => e.IdOnbaseInbox)
                    .HasName("PK__BD_ONBAS__610C6D1059B23E38");

                entity.HasIndex(e => e.Afiliacion)
                    .HasName("IX_BD_ONBASE_INBOX_1");

                entity.HasIndex(e => e.Arodt)
                    .HasName("IX_BD_ONBASE_INBOX_2");

                entity.HasIndex(e => e.IdOnbaseInbox)
                    .HasName("IX_BD_ONBASE_INBOX_4");

                entity.HasIndex(e => e.Preodt)
                    .HasName("IX_BD_ONBASE_INBOX");

                entity.HasIndex(e => e.Proveedor)
                    .HasName("IX_BD_ONBASE_INBOX_3");

                entity.Property(e => e.Afilamex).IsUnicode(false);

                entity.Property(e => e.Afiliacion).IsUnicode(false);

                entity.Property(e => e.Arodt).IsUnicode(false);

                entity.Property(e => e.Canal).IsUnicode(false);

                entity.Property(e => e.Carga).IsUnicode(false);

                entity.Property(e => e.Codigoproducto).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Comercio).IsUnicode(false);

                entity.Property(e => e.Conectividad).IsUnicode(false);

                entity.Property(e => e.Contacto1).IsUnicode(false);

                entity.Property(e => e.Contacto2).IsUnicode(false);

                entity.Property(e => e.Contactocomercio).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Diasatencion).IsUnicode(false);

                entity.Property(e => e.Domicilio).IsUnicode(false);

                entity.Property(e => e.Ejecutivoka).IsUnicode(false);

                entity.Property(e => e.Ejecutivosucursal).IsUnicode(false);

                entity.Property(e => e.Emailejecutivo).IsUnicode(false);

                entity.Property(e => e.Emailejecutivoka).IsUnicode(false);

                entity.Property(e => e.Emailrespuesta).IsUnicode(false);

                entity.Property(e => e.Emailserv).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Fechaenvio).IsUnicode(false);

                entity.Property(e => e.Foliotelecarga).IsUnicode(false);

                entity.Property(e => e.Horarioatencion).IsUnicode(false);

                entity.Property(e => e.Idamex).IsUnicode(false);

                entity.Property(e => e.Idcaja).IsUnicode(false);

                entity.Property(e => e.Mcc).IsUnicode(false);

                entity.Property(e => e.Modelotpv).IsUnicode(false);

                entity.Property(e => e.Numrollos).IsUnicode(false);

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.Preodt).IsUnicode(false);

                entity.Property(e => e.Producto).IsUnicode(false);

                entity.Property(e => e.Proveedor).IsUnicode(false);

                entity.Property(e => e.Proyecto).IsUnicode(false);

                entity.Property(e => e.Razonsocial).IsUnicode(false);

                entity.Property(e => e.Referenciaubicacion).IsUnicode(false);

                entity.Property(e => e.Rfc).IsUnicode(false);

                entity.Property(e => e.Subtiposervicio).IsUnicode(false);

                entity.Property(e => e.Sucursal).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Telejecutivo).IsUnicode(false);

                entity.Property(e => e.Telsucursal).IsUnicode(false);

                entity.Property(e => e.Tipoab).IsUnicode(false);

                entity.Property(e => e.Tiposervicio).IsUnicode(false);
            });

            modelBuilder.Entity<BdOnbaseInboxConfirmacion>(entity =>
            {
                entity.HasKey(e => e.IdOnbaseInboxConfirmacion)
                    .HasName("PK__BD_ONBAS__58AB64DCF8551C15");

                entity.HasIndex(e => e.Preodt)
                    .HasName("missing_index_260345_260344");

                entity.Property(e => e.Afiliacion).IsUnicode(false);

                entity.Property(e => e.Canal).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Conectividad).IsUnicode(false);

                entity.Property(e => e.Contacto1).IsUnicode(false);

                entity.Property(e => e.Contacto2).IsUnicode(false);

                entity.Property(e => e.Contactocomercio).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Diasatencion).IsUnicode(false);

                entity.Property(e => e.Ejecutivoka).IsUnicode(false);

                entity.Property(e => e.Ejecutivosucursal).IsUnicode(false);

                entity.Property(e => e.Emailejecutivoka).IsUnicode(false);

                entity.Property(e => e.Emailserv).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Foliotelecarga).IsUnicode(false);

                entity.Property(e => e.Horarioatencion).IsUnicode(false);

                entity.Property(e => e.Idcaja).IsUnicode(false);

                entity.Property(e => e.Modelotpv).IsUnicode(false);

                entity.Property(e => e.Poblacion).IsUnicode(false);

                entity.Property(e => e.Preodt).IsUnicode(false);

                entity.Property(e => e.Producto).IsUnicode(false);

                entity.Property(e => e.Proveedor).IsUnicode(false);

                entity.Property(e => e.Proyecto).IsUnicode(false);

                entity.Property(e => e.Referenciaubicacion).IsUnicode(false);

                entity.Property(e => e.Sintoma).IsUnicode(false);

                entity.Property(e => e.Sucursal).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.Telejecutivo).IsUnicode(false);

                entity.Property(e => e.Telsucursal).IsUnicode(false);

                entity.Property(e => e.Tipoab).IsUnicode(false);
            });

            modelBuilder.Entity<BdOpcionesReingenieriaTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdOpcionesReingenieriaTipoUsuario)
                    .HasName("PK__BD_OPCIO__E3409B23F71C8231");
            });

            modelBuilder.Entity<BdOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompra)
                    .HasName("PK__BD_ORDEN__6C6555B88AAE0349");
            });

            modelBuilder.Entity<BdOrdenCompraInsumos>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraInsumo)
                    .HasName("PK__BD_ORDEN__83776C9344C8B686");

                entity.Property(e => e.Total).HasComputedColumnSql("([CANTIDAD]*[COSTO])");
            });

            modelBuilder.Entity<BdOrdenCompraNoFactura>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraNoFactura)
                    .HasName("PK__BD_ORDEN__050DFE803E90B59E");

                entity.Property(e => e.NoFactura).IsUnicode(false);
            });

            modelBuilder.Entity<BdOrdenCompraUnidades>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraUnidad)
                    .HasName("PK__BD_ORDEN__CA8BA0FD21EDC624");

                entity.Property(e => e.Total).HasComputedColumnSql("([CANTIDAD]*[COSTO])");
            });

            modelBuilder.Entity<BdOrdenCompraVendedor>(entity =>
            {
                entity.HasKey(e => e.IdOrdenCompraVendedor)
                    .HasName("PK__BD_ORDEN__BFD995CEE26E874D");

                entity.Property(e => e.CentroCosto).IsUnicode(false);

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Moneda).IsUnicode(false);

                entity.Property(e => e.NoOrdenCompra).IsUnicode(false);

                entity.Property(e => e.TerminoPago).IsUnicode(false);
            });

            modelBuilder.Entity<BdPaseListaTecnico>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdPasoArNumber>(entity =>
            {
                entity.HasKey(e => e.IdPaso)
                    .HasName("PK__BD_PASO___B68ACC884D109FDE");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdPasoCambioStatusUnidadMasivo>(entity =>
            {
                entity.HasKey(e => e.IdPasoCambioStatusUnidadMasivo)
                    .HasName("PK__BD_PASO___EE8C715F2D788351");

                entity.HasIndex(e => e.IdCarga)
                    .HasName("missing_index_236170_236169");

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.Validacion).IsUnicode(false);
            });

            modelBuilder.Entity<BdPeriodoUsuarioInactivo>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusUsuario).IsUnicode(false);
            });

            modelBuilder.Entity<BdPestanasBitacoraAr>(entity =>
            {
                entity.Property(e => e.NombrePestana).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdPlazaCp>(entity =>
            {
                entity.HasIndex(e => e.Cp);

                entity.HasOne(d => d.IdPlazaNavigation)
                    .WithMany(p => p.BdPlazaCp)
                    .HasForeignKey(d => d.IdPlaza)
                    .HasConstraintName("FK_BD_PLAZA_CP_C_PLAZAS");
            });

            modelBuilder.Entity<BdPreciosLicenciaAndroid>(entity =>
            {
                entity.HasKey(e => e.IdPrecioLicencia)
                    .HasName("PK__BD_PRECI__AD3F36D1CCA1633C");

                entity.Property(e => e.RangoLicencia).IsUnicode(false);
            });

            modelBuilder.Entity<BdPreciosLicenciaWeb>(entity =>
            {
                entity.HasKey(e => e.IdPrecioLicencia)
                    .HasName("PK__BD_PRECI__AD3F36D1E8047AD2");

                entity.Property(e => e.RangoLicencia).IsUnicode(false);
            });

            modelBuilder.Entity<BdPresupuestos>(entity =>
            {
                entity.HasIndex(e => new { e.IdRegion, e.IdCliente, e.IdConcepto, e.Year })
                    .HasName("IX_BD_PRESUPUESTOS")
                    .IsUnique();
            });

            modelBuilder.Entity<BdPresupuestosEjercido>(entity =>
            {
                entity.HasIndex(e => new { e.Year, e.Mes, e.IdCliente })
                    .HasName("IX_BD_PRESUPUESTOS_EJERCIDO_1");

                entity.HasIndex(e => new { e.IdConcepto, e.IdCliente, e.IdRegion, e.Mes, e.Semana, e.Importe })
                    .HasName("IX_BD_PRESUPUESTOS_EJERCIDO")
                    .IsUnique();
            });

            modelBuilder.Entity<BdPresupuestosRegional>(entity =>
            {
                entity.HasIndex(e => new { e.IdRegion, e.IdConcepto, e.Year })
                    .HasName("IX_BD_PRESUPUESTOS_REGIONAL")
                    .IsUnique();
            });

            modelBuilder.Entity<BdProactivas>(entity =>
            {
                entity.HasIndex(e => e.NoAfiliacion)
                    .HasName("IX_BD_PROACTIVAS_1");

                entity.HasIndex(e => new { e.Year, e.Month, e.NoAfiliacion })
                    .HasName("IX_BD_PROACTIVAS")
                    .IsUnique();
            });

            modelBuilder.Entity<BdProductoStatusAr>(entity =>
            {
                entity.Property(e => e.StatusBb).IsUnicode(false);

                entity.Property(e => e.StatusWeb).IsUnicode(false);

                entity.HasOne(d => d.IdStatusArNavigation)
                    .WithMany(p => p.BdProductoStatusAr)
                    .HasForeignKey(d => d.IdStatusAr)
                    .HasConstraintName("FK_BD_PRODUCTO_STATUS_AR_C_STATUS_AR");
            });

            modelBuilder.Entity<BdPruebasUnitarias>(entity =>
            {
                entity.HasKey(e => e.IdPruebas)
                    .HasName("PK__BD_PRUEB__9927CC8E9E6934B7");

                entity.Property(e => e.DescError).IsUnicode(false);
            });

            modelBuilder.Entity<BdRecepcionElavon>(entity =>
            {
                entity.Property(e => e.NombreArchivo).IsUnicode(false);
            });

            modelBuilder.Entity<BdRecepcionInsumos>(entity =>
            {
                entity.HasKey(e => e.IdRecepcionInsumo)
                    .HasName("PK__BD_RECEP__3F8A213BECF1FD0F");
            });

            modelBuilder.Entity<BdRecoverPassword>(entity =>
            {
                entity.HasKey(e => e.IdRecoveryPassword)
                    .HasName("PK__BD_RECOV__B61A99475620F5CF");

                entity.Property(e => e.TemporaryPassword).IsUnicode(false);
            });

            modelBuilder.Entity<BdReglasAsignacionAutomatica>(entity =>
            {
                entity.HasKey(e => e.IdReglaAsignacionAutomatica)
                    .HasName("PK__BD_REGLA__0DCA118C14576F0B");
            });

            modelBuilder.Entity<BdReglasModelos>(entity =>
            {
                entity.HasKey(e => e.IdReglas)
                    .HasName("PK__BD_REGLA__DC4295B8DEBA1CB0");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdReglasStatusAlmacen>(entity =>
            {
                entity.Property(e => e.ColorRgb).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdReglasStatusAr>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdClienteProductoStatusArNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdClienteProductoStatusAr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_BD_CLIENTE_PRODUCTO_STATUS_AR");

                entity.HasOne(d => d.IdOperadorNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdOperador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_C_OPERADORES");

                entity.HasOne(d => d.IdTiempoMedicionNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdTiempoMedicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_C_TIEMPO_MEDICION");

                entity.HasOne(d => d.IdTiempoReferenciaNavigation)
                    .WithMany(p => p.BdReglasStatusAr)
                    .HasForeignKey(d => d.IdTiempoReferencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REGLAS_STATUS_AR_C_TIEMPO_REFERENCIA");
            });

            modelBuilder.Entity<BdReingresoSim>(entity =>
            {
                entity.HasOne(d => d.IdSolicitudRecoleccionAnteriorNavigation)
                    .WithMany(p => p.BdReingresoSimIdSolicitudRecoleccionAnteriorNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_SIM_BD_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdSolicitudRecoleccionReingresoNavigation)
                    .WithMany(p => p.BdReingresoSimIdSolicitudRecoleccionReingresoNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_SIM_BD_SOLICITUD_RECOLECCION1");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdReingresoSim)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_REINGRESO_SIM_BD_UNIDADES");
            });

            modelBuilder.Entity<BdReingresoUnidad>(entity =>
            {
                entity.HasIndex(e => e.IdUnidad);

                entity.Property(e => e.NoImeiAnterior).IsUnicode(false);

                entity.Property(e => e.NoImeiReingreso).IsUnicode(false);

                entity.Property(e => e.NoInventarioAnterior).IsUnicode(false);

                entity.Property(e => e.NoInventarioReingreso).IsUnicode(false);

                entity.Property(e => e.NoSerieAnterior).IsUnicode(false);

                entity.Property(e => e.NoSerieReingreso).IsUnicode(false);

                entity.Property(e => e.NoSimAnterior).IsUnicode(false);

                entity.Property(e => e.NoSimReingreso).IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudRecoleccionAnteriorNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_BD_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdSolicitudRecoleccionReingresoNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigation)
                    .HasForeignKey(d => d.IdSolicitudRecoleccionReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_BD_SOLICITUD_RECOLECCION1");

                entity.HasOne(d => d.IdStatusUnidadAnteriorNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdStatusUnidadAnteriorNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_STATUS_UNIDAD");

                entity.HasOne(d => d.IdStatusUnidadReingresoNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdStatusUnidadReingresoNavigation)
                    .HasForeignKey(d => d.IdStatusUnidadReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_STATUS_UNIDAD1");

                entity.HasOne(d => d.IdTipoResponsableAnteriorNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdTipoResponsableAnteriorNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableAnterior)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdTipoResponsableReingresoNavigation)
                    .WithMany(p => p.BdReingresoUnidadIdTipoResponsableReingresoNavigation)
                    .HasForeignKey(d => d.IdTipoResponsableReingreso)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_C_TIPO_RESPONSABLE1");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdReingresoUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REINGRESO_UNIDAD_BD_UNIDADES");
            });

            modelBuilder.Entity<BdRelacionFacturaEnvio>(entity =>
            {
                entity.HasKey(e => e.IdRelacionFacturaEnvio)
                    .HasName("PK__BD_RELAC__9A00745F38B1DE48");

                entity.Property(e => e.NoFactura).IsUnicode(false);
            });

            modelBuilder.Entity<BdReparacionUnidad>(entity =>
            {
                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => new { e.IdReparacionUnidad, e.IdUnidad, e.IdTecnico, e.IdStatusReparacion })
                    .HasName("IX_MI_BD_REPARACION_UNIDAD_6108_6107");

                entity.HasIndex(e => new { e.IdUnidad, e.IdTecnico, e.IdStatusReparacion, e.IdUsuarioAlta })
                    .HasName("IX_MI_BD_REPARACION_UNIDAD_195_194");

                entity.Property(e => e.DescReparacion).IsUnicode(false);
            });

            modelBuilder.Entity<BdReparecionesCargaPdf>(entity =>
            {
                entity.HasKey(e => e.IdReparacionCargaPdf)
                    .HasName("PK__BD_REPAR__CEE12DE5E1221796");

                entity.Property(e => e.ArchivoSistema).IsUnicode(false);

                entity.Property(e => e.ArchivoUsuario).IsUnicode(false);
            });

            modelBuilder.Entity<BdReporteCierre>(entity =>
            {
                entity.HasKey(e => e.IdReporteCierre)
                    .HasName("PK_C_REPORTES_CIERRE");

                entity.HasIndex(e => new { e.IdReporteCierre, e.IdCliente })
                    .HasName("IX_BD_REPORTE_CIERRE_ID_CLIENTE");

                entity.HasIndex(e => new { e.IdReporteCierre, e.FecAlta, e.IdUsuarioAlta, e.IdCliente, e.Status, e.IdStatusReporteCierre })
                    .HasName("IX_MI_BD_REPORTE_CIERRE_19_18");

                entity.HasIndex(e => new { e.IdReporteCierre, e.IdCliente, e.FecAlta, e.IdUsuarioAlta, e.Status, e.IdStatusReporteCierre })
                    .HasName("IX_MI_BD_REPORTE_CIERRE_21_20");

                entity.Property(e => e.Report).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdReporteCierre)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_C_REPORTES_CIERRE_C_CLIENTES");

                entity.HasOne(d => d.IdStatusReporteCierreNavigation)
                    .WithMany(p => p.BdReporteCierre)
                    .HasForeignKey(d => d.IdStatusReporteCierre)
                    .HasConstraintName("FK_BD_REPORTE_CIERRE_C_STATUS_REPORTE_CIERRE");
            });

            modelBuilder.Entity<BdReporteCierreAr>(entity =>
            {
                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdReporteCierre);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdReporteCierreAr)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REPORTE_CIERRE_AR_C_CLIENTES");

                entity.HasOne(d => d.IdReporteCierreNavigation)
                    .WithMany(p => p.BdReporteCierreAr)
                    .HasForeignKey(d => d.IdReporteCierre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REPORTE_CIERRE_AR_C_REPORTES_CIERRE");
            });

            modelBuilder.Entity<BdReporteMovInventario>(entity =>
            {
                entity.HasOne(d => d.IdReporteMovInventarioNavigation)
                    .WithMany(p => p.BdReporteMovInventario)
                    .HasForeignKey(d => d.IdReporteMovInventario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_REPORTE_MOV_INVENTARIO_C_REPORTE_MOV_INVENTARIO");
            });

            modelBuilder.Entity<BdRetiros>(entity =>
            {
                entity.HasIndex(e => e.FecAlta)
                    .HasName("IX_BD_RETIROS_1");

                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdNegocio);

                entity.HasIndex(e => e.IdTecnico)
                    .HasName("IX_BD_RETIROS");

                entity.HasIndex(e => new { e.IdAr, e.FecAlta, e.IdUnidad })
                    .HasName("IX_BD_RETIROS_ID_UNIDAD");

                entity.Property(e => e.Tipo).IsUnicode(false);

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdRetiros)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_RETIROS_BD_NEGOCIOS");

                entity.HasOne(d => d.IdParentNavigation)
                    .WithMany(p => p.BdRetirosIdParentNavigation)
                    .HasForeignKey(d => d.IdParent)
                    .HasConstraintName("FK_BD_RETIROS_BD_UNIDADES1");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.BdRetiros)
                    .HasForeignKey(d => d.IdTecnico)
                    .HasConstraintName("FK_BD_RETIROS_C_USUARIOS");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdRetirosIdUnidadNavigation)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_RETIROS_BD_UNIDADES");
            });

            modelBuilder.Entity<BdServicioCausa>(entity =>
            {
                entity.HasOne(d => d.IdCausaNavigation)
                    .WithMany(p => p.BdServicioCausa)
                    .HasForeignKey(d => d.IdCausa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_CAUSA_C_CAUSAS");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.BdServicioCausa)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_CAUSA_C_SERVICIOS");
            });

            modelBuilder.Entity<BdServicioCausaRechazoPrecio>(entity =>
            {
                entity.HasIndex(e => e.IdServicio)
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_149568_149567");

                entity.HasIndex(e => new { e.IdCliente, e.IdServicio, e.IdEspecificacionCausaRechazo })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10243_10242");

                entity.HasIndex(e => new { e.IdServicio, e.IdEspecificacionCausaRechazo, e.IdCliente })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10233_10232");

                entity.HasIndex(e => new { e.IdServicioCausaRechazoPrecio, e.IdServicio, e.IdEspecificacionCausaRechazo })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_149573_149572");

                entity.HasIndex(e => new { e.IdCliente, e.IdServicio, e.IdEspecificacionCausaRechazo, e.Precio })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10229_10228");

                entity.HasIndex(e => new { e.IdServicio, e.IdEspecificacionCausaRechazo, e.IdCliente, e.Precio })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10231_10230");

                entity.HasIndex(e => new { e.IdServicio, e.IdEspecificacionCausaRechazo, e.Precio, e.IdCliente })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10248_10247");

                entity.HasIndex(e => new { e.Precio, e.IdCliente, e.IdServicio, e.IdEspecificacionCausaRechazo })
                    .HasName("IX_MI_BD_SERVICIO_CAUSA_RECHAZO_PRECIO_10246_10245");
            });

            modelBuilder.Entity<BdServicioMovInv>(entity =>
            {
                entity.HasKey(e => e.IdServicioMovInv)
                    .HasName("PK_BD_SERVICIO_MOV_INT");

                entity.HasOne(d => d.IdMovInvNavigation)
                    .WithMany(p => p.BdServicioMovInv)
                    .HasForeignKey(d => d.IdMovInv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_MOV_INT_C_MOV_INV");
            });

            modelBuilder.Entity<BdServicioSegmento>(entity =>
            {
                entity.HasIndex(e => new { e.IdServicio, e.IdSegmento, e.IdTipoPlaza })
                    .HasName("IX_BD_SERVICIO_SEGMENTO_ID_SERVICIO, ID_SEGMENTO, ID_TIPO_PLAZA");
            });

            modelBuilder.Entity<BdServicioSolucion>(entity =>
            {
                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.BdServicioSolucion)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_SOLUCION_C_SERVICIOS");

                entity.HasOne(d => d.IdSolucionNavigation)
                    .WithMany(p => p.BdServicioSolucion)
                    .HasForeignKey(d => d.IdSolucion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIO_SOLUCION_C_SOLUCIONES");
            });

            modelBuilder.Entity<BdServicioWeekhour>(entity =>
            {
                entity.HasIndex(e => new { e.IdWeekhour, e.IdServicio })
                    .HasName("IX_BD_SERVICIO_WEEKHOUR_ID_SERVICIO");
            });

            modelBuilder.Entity<BdSims>(entity =>
            {
                entity.HasIndex(e => e.IdUnidad);

                entity.HasIndex(e => e.NoSim)
                    .HasName("IX_MI_BD_SIMS_4794_4793");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.Status })
                    .HasName("IX_BD_SIMS_ID_SOLICITUD_RECOLECCION, STATUS");

                entity.HasIndex(e => new { e.NoSim, e.Status })
                    .HasName("IX_MI_BD_SIMS_4796_4795");

                entity.Property(e => e.NoImei).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdSimsAlta>(entity =>
            {
                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdSoftelPaso>(entity =>
            {
                entity.HasKey(e => e.IdSoftelPaso)
                    .HasName("PK__BD_SOFTE__2BA7B6E7D84AB152");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.From).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);
            });

            modelBuilder.Entity<BdSolicitudAlmacenComentario>(entity =>
            {
                entity.HasKey(e => e.IdComentarioSolicitudAlmacen)
                    .HasName("PK_BD_COMENTARIO_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescComentarioSolicitudAlmacen).IsUnicode(false);
            });

            modelBuilder.Entity<BdSolicitudCorreo>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudCorreo)
                    .HasName("PK_BD_SOLICITUDES_CORREO");
            });

            modelBuilder.Entity<BdSolicitudCorreoLog>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudCorreoLog)
                    .HasName("PK_BD_SOLICITUD_CORREOLOG");
            });

            modelBuilder.Entity<BdSolicitudCorreoOki>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudCorreoOki)
                    .HasName("PK_BD_SOLICITUDES_CORREO_OKI");
            });

            modelBuilder.Entity<BdSolicitudRecoleccion>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudRecoleccion)
                    .HasName("PK_BD_SOLICITUDES_RECOLECCION");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.IdStatusSolicitudRecoleccion })
                    .HasName("IX_MI_BD_SOLICITUD_RECOLECCION_4785_4784");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.IdCliente, e.IdAlmacenDestino, e.IdServicioMensajeria, e.IdStatusSolicitudRecoleccion })
                    .HasName("IX_MI_BD_SOLICITUD_RECOLECCION_4787_4786");

                entity.Property(e => e.CalleNum).IsUnicode(false);

                entity.Property(e => e.Ciudad).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Delegacion).IsUnicode(false);

                entity.Property(e => e.Distribuidor).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.HasOne(d => d.IdChoferNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdChofer)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_C_CHOFERES");

                entity.HasOne(d => d.IdStatusSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdStatusSolicitudRecoleccion)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_C_STATUS_SOLICITUD_RECOLECCION");

                entity.HasOne(d => d.IdUnidadMensajeriaNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccion)
                    .HasForeignKey(d => d.IdUnidadMensajeria)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_C_UNIDAD_MENSAJERIA");
            });

            modelBuilder.Entity<BdSolicitudRecoleccionInsumos>(entity =>
            {
                entity.HasOne(d => d.IdSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccionInsumos)
                    .HasForeignKey(d => d.IdSolicitudRecoleccion)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_INSUMOS_BD_SOLICITUD_RECOLECCION");
            });

            modelBuilder.Entity<BdSolicitudRecoleccionModelo>(entity =>
            {
                entity.HasOne(d => d.IdSolicitudRecoleccionNavigation)
                    .WithMany(p => p.BdSolicitudRecoleccionModelo)
                    .HasForeignKey(d => d.IdSolicitudRecoleccion)
                    .HasConstraintName("FK_BD_SOLICITUD_RECOLECCION_MODELO_BD_SOLICITUD_RECOLECCION");
            });

            modelBuilder.Entity<BdSolicitudesAlmacen>(entity =>
            {
                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdEnvio);

                entity.HasIndex(e => new { e.IdStatusSolicitudAlmacen, e.IdEnvio })
                    .HasName("IX_BD_SOLICITUDES_ALMACEN_ID_STATUS_SOLICITUD_ALMACEN, ID_ENVIO");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.IdUsuarioAlta, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_MI_BD_SOLICITUDES_ALMACEN_21326_21325");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdAlmacen, e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.IdUsuarioAlta, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_MI_BD_SOLICITUDES_ALMACEN_4_3");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.IdUsuarioAlta, e.FecAlta, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_MI_BD_SOLICITUDES_ALMACEN_22_21");

                entity.HasIndex(e => new { e.IdSolicitudAlmacen, e.IdTipoSolicitudAlmacen, e.IdUrgenciaSolicitudAlmacen, e.IdAr, e.FecCompromiso, e.IdUsuarioAlta, e.FecAlta, e.IdStatusSolicitudAlmacen })
                    .HasName("IX_BD_SOLICITUDES_ALMACEN_ID_STATUS_SOLICITUD_ALMACEN");

                entity.Property(e => e.Notas).IsUnicode(false);

                entity.Property(e => e.OtraDireccion).IsUnicode(false);

                entity.HasOne(d => d.IdDireccionNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdDireccion)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_BD_DIRECCIONES");

                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdSparePart)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_SPARE_PARTS");

                entity.HasOne(d => d.IdTipoResponsableDestinoNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdTipoResponsableDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_TIPO_SERVICIO_SOLICITUD_ALMACEN2");

                entity.HasOne(d => d.IdTipoSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdTipoSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_TIPO_SOLICITUD_ALMACEN");

                entity.HasOne(d => d.IdUrgenciaSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacen)
                    .HasForeignKey(d => d.IdUrgenciaSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_C_URGENCIA_SOLICITUD_ALMACEN");
            });

            modelBuilder.Entity<BdSolicitudesAlmacenOld>(entity =>
            {
                entity.HasIndex(e => e.IdAr)
                    .HasName("IX_BD_SOLICITUDES_ALMACEN_ID_AR");

                entity.Property(e => e.Notas).IsUnicode(false);

                entity.HasOne(d => d.IdAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_ALMACENES");

                entity.HasOne(d => d.IdResponsableDestinoNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOldIdResponsableDestinoNavigation)
                    .HasForeignKey(d => d.IdResponsableDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_USUARIOS");

                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdSparePart)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_SPARE_PARTS");

                entity.HasOne(d => d.IdTipoResponsableDestinoNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdTipoResponsableDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_TIPO_RESPONSABLE");

                entity.HasOne(d => d.IdTipoSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdTipoSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_TIPO_SOLICITUD_ALMACEN");

                entity.HasOne(d => d.IdUrgenciaSolicitudAlmacenNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOld)
                    .HasForeignKey(d => d.IdUrgenciaSolicitudAlmacen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_URGENCIA_SOLICITUD_ALMACEN");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOldIdUsuarioAltaNavigation)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_USUARIOS1");

                entity.HasOne(d => d.IdUsuarioConfirmNavigation)
                    .WithMany(p => p.BdSolicitudesAlmacenOldIdUsuarioConfirmNavigation)
                    .HasForeignKey(d => d.IdUsuarioConfirm)
                    .HasConstraintName("FK_BD_SOLICITUDES_ALMACEN_OLD_C_USUARIOS2");
            });

            modelBuilder.Entity<BdSolicitudesDevolucion>(entity =>
            {
                entity.Property(e => e.CalleNum).IsUnicode(false);

                entity.Property(e => e.Ciudad).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.Delegacion).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Notas).IsUnicode(false);
            });

            modelBuilder.Entity<BdSolicitudesDevolucionInsumos>(entity =>
            {
                entity.Property(e => e.Cantidad).IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionInsumos)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_INSUMO_C_USUARIOS");
            });

            modelBuilder.Entity<BdSolicitudesDevolucionItems>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudDevolucionItem)
                    .HasName("PK_BD_SOLICITUDES_DEVOLUCION_INSUMO");

                entity.Property(e => e.Cantidad).IsUnicode(false);
            });

            modelBuilder.Entity<BdSolicitudesDevolucionModelo>(entity =>
            {
                entity.HasOne(d => d.IdModeloNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionModelo)
                    .HasForeignKey(d => d.IdModelo)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_MODELO_C_MODELOS");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionModelo)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_MODELO_C_USUARIOS");
            });

            modelBuilder.Entity<BdSolicitudesDevolucionUnidad>(entity =>
            {
                entity.HasIndex(e => e.NoSerie)
                    .HasName("IX_MI_BD_SOLICITUDES_DEVOLUCION_UNIDAD_34302_34301");

                entity.HasIndex(e => new { e.IdSolicitudDevolucionUnidad, e.IdUnidad, e.IdSolicitudDevolucion, e.IsRecibidoRetorno })
                    .HasName("IX_BD_SOLICITUDES_DEVOLUCION_UNIDAD_ID_SOLICITUD_DEVOLUCION, IS_RECIBIDO_RETORNO");

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionUnidad)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_UNIDAD_BD_UNIDADES");

                entity.HasOne(d => d.IdUsuarioAltaNavigation)
                    .WithMany(p => p.BdSolicitudesDevolucionUnidad)
                    .HasForeignKey(d => d.IdUsuarioAlta)
                    .HasConstraintName("FK_BD_SOLICITUDES_DEVOLUCION_UNIDAD_C_USUARIOS");
            });

            modelBuilder.Entity<BdSolicitudesViaticos>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudViaticos)
                    .HasName("PK_C_SOLICITUD_VIATICO");

                entity.HasIndex(e => e.IdAr);

                entity.HasIndex(e => e.IdComprobacionSolicitudesViaticos)
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_120168_120167");

                entity.HasIndex(e => new { e.IdUsuarioSolicitado, e.IdStatusSolicitudViaticos, e.FecConfirmacion })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_97642_97641");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.IdStatusSolicitudViaticos, e.IdUsuarioSolicitado, e.FecConfirmacion })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_97748_97747");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.IdUsuarioSolicitado, e.IdUsuarioAlta, e.IdStatusSolicitudViaticos })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_8692_8691");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.Destino, e.IdUsuarioSolicitado, e.IdUsuarioAlta, e.IdStatusSolicitudViaticos })
                    .HasName("IX_BD_SOLICITUDES_VIATICOS_ID_STATUS_SOLICITUD_VIATICOS");

                entity.HasIndex(e => new { e.IdSolicitudViaticos, e.IdAr, e.Destino, e.IdUsuarioSolicitado, e.IdUsuarioAlta, e.IdStatusSolicitudViaticos, e.FecAlta })
                    .HasName("IX_MI_BD_SOLICITUDES_VIATICOS_27346_27345");

                entity.Property(e => e.ComentarioAutorizador).IsUnicode(false);

                entity.Property(e => e.ComentarioConfirmador).IsUnicode(false);

                entity.Property(e => e.ComentarioSolicitante).IsUnicode(false);

                entity.Property(e => e.Destino).IsUnicode(false);

                entity.Property(e => e.NumConfirmacion).IsUnicode(false);

                entity.HasOne(d => d.IdStatusSolicitudViaticosNavigation)
                    .WithMany(p => p.BdSolicitudesViaticos)
                    .HasForeignKey(d => d.IdStatusSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_C_SOLICITUD_VIATICO_C_STATUS_SOLICITUD_VIATICOS");
            });

            modelBuilder.Entity<BdSolicitudesViaticosConceptos>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudViaticosConcepto)
                    .HasName("PK_BD_SOLICITUDES_VIATICOS_CONCEPTO");

                entity.HasIndex(e => e.IdSolicitudViaticos);

                entity.Property(e => e.CantidadSolicitadaReal).IsUnicode(false);

                entity.Property(e => e.Kilometros).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.HasOne(d => d.IdSolicitudViaticosNavigation)
                    .WithMany(p => p.BdSolicitudesViaticosConceptos)
                    .HasForeignKey(d => d.IdSolicitudViaticos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_VIATICOS_CONCEPTO_BD_SOLICITUDES_VIATICOS");

                entity.HasOne(d => d.IdViaticoNavigation)
                    .WithMany(p => p.BdSolicitudesViaticosConceptos)
                    .HasForeignKey(d => d.IdViatico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SOLICITUDES_VIATICOS_CONCEPTO_C_VIATICOS");
            });

            modelBuilder.Entity<BdSoporteTecnico>(entity =>
            {
                entity.HasIndex(e => new { e.IdSoporteTecnico, e.IdAr, e.IdUsuarioSoporte, e.Status })
                    .HasName("IX_BD_SOPORTE_TECNICO_STATUS");

                entity.HasIndex(e => new { e.IdSoporteTecnico, e.IdUsuarioSoporte, e.IdAr, e.Status })
                    .HasName("IX_BD_SOPORTE_TECNICO_ID_AR, STATUS");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoSoporteTecnicoNavigation)
                    .WithMany(p => p.BdSoporteTecnico)
                    .HasForeignKey(d => d.IdTipoSoporteTecnico)
                    .HasConstraintName("FK_BD_SOPORTE_TECNICO_C_TIPO_SOPORTE_TECNICO");
            });

            modelBuilder.Entity<BdSparePartPrecio>(entity =>
            {
                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BdSparePartPrecio)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SPARE_PART_PRECIO_C_CLIENTES");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.BdSparePartPrecio)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK_BD_SPARE_PART_PRECIO_C_MONEDAS");

                entity.HasOne(d => d.IdSparePartNavigation)
                    .WithMany(p => p.BdSparePartPrecio)
                    .HasForeignKey(d => d.IdSparePart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SPARE_PART_PRECIO_C_SPARE_PARTS");
            });

            modelBuilder.Entity<BdStatusDoctoTipoResponsablePrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdStatusDoctoTipoResponsablePrefacturacion)
                    .HasName("PK_BD_MOV_DOCTOS_PREFACTURACION");
            });

            modelBuilder.Entity<BdStoreAltaManual>(entity =>
            {
                entity.HasKey(e => e.IdStoreAltaManual)
                    .HasName("PK__BD_STORE__B987F7023CE46150");

                entity.Property(e => e.Texto).IsUnicode(false);
            });

            modelBuilder.Entity<BdSustituciones>(entity =>
            {
                entity.HasIndex(e => new { e.IdNegocio, e.IdUnidadEntrada })
                    .HasName("missing_index_1120489_1120488");

                entity.HasIndex(e => new { e.IdTecnico, e.IdUnidadEntrada })
                    .HasName("missing_index_1120491_1120490");

                entity.Property(e => e.NoEquipoEntrada).IsUnicode(false);

                entity.Property(e => e.NoEquipoSalida).IsUnicode(false);

                entity.HasOne(d => d.IdNegocioNavigation)
                    .WithMany(p => p.BdSustituciones)
                    .HasForeignKey(d => d.IdNegocio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_BD_NEGOCIOS");

                entity.HasOne(d => d.IdTecnicoNavigation)
                    .WithMany(p => p.BdSustituciones)
                    .HasForeignKey(d => d.IdTecnico)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_C_USUARIOS");

                entity.HasOne(d => d.IdUnidadEntradaNavigation)
                    .WithMany(p => p.BdSustitucionesIdUnidadEntradaNavigation)
                    .HasForeignKey(d => d.IdUnidadEntrada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_BD_UNIDADES");

                entity.HasOne(d => d.IdUnidadSalidaNavigation)
                    .WithMany(p => p.BdSustitucionesIdUnidadSalidaNavigation)
                    .HasForeignKey(d => d.IdUnidadSalida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SUSTITUCIONES_BD_UNIDADES1");
            });

            modelBuilder.Entity<BdTempCorreccion>(entity =>
            {
                entity.Property(e => e.DescNegocio).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.NoSerieMal).IsUnicode(false);

                entity.Property(e => e.NoSerieOk).IsUnicode(false);
            });

            modelBuilder.Entity<BdTerminales>(entity =>
            {
                entity.HasKey(e => e.IdTerminal)
                    .HasName("PK__BD_TERMINALES__403C232B");

                entity.HasIndex(e => e.IdTerminal)
                    .HasName("PK_BD_TERMINALES")
                    .IsUnique();

                entity.Property(e => e.AppRoute).IsUnicode(false);

                entity.Property(e => e.DescTerminal).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DocRoute).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);

                entity.Property(e => e.WebRoute).IsUnicode(false);
            });

            modelBuilder.Entity<BdTipoPlan>(entity =>
            {
                entity.Property(e => e.DescTipoPlan).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdTipoPlazaClienteCp>(entity =>
            {
                entity.HasIndex(e => e.Cp);

                entity.HasIndex(e => new { e.IdTipoPlazaClienteCp, e.Cp, e.IdTipoPlazaCliente })
                    .HasName("missing_index_3665_3664");

                entity.Property(e => e.Cp).IsUnicode(false);
            });

            modelBuilder.Entity<BdTipoServicioProducto>(entity =>
            {
                entity.HasOne(d => d.IdTipoCobroNavigation)
                    .WithMany(p => p.BdTipoServicioProducto)
                    .HasForeignKey(d => d.IdTipoCobro)
                    .HasConstraintName("FK_BD_TIPO_SERVICIO_PRODUCTO_C_TIPO_COBRO");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.BdTipoServicioProducto)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_TIPO_SERVICIO_PRODUCTO_C_TIPO_SERVICIO");
            });

            modelBuilder.Entity<BdTpvsAlta>(entity =>
            {
                entity.HasIndex(e => e.NoSerie)
                    .HasName("IX_MI_BD_TPVS_ALTA_27385_27384");

                entity.HasIndex(e => new { e.IdTpvAlta, e.IdModelo, e.IdSolicitudRecoleccion })
                    .HasName("IX_MI_BD_TPVS_ALTA_27400_27399");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.NoSerie, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27389_27388");

                entity.HasIndex(e => new { e.NoSerie, e.IsReingreso, e.IsProcesada, e.IsCambioModelo })
                    .HasName("IX_MI_BD_TPVS_ALTA_27383_27382");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.NoImei, e.NoSim, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27398_27397");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.NoSerie, e.NoSim, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27419_27418");

                entity.HasIndex(e => new { e.IdModelo, e.NoSerie, e.IdModeloAnt, e.IsReingreso, e.IsProcesada, e.IsCambioModelo })
                    .HasName("IX_MI_BD_TPVS_ALTA_27387_27386");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.IdResponsable, e.NoSerie, e.IdUsuarioAlta, e.IsAsignada, e.IsProcesada })
                    .HasName("IX_MI_BD_TPVS_ALTA_27391_27390");

                entity.Property(e => e.MsgErrorSerie).IsUnicode(false);

                entity.Property(e => e.NoImei).IsUnicode(false);

                entity.Property(e => e.NoInventario).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdTransacciones>(entity =>
            {
                entity.HasIndex(e => e.NoFiliacion)
                    .HasName("IX_BD_TRANSACCIONES_2");

                entity.HasIndex(e => new { e.Month, e.Year, e.NoFiliacion })
                    .HasName("IX_BD_TRANSACCIONES_1")
                    .IsUnique();
            });

            modelBuilder.Entity<BdTransaccionesPaso>(entity =>
            {
                entity.HasIndex(e => new { e.NoAfiliacion, e.ApprovedcCount, e.Declinedcount, e.IdCarga, e.IsError })
                    .HasName("missing_index_653860_653859");

                entity.HasIndex(e => new { e.Month, e.Year, e.NoAfiliacion, e.ApprovedcCount, e.Declinedcount, e.IdCarga, e.IsError })
                    .HasName("missing_index_645850_645849");

                entity.Property(e => e.DescError).IsUnicode(false);
            });

            modelBuilder.Entity<BdTransaccionesRespaldo>(entity =>
            {
                entity.HasKey(e => e.IdTransaccionRespaldo)
                    .HasName("PK__BD_TRANS__9723621E46E1D854");
            });

            modelBuilder.Entity<BdTransferencias>(entity =>
            {
                entity.HasKey(e => e.IdTransferencia)
                    .HasName("PK__BD_TRANS__20A04596E971E01A");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.SystemFilename).IsUnicode(false);

                entity.Property(e => e.UserFilename).IsUnicode(false);
            });

            modelBuilder.Entity<BdTransferenciasPaso>(entity =>
            {
                entity.HasKey(e => e.IdTransferenciaPaso)
                    .HasName("PK__BD_TRANS__BEB61D8067319EBB");

                entity.HasIndex(e => new { e.IdTransferenciaPaso, e.NoSerie, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdTipoResponsableDestino, e.IdResponsableDestino, e.IdUsuario, e.IdTransferencia })
                    .HasName("missing_index_278_277");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);
            });

            modelBuilder.Entity<BdTransferenciasUnidad>(entity =>
            {
                entity.HasKey(e => e.IdTransferenciaUnidad)
                    .HasName("PK__BD_TRANS__27E50C086838334E");

                entity.HasIndex(e => new { e.IdTransferencia, e.IdUnidad })
                    .HasName("missing_index_3682_3681");

                entity.HasIndex(e => new { e.IdTransferencia, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdTipoResponsableDestino, e.IdResponsableDestino, e.IdUnidad })
                    .HasName("IX_BD_TRANSFERENCIAS_UNIDAD_ID_UNIDAD");

                entity.HasIndex(e => new { e.IdTransferencia, e.IdUnidad, e.IdTipoResponsableOrigen, e.IdResponsableOrigen, e.IdResponsableDestino, e.IsRecibido, e.IdTipoResponsableDestino })
                    .HasName("missing_index_280_279");
            });

            modelBuilder.Entity<BdUnidadAccesorio>(entity =>
            {
                entity.HasIndex(e => e.IdUnidad);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.HasOne(d => d.IdAccesorioNavigation)
                    .WithMany(p => p.BdUnidadAccesorio)
                    .HasForeignKey(d => d.IdAccesorio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_ACCESORIO_C_ACCESORIOS");

                entity.HasOne(d => d.IdStatusAccesorioNavigation)
                    .WithMany(p => p.BdUnidadAccesorio)
                    .HasForeignKey(d => d.IdStatusAccesorio)
                    .HasConstraintName("FK_BD_UNIDAD_ACCESORIO_C_STATUS_ACCESORIO");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.BdUnidadAccesorio)
                    .HasForeignKey(d => d.IdUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDAD_ACCESORIO_BD_UNIDADES");
            });

            modelBuilder.Entity<BdUnidades>(entity =>
            {
                entity.HasIndex(e => e.IdItemsSolicitudAlmacen)
                    .HasName("IX_MI_BD_UNIDADES_3420_3419");

                entity.HasIndex(e => e.IdModelo);

                entity.HasIndex(e => e.IdOrdenCompra)
                    .HasName("missing_index_200171_200170");

                entity.HasIndex(e => e.IdParent);

                entity.HasIndex(e => e.IdProducto);

                entity.HasIndex(e => e.IdResponsable);

                entity.HasIndex(e => e.IdStatusUnidad);

                entity.HasIndex(e => e.IdTipoResponsable);

                entity.HasIndex(e => e.IdUnidad)
                    .HasName("missing_index_ID_UNIDAD");

                entity.HasIndex(e => e.NoInventario);

                entity.HasIndex(e => e.NoSerie)
                    .IsUnique();

                entity.HasIndex(e => e.NoSim)
                    .HasName("IX_MI_BD_UNIDADES_36101_36100");

                entity.HasIndex(e => new { e.IdProducto, e.IdMarca })
                    .HasName("IX_MI_BD_UNIDADES_1945_1944");

                entity.HasIndex(e => new { e.IdSolicitudRecoleccion, e.Status })
                    .HasName("IX_BD_UNIDADES_ID_SOLICITUD_RECOLECCION, STATUS");

                entity.HasIndex(e => new { e.IdStatusUnidad, e.Status })
                    .HasName("IX_BD_UNIDADES_ID_STATUS_UNIDAD, STATUS");

                entity.HasIndex(e => new { e.IdTipoResponsable, e.IdResponsable })
                    .HasName("IX_MI_BD_UNIDADES_8869_8868");

                entity.HasIndex(e => new { e.IdTipoResponsable, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_BD_UNIDADES_ID_TIPO_RESPONSABLE, ID_RESPONSABLE, ID_STATUS_UNIDAD");

                entity.HasIndex(e => new { e.IdUnidad, e.IdSim, e.IdTipoResponsable })
                    .HasName("missing_index_39390_39389");

                entity.HasIndex(e => new { e.IdMarca, e.IdModelo, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_BD_UNIDADES_ID_MARCA, ID_MODELO, ID_RESPONSABLE, ID_STATUS_UNIDAD");

                entity.HasIndex(e => new { e.IdTipoResponsable, e.IdResponsable, e.IdStatusUnidad, e.Status })
                    .HasName("missing_index_1539_1538");

                entity.HasIndex(e => new { e.IdCliente, e.IdMarca, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada })
                    .HasName("IX_BD_UNIDADES_ID_CLIENTE, ID_MARCA, ID_TIPO_RESPONSABLE, ID_RESPONSABLE, IS_DANIADA");

                entity.HasIndex(e => new { e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_30715_30714");

                entity.HasIndex(e => new { e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.Status, e.IdStatusUnidad })
                    .HasName("missing_index_1099_1098");

                entity.HasIndex(e => new { e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.IsRetiro, e.IdStatusUnidad, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_4166_4165");

                entity.HasIndex(e => new { e.IdMarca, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada, e.Status, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_22355_22354");

                entity.HasIndex(e => new { e.IdCliente, e.IdMarca, e.IdModelo, e.IdTipoResponsable, e.IsDaniada, e.IdStatusUnidad, e.IdResponsable })
                    .HasName("IX_MI_BD_UNIDADES_3434_3433");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IdProducto, e.IdResponsable, e.IsDaniada, e.IdStatusUnidad, e.IdTipoResponsable, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_413_412");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IdProducto, e.IdTipoResponsable, e.IdResponsable, e.IsDaniada, e.IdStatusUnidad, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_415_414");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.IsDaniada, e.IdStatusUnidad, e.IdProducto, e.IsRetiro, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_64246_64245");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.IsDaniada, e.IdStatusUnidad, e.IsRetiro, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_64248_64247");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.Status })
                    .HasName("IX_BD_UNIDADES_STATUS");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IdStatusUnidad, e.IdCliente, e.IdSim, e.Status, e.IdTipoResponsable })
                    .HasName("missing_index_47726_47725");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.PosicionInventario, e.FecAlta, e.IdCliente, e.IdMarca, e.IdTipoResponsable, e.IsDaniada, e.Status, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_187660_187659");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.NoSerie, e.NoInventario, e.NoImei, e.PosicionInventario, e.FecAlta, e.IdCliente, e.IdMarca, e.IdModelo, e.IdTipoResponsable, e.IsDaniada, e.Status, e.IdResponsable, e.IdStatusUnidad })
                    .HasName("IX_MI_BD_UNIDADES_82332_82331");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdSim, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdCliente, e.Status })
                    .HasName("IX_BD_UNIDADES_ID_CLIENTE, STATUS");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IdStatusUnidad, e.IdCliente, e.IdSim, e.Status, e.IdConectividad, e.IdTipoResponsable })
                    .HasName("missing_index_13281_13280");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.PosicionInventario, e.IsDaniada, e.FecAlta, e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.IsRetiro, e.IdStatusUnidad, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_4171_4170");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IdStatusUnidad, e.IdCliente, e.IdSim, e.Status, e.IdTipoResponsable })
                    .HasName("missing_index_118499_118498");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdSim, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdNivelDiagnostico, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_83_82");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdSim, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdNivelDiagnostico, e.IdCliente, e.Status })
                    .HasName("IX_MI_BD_UNIDADES_81_80");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IdStatusUnidad, e.IdCliente, e.Status, e.IdAplicativo, e.IdConectividad, e.IdTipoResponsable })
                    .HasName("missing_index_3944_3943");

                entity.HasIndex(e => new { e.IdUnidad, e.IdCliente, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.IdResponsable, e.PosicionInventario, e.IsRetiro, e.IsDaniada, e.FecAlta, e.IdAplicativo, e.IdConectividad, e.IdTipoResponsable, e.IdStatusUnidad, e.Status })
                    .HasName("missing_index_2282_2281");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.IdAplicativo, e.IdConectividad, e.IdCliente, e.IdSim, e.Status, e.IdTipoResponsable })
                    .HasName("missing_index_118506_118505");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdAplicativo, e.IdNivelDiagnostico, e.IdConectividad, e.IdCliente, e.Status, e.IdTipoResponsable })
                    .HasName("missing_index_75902_75901");

                entity.HasIndex(e => new { e.IdUnidad, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.IdSim, e.NoImei, e.NoSim, e.PosicionInventario, e.IsDaniada, e.FecAlta, e.IdAplicativo, e.NoTarima, e.IdConectividad, e.IdCliente, e.IdTipoResponsable, e.IdResponsable, e.Status, e.IdStatusUnidad })
                    .HasName("missing_index_1097_1096");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdAplicativo, e.IdNivelDiagnostico, e.IdCliente, e.IdSim, e.Status, e.IdConectividad, e.IdTipoResponsable })
                    .HasName("missing_index_13286_13285");

                entity.HasIndex(e => new { e.IdUnidad, e.IdProducto, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdAplicativo, e.IdNivelDiagnostico, e.IdConectividad, e.IdCliente, e.IdSim, e.Status, e.IdTipoResponsable })
                    .HasName("missing_index_118502_118501");

                entity.HasIndex(e => new { e.IdUnidad, e.IsNueva, e.IdMarca, e.IdModelo, e.NoSerie, e.NoInventario, e.NoImei, e.NoSim, e.IdResponsable, e.PosicionInventario, e.IsDaniada, e.IdStatusUnidad, e.FecAlta, e.IdAplicativo, e.IdNivelDiagnostico, e.IdConectividad, e.IdCliente, e.IdProducto, e.IdSim, e.Status, e.IdTipoResponsable })
                    .HasName("missing_index_137602_137601");

                entity.Property(e => e.Caja).IsUnicode(false);

                entity.Property(e => e.Comentarios).IsUnicode(false);

                entity.Property(e => e.FolioTelmex).IsUnicode(false);

                entity.Property(e => e.MotivoEnviadaScrap).IsUnicode(false);

                entity.Property(e => e.NoEquipo).IsUnicode(false);

                entity.Property(e => e.NoImei).IsUnicode(false);

                entity.Property(e => e.NoInventario).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.NoTarima).IsUnicode(false);

                entity.Property(e => e.OrdenCompra).IsUnicode(false);

                entity.Property(e => e.PosicionInventario).IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);

                entity.Property(e => e.VersionKernel).IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesNoReportadas>(entity =>
            {
                entity.Property(e => e.NoSerieNoReportado).IsUnicode(false);

                entity.HasOne(d => d.IdAuditoriaReporteNavigation)
                    .WithMany(p => p.BdUnidadesNoReportadas)
                    .HasForeignKey(d => d.IdAuditoriaReporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_UNIDADES_NO_REPORTADAS_BD_AUDITORIA_REPORTE");
            });

            modelBuilder.Entity<BdUnidadesPasoTest>(entity =>
            {
                entity.HasKey(e => e.IdUnidadPasoTest)
                    .HasName("PK__BD_UNIDA__33C276C900238AC8");

                entity.Property(e => e.NoSerie).IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesPorRecibirAlmacen>(entity =>
            {
                entity.HasIndex(e => new { e.NoSerie, e.IdJefeAlmacen })
                    .HasName("IX_MI_BD_UNIDADES_POR_RECIBIR_ALMACEN_7196_7195");

                entity.HasIndex(e => new { e.IdRecepcion, e.NoSerie, e.IdJefeAlmacen, e.IsProcesada })
                    .HasName("IX_BD_UNIDADES_POR_RECIBIR_ALMACEN_ID_JEFE_ALMACEN, IS_PROCESADA");

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.PosicionInventario).IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesProcesadasAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdUnidadProcesadaAlmacen)
                    .HasName("PK__BD_UNIDA__8006DB168CAAACE5");

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Success).IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesRefaccionesAlta>(entity =>
            {
                entity.HasKey(e => e.IdUnidadRefaccionAlta)
                    .HasName("PK_BD_REFACCIONES_ALTA");

                entity.Property(e => e.NoEquipo).IsUnicode(false);

                entity.Property(e => e.NoImei).IsUnicode(false);

                entity.Property(e => e.NoInventario).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.PosicionInventario).IsUnicode(false);
            });

            modelBuilder.Entity<BdUnidadesReportadas>(entity =>
            {
                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DestinoEnvio).IsUnicode(false);

                entity.Property(e => e.Guia).IsUnicode(false);

                entity.Property(e => e.NoSerieReportado).IsUnicode(false);

                entity.Property(e => e.Responsable).IsUnicode(false);

                entity.HasOne(d => d.IdAuditoriaReporteNavigation)
                    .WithMany(p => p.BdUnidadesReportadas)
                    .HasForeignKey(d => d.IdAuditoriaReporte)
                    .HasConstraintName("FK_BD_UNIDADES_REPORTADAS_BD_UNIDADES_REPORTADAS");
            });

            modelBuilder.Entity<BdUniversoSims>(entity =>
            {
                entity.HasIndex(e => e.Sim)
                    .HasName("IX_BD_UNIVERSO_SIMS");

                entity.HasIndex(e => new { e.Sim, e.EstatusGeneral })
                    .HasName("IX_BD_UNIVERSO_SIMS_2");

                entity.HasIndex(e => new { e.Sim, e.StatusCarga })
                    .HasName("IX_BD_UNIVERSO_SIMS_1");
            });

            modelBuilder.Entity<BdUploadDhl>(entity =>
            {
                entity.HasKey(e => e.IdUploadDhl)
                    .HasName("PK__BD_UPLOA__7B20E2120FAE9EDF");
            });

            modelBuilder.Entity<BdUploadEstafeta>(entity =>
            {
                entity.HasKey(e => e.IdUploadEstafeta)
                    .HasName("PK__BD_UPLOA__536D36A397F27C8A");
            });

            modelBuilder.Entity<BdUsuarioAlmacen>(entity =>
            {
                entity.HasIndex(e => e.IdAlmacen);

                entity.HasIndex(e => e.IdUsuario);
            });

            modelBuilder.Entity<BdUsuarioArchivosVarios>(entity =>
            {
                entity.Property(e => e.NombreArchivoSistema).IsUnicode(false);

                entity.Property(e => e.NombreArchivoUsuario).IsUnicode(false);

                entity.Property(e => e.Ruta).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdUsuarioCelular>(entity =>
            {
                entity.Property(e => e.Celular).IsUnicode(false);

                entity.Property(e => e.Imei).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdUsuarioCliente>(entity =>
            {
                entity.HasIndex(e => e.IdCliente);

                entity.HasIndex(e => e.IdUsuario);

                entity.HasIndex(e => new { e.IdUsuario, e.IdCliente })
                    .HasName("IX_MI_BD_USUARIO_CLIENTE_1922_1921");
            });

            modelBuilder.Entity<BdUsuarioProducto>(entity =>
            {
                entity.HasIndex(e => e.IdProducto);

                entity.HasIndex(e => e.IdUsuario);
            });

            modelBuilder.Entity<BdUsuarioStatusUnidad>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioStatusUnidad)
                    .HasName("PK__BD_USUAR__D713569DB6312571");
            });

            modelBuilder.Entity<BdUsuarioVistaEscalamiento>(entity =>
            {
                entity.HasIndex(e => e.IdUsuario);

                entity.HasIndex(e => e.IdVistaEscalamiento);

                entity.HasOne(d => d.IdVistaEscalamientoNavigation)
                    .WithMany(p => p.BdUsuarioVistaEscalamiento)
                    .HasForeignKey(d => d.IdVistaEscalamiento)
                    .HasConstraintName("FK_BD_USUARIO_VISTA_ESCALAMIENTO_C_VISTAS_ESCALAMIENTO");
            });

            modelBuilder.Entity<BdUsuarioZona>(entity =>
            {
                entity.HasIndex(e => e.IdRegion);

                entity.HasIndex(e => e.IdUsuario);

                entity.HasIndex(e => e.IdZona);

                entity.HasIndex(e => new { e.IdUsuario, e.IdZona })
                    .HasName("IX_MI_BD_USUARIO_ZONA_30337_30336");

                entity.HasIndex(e => new { e.IdUsuario, e.IdRegion, e.IdZona })
                    .HasName("IX_BD_USUARIO_ZONA_ID_REGION, ID_ZONA");
            });

            modelBuilder.Entity<BdUsuariosEnviarEmail>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioEnviarEmail)
                    .HasName("PK__BD_USUAR__637D42F614A663DC");
            });

            modelBuilder.Entity<BdUsuariosEnviorEmail2>(entity =>
            {
                entity.HasKey(e => e.IdUsuariosEnviorEmail2)
                    .HasName("PK__BD_USUAR__3C909B57279D1526");

                entity.Property(e => e.Checked).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdVacaciones>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdValMovimientosInvServicioFalla>(entity =>
            {
                entity.HasKey(e => e.IdValMovimientosInvServicioFalla)
                    .HasName("PK__BD_VAL_M__864C0184D5FD1DC1");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdVistaEscalamientoStatusAr>(entity =>
            {
                entity.HasKey(e => e.IdVistaEscalamientoStatusAr)
                    .HasName("PK_BD_VISTA_ECALAMIENTO_STATUS_AR");

                entity.HasOne(d => d.IdVistaEscalamientoNavigation)
                    .WithMany(p => p.BdVistaEscalamientoStatusAr)
                    .HasForeignKey(d => d.IdVistaEscalamiento)
                    .HasConstraintName("FK_BD_VISTA_ESCALAMIENTO_STATUS_AR_C_STATUS_AR");
            });

            modelBuilder.Entity<BdWincorClientes>(entity =>
            {
                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<BdWincorClientesServicios>(entity =>
            {
                entity.HasKey(e => e.IdClienteServicioWincor)
                    .HasName("PK_BD_WINCOR_CLIENTE_SERVICIO");
            });

            modelBuilder.Entity<BdWincorServicios>(entity =>
            {
                entity.HasKey(e => e.IdServicioWincor)
                    .HasName("PK_BD_WINCOR_PROYECTOS");

                entity.Property(e => e.Nombre).IsUnicode(false);
            });

            modelBuilder.Entity<BdWorkload>(entity =>
            {
                entity.HasIndex(e => e.FecAlta);

                entity.Property(e => e.BlkBy).IsUnicode(false);

                entity.Property(e => e.Command).IsUnicode(false);

                entity.Property(e => e.Cputime).IsUnicode(false);

                entity.Property(e => e.Dbname).IsUnicode(false);

                entity.Property(e => e.DiskIo).IsUnicode(false);

                entity.Property(e => e.HostName).IsUnicode(false);

                entity.Property(e => e.LastBatch).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.Property(e => e.ProgramName).IsUnicode(false);

                entity.Property(e => e.Requestid).IsUnicode(false);

                entity.Property(e => e.Spid).IsUnicode(false);

                entity.Property(e => e.SpidUno).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<BdWsBancomer>(entity =>
            {
                entity.HasIndex(e => e.TaskId);

                entity.HasIndex(e => new { e.IdTareaBancomer, e.TaskId, e.CreateDate, e.Summary, e.TaskType, e.TaskName, e.Priority, e.Urgency, e.BbvaCrtClaseAtm, e.BbvaCrtDireccion, e.BbvaTsitio, e.BbvaCiAutoserv, e.Importado, e.Automatico, e.BbvaCtrAutoservicio, e.Status })
                    .HasName("IX_BD_WS_BANCOMER_Status");

                entity.Property(e => e.AssigneeId).IsUnicode(false);

                entity.Property(e => e.BbvaCiAutoserv).IsUnicode(false);

                entity.Property(e => e.BbvaCrtClaseAtm).IsUnicode(false);

                entity.Property(e => e.BbvaCrtDireccion).IsUnicode(false);

                entity.Property(e => e.BbvaCtrAutoservicio).IsUnicode(false);

                entity.Property(e => e.BbvaNdc).IsUnicode(false);

                entity.Property(e => e.BbvaNoSerie).IsUnicode(false);

                entity.Property(e => e.BbvaTsitio).IsUnicode(false);

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Company).IsUnicode(false);

                entity.Property(e => e.Completion).IsUnicode(false);

                entity.Property(e => e.FecCarga).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolioResolutor).IsUnicode(false);

                entity.Property(e => e.InstancedId).IsUnicode(false);

                entity.Property(e => e.Justificacion).IsUnicode(false);

                entity.Property(e => e.LastModifiedBy).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.Priority).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Summary).IsUnicode(false);

                entity.Property(e => e.TaskId).IsUnicode(false);

                entity.Property(e => e.TaskName).IsUnicode(false);

                entity.Property(e => e.TaskNotes).IsUnicode(false);

                entity.Property(e => e.TaskType).IsUnicode(false);

                entity.Property(e => e.Urgency).IsUnicode(false);

                entity.Property(e => e.Z1DStatusReasonDisplay).IsUnicode(false);
            });

            modelBuilder.Entity<BdZonaCp>(entity =>
            {
                entity.HasIndex(e => e.Cp)
                    .HasName("IX_BD_ZONA_CP");

                entity.HasIndex(e => e.IdZona);

                entity.HasIndex(e => new { e.IdZonaCp, e.IdZona })
                    .HasName("missing_index_287418_287417");

                entity.HasIndex(e => new { e.IdZonaCp, e.Cp, e.IdZona })
                    .HasName("missing_index_287424_287423");

                entity.HasIndex(e => new { e.IdZonaCp, e.IdZona, e.Cp, e.FecAlta, e.IdUsuarioAlta })
                    .HasName("missing_index_290259_290258");
            });

            modelBuilder.Entity<CAccesorios>(entity =>
            {
                entity.Property(e => e.DescAccesorio).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CActasAdmin>(entity =>
            {
                entity.Property(e => e.DescActaAdmin).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CAlmacenes>(entity =>
            {
                entity.Property(e => e.DescAlmacen).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CArchivos>(entity =>
            {
                entity.Property(e => e.DescArchivo).IsUnicode(false);

                entity.Property(e => e.NombreArchivo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CAreas>(entity =>
            {
                entity.Property(e => e.DescArea).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CBbvaMicroformasServicios>(entity =>
            {
                entity.HasKey(e => e.IdBbva)
                    .HasName("PK__C_BBVA_M__705754273FA11A03");

                entity.Property(e => e.DesservBbva).IsUnicode(false);

                entity.Property(e => e.TipoServicio).IsUnicode(false);

                entity.Property(e => e.Vim).IsUnicode(false);
            });

            modelBuilder.Entity<CBitacoraAgendadosComentarios>(entity =>
            {
                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCalifJunta>(entity =>
            {
                entity.Property(e => e.CalifJunta).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCanales>(entity =>
            {
                entity.HasKey(e => e.IdCanal)
                    .HasName("PK__C_CANALE__6C4D2FE6A370FF03");

                entity.Property(e => e.DescCanal).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCarrier>(entity =>
            {
                entity.Property(e => e.Caracter).IsUnicode(false);

                entity.Property(e => e.DescCarrier).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__C_CATEGO__4BD51FA5239B33CE");

                entity.Property(e => e.DescCategoria).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCategoriaValidaDispositivos>(entity =>
            {
                entity.Property(e => e.DescIdentificador).IsUnicode(false);

                entity.Property(e => e.Identificador).IsUnicode(false);
            });

            modelBuilder.Entity<CCausaCancelacion>(entity =>
            {
                entity.HasKey(e => e.IdCausaCancelacion)
                    .HasName("PK__C_CAUSA___D74935B60C901E7D");

                entity.HasIndex(e => new { e.IdCliente, e.IdCausaCancelacion, e.DescCausaCancelacion, e.Status })
                    .HasName("IX_C_CAUSA_CANCELACION");

                entity.Property(e => e.DescCausaCancelacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCausaCancelacionSolicitudAlmacen>(entity =>
            {
                entity.Property(e => e.DescCausaCancelacionSolicitudAlmacen).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCausaRetiro>(entity =>
            {
                entity.HasKey(e => e.IdCausaRetiro)
                    .HasName("PK__C_CAUSA___A118E7CB20DB452D");

                entity.Property(e => e.CausaRetiro).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCausas>(entity =>
            {
                entity.HasIndex(e => new { e.IdCausa, e.IdCliente, e.Status, e.DescCausa })
                    .HasName("IX_C_CAUSAS");

                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.DescCausa).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCausasRechazo>(entity =>
            {
                entity.HasIndex(e => e.IdTrechazo)
                    .HasName("IX_C_CAUSAS_RECHAZO_1");

                entity.HasIndex(e => new { e.IdCliente, e.IdTrechazo })
                    .HasName("IX_C_CAUSAS_RECHAZO");

                entity.Property(e => e.DescCausaRechazo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusReasonCode).IsUnicode(false);
            });

            modelBuilder.Entity<CCausasRechazoDefinitivoDoctoPrefacturacion>(entity =>
            {
                entity.Property(e => e.DescCausaRechazoDefinitivoDoctoPrefacturacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CChoferes>(entity =>
            {
                entity.Property(e => e.Materno).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Paterno).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CClientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_BD_CLIENTES");

                entity.Property(e => e.CadenaWincor).IsUnicode(false);

                entity.Property(e => e.CentroCostos).IsUnicode(false);

                entity.Property(e => e.CharCodigoIntervencion).IsUnicode(false);

                entity.Property(e => e.DescCliente).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DocTir).IsUnicode(false);

                entity.Property(e => e.IdTipoCalculoUptime).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsArUpdatesNegocio).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIdReq).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLab).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNumericNoAfiliacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNumericNoAr).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPrefacturacion).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReparaciones).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReporteAr).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRetipificados).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSingleMovInv).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUnidadAtendidaRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUptime).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisitaCobrable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWincor).HasDefaultValueSql("((0))");

                entity.Property(e => e.PorRechazo).HasDefaultValueSql("((0))");

                entity.Property(e => e.PorUptime).HasDefaultValueSql("((99.7))");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoCalculoUptimeNavigation)
                    .WithMany(p => p.CClientes)
                    .HasForeignKey(d => d.IdTipoCalculoUptime)
                    .HasConstraintName("FK_C_CLIENTES_C_TIPO_CALCULO_UPTIME");
            });

            modelBuilder.Entity<CClientesPmo>(entity =>
            {
                entity.HasIndex(e => e.IdCliente)
                    .HasName("IX_C_CLIENTES_PMO")
                    .IsUnique();

                entity.HasIndex(e => e.IdProducto)
                    .HasName("IX_C_CLIENTES_PMO_2");

                entity.HasIndex(e => new { e.IdCliente, e.IdProducto })
                    .HasName("IX_C_CLIENTES_PMO_1");
            });

            modelBuilder.Entity<CCodigosIntervencionNivel0>(entity =>
            {
                entity.Property(e => e.ClaveCodigo).IsUnicode(false);

                entity.Property(e => e.DescCodigo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCodigosIntervencionNivel1>(entity =>
            {
                entity.Property(e => e.ClaveCodigo).IsUnicode(false);

                entity.Property(e => e.DescCodigo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdParentNivel0Navigation)
                    .WithMany(p => p.CCodigosIntervencionNivel1)
                    .HasForeignKey(d => d.IdParentNivel0)
                    .HasConstraintName("FK_C_CODIGOS_INTERVENCION_NIVEL1_C_CODIGOS_INTERVENCION_NIVEL0");
            });

            modelBuilder.Entity<CCodigosIntervencionNivel2>(entity =>
            {
                entity.Property(e => e.ClaveCodigo).IsUnicode(false);

                entity.Property(e => e.DescCodigo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CConceptoAr>(entity =>
            {
                entity.Property(e => e.DescripcionConceptoAr).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CConceptosPmo>(entity =>
            {
                entity.HasIndex(e => new { e.DescConcepto, e.IdTipoConcepto, e.IdAplica })
                    .HasName("IX_C_CONCEPTOS_PMO")
                    .IsUnique();
            });

            modelBuilder.Entity<CConectividad>(entity =>
            {
                entity.HasKey(e => e.IdConectividad)
                    .HasName("PK__C_CONECT__890C867F684A2BA3");

                entity.HasIndex(e => new { e.IdConectividad, e.IdCliente, e.Status, e.DescConectividad })
                    .HasName("IX_C_CONECTIVIDAD");

                entity.HasIndex(e => new { e.IdProducto, e.DescConectividad, e.IdConectividad, e.IdCliente })
                    .HasName("IX_C_CONECTIVIDAD_1");

                entity.Property(e => e.DescConectividad).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CConsumibles>(entity =>
            {
                entity.Property(e => e.DescConsumible).IsUnicode(false);

                entity.Property(e => e.Marca).IsUnicode(false);

                entity.Property(e => e.Modulo).IsUnicode(false);

                entity.Property(e => e.NoParte).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CCpDarBbva94>(entity =>
            {
                entity.HasKey(e => e.IdCp)
                    .HasName("PK__C_CP_DAR__8B622F9B96D5D183");

                entity.Property(e => e.DAsenta).IsUnicode(false);

                entity.Property(e => e.DCiudad).IsUnicode(false);

                entity.Property(e => e.DEstado).IsUnicode(false);

                entity.Property(e => e.DMunicipio).IsUnicode(false);

                entity.Property(e => e.DTipoAsenta).IsUnicode(false);

                entity.Property(e => e.DarOrigen).IsUnicode(false);

                entity.Property(e => e.Div).IsUnicode(false);

                entity.Property(e => e.Respaldo).IsUnicode(false);
            });

            modelBuilder.Entity<CDescripcionTrabajo>(entity =>
            {
                entity.Property(e => e.DescTrabajo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CDesviaciones>(entity =>
            {
                entity.HasIndex(e => new { e.IdDesviacion, e.IdCliente, e.IdResponsable, e.Status, e.IsAdministradorLogistico })
                    .HasName("IX_MI_C_DESVIACIONES_61_60");

                entity.HasIndex(e => new { e.IdDesviacion, e.IdResponsable, e.IdCliente, e.Status, e.IsAdministradorLogistico })
                    .HasName("IX_MI_C_DESVIACIONES_59_58");

                entity.Property(e => e.DescDesviacion).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CDirecciones>(entity =>
            {
                entity.Property(e => e.DescDireccion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CDocsTir>(entity =>
            {
                entity.Property(e => e.DescDoc).IsUnicode(false);

                entity.Property(e => e.DocTir).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CDominiosEmail>(entity =>
            {
                entity.Property(e => e.DescDominioEmail).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CElavonSantanderServicios>(entity =>
            {
                entity.HasKey(e => e.IdElavon)
                    .HasName("PK__C_ELAVON__5597FC3F896F8739");

                entity.Property(e => e.DescServicioElavon).IsUnicode(false);

                entity.Property(e => e.ServiciosSgs).IsUnicode(false);

                entity.Property(e => e.SubtipoServicio).IsUnicode(false);

                entity.Property(e => e.Vip).IsUnicode(false);
            });

            modelBuilder.Entity<CEquipoCliente>(entity =>
            {
                entity.Property(e => e.DescripcionEquipo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CEstadosDarBbva94>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__C_ESTADO__241E2E01900C67EE");

                entity.Property(e => e.Dar).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Proveedor).IsUnicode(false);
            });

            modelBuilder.Entity<CEtiquetaInformacionCierre>(entity =>
            {
                entity.HasKey(e => e.IdEtiquetaInformacionCierre)
                    .HasName("PK__C_ETIQUE__A8E02856BFD281CE");

                entity.Property(e => e.CampoServicio).IsUnicode(false);

                entity.Property(e => e.DescEtiquetaInformacionCierre).IsUnicode(false);

                entity.Property(e => e.Ruta).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);
            });

            modelBuilder.Entity<CEtiquetaInformacionRechazo>(entity =>
            {
                entity.HasKey(e => e.IdEtiquetaInformacionRechazo)
                    .HasName("PK__C_ETIQUE__4D80EA389BCF967B");

                entity.Property(e => e.CampoServicio).IsUnicode(false);

                entity.Property(e => e.DescEtiquetaInformacionRechazo).IsUnicode(false);

                entity.Property(e => e.Ruta).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);
            });

            modelBuilder.Entity<CEtiquetaInformacionUnidad>(entity =>
            {
                entity.Property(e => e.DescEtiquetaInformacionUnidad).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CFallas>(entity =>
            {
                entity.HasKey(e => e.IdFalla)
                    .HasName("PK_BD_FALLAS");

                entity.HasIndex(e => new { e.IdFalla, e.IdCliente, e.Status, e.DescFalla })
                    .HasName("IX_C_FALLAS");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.DescFalla).IsUnicode(false);

                entity.Property(e => e.IsDowntime).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CFallasEncontradas>(entity =>
            {
                entity.Property(e => e.DescFalla).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CGrupos>(entity =>
            {
                entity.Property(e => e.DescGrupo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CHorarios>(entity =>
            {
                entity.HasKey(e => e.IdHorario)
                    .HasName("PK_C_UPTIME");

                entity.Property(e => e.DescHorario).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CHoras>(entity =>
            {
                entity.Property(e => e.NoHora).IsUnicode(false);
            });

            modelBuilder.Entity<CInsumos>(entity =>
            {
                entity.HasKey(e => e.IdInsumo)
                    .HasName("PK_C_INSUMOS_1");

                entity.Property(e => e.DescInsumo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CInsumosAlta>(entity =>
            {
                entity.Property(e => e.DescInsumo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CInsumosOld>(entity =>
            {
                entity.HasKey(e => e.IdInsumo)
                    .HasName("PK_C_INSUMOS");

                entity.HasIndex(e => new { e.IdInsumo, e.DescInsumo, e.IdCliente, e.Status })
                    .HasName("IX_C_INSUMOS_ID_CLIENTE_STATUS");

                entity.Property(e => e.DescInsumo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoInsumoNavigation)
                    .WithMany(p => p.CInsumosOld)
                    .HasForeignKey(d => d.IdTipoInsumo)
                    .HasConstraintName("FK_C_INSUMOS_C_TIPO_INSUMO");
            });

            modelBuilder.Entity<CLlaves>(entity =>
            {
                entity.HasKey(e => e.IdLlave)
                    .HasName("PK_BD_LLAVES");

                entity.Property(e => e.DescLlave).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CLogros>(entity =>
            {
                entity.Property(e => e.DescLogro).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CMarcas>(entity =>
            {
                entity.Property(e => e.DescMarca).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.CMarcas)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_C_MARCAS_C_PRODUCTOS");
            });

            modelBuilder.Entity<CMcAutomoviles>(entity =>
            {
                entity.HasKey(e => e.IdAutomovil)
                    .HasName("PK_BD_MC_AUTOMOVILES");

                entity.Property(e => e.DescMarca).IsUnicode(false);

                entity.Property(e => e.DescModelo).IsUnicode(false);

                entity.Property(e => e.Estatus).IsUnicode(false);

                entity.Property(e => e.Niv).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);
            });

            modelBuilder.Entity<CMcBoletos>(entity =>
            {
                entity.HasKey(e => e.IdBoleto)
                    .HasName("PK_BD_MC_BOLETOS");

                entity.Property(e => e.DescNombre).IsUnicode(false);

                entity.Property(e => e.Estatus).IsUnicode(false);
            });

            modelBuilder.Entity<CMcCasetas>(entity =>
            {
                entity.HasKey(e => e.IdCaseta)
                    .HasName("PK_BD_MC_CASETAS");

                entity.Property(e => e.DescCaseta).IsUnicode(false);

                entity.Property(e => e.Estatus).IsUnicode(false);
            });

            modelBuilder.Entity<CMcEstacionEvaluar>(entity =>
            {
                entity.HasKey(e => e.IdEstacionEvaluar)
                    .HasName("PK__C_MC_EST__F5C80A3C6FBA24D6");

                entity.Property(e => e.DescripcionEstacion).IsUnicode(false);
            });

            modelBuilder.Entity<CMcEstacionEvaluarReglas>(entity =>
            {
                entity.HasKey(e => e.IdEstacionEvaluarReglas)
                    .HasName("PK__C_MC_EST__0BA40FA67B2BD782");

                entity.Property(e => e.DescripcionEstacionReglas).IsUnicode(false);

                entity.Property(e => e.Regla).IsUnicode(false);
            });

            modelBuilder.Entity<CMcMedioTransporte>(entity =>
            {
                entity.HasKey(e => e.IdMedioTransporte)
                    .HasName("PK_BD_MC_MEDIO_TRANSPORTE");

                entity.Property(e => e.DescNombre).IsUnicode(false);

                entity.Property(e => e.Estatus).IsUnicode(false);
            });

            modelBuilder.Entity<CMcRutas>(entity =>
            {
                entity.HasKey(e => e.IdRuta)
                    .HasName("PK_BD_MC_RUTAS");

                entity.Property(e => e.DescNombre).IsUnicode(false);

                entity.Property(e => e.EstadoDestino).IsUnicode(false);

                entity.Property(e => e.EstadoOrigen).IsUnicode(false);

                entity.Property(e => e.PoblacionDestino).IsUnicode(false);

                entity.Property(e => e.PoblacionOrigen).IsUnicode(false);
            });

            modelBuilder.Entity<CMcTopesMaximos>(entity =>
            {
                entity.Property(e => e.Estatus).IsUnicode(false);
            });

            modelBuilder.Entity<CMcViaticosMotivos>(entity =>
            {
                entity.HasKey(e => e.IdMotivo)
                    .HasName("PK__C_MC_VIA__007C6C354A3E8764");

                entity.Property(e => e.Motivo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CMcViaticosRazonesCancelacion>(entity =>
            {
                entity.HasKey(e => e.IdRazon)
                    .HasName("PK__C_MC_VIA__E5BA9BD16B156B4A");

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CMenu>(entity =>
            {
                entity.Property(e => e.Href).IsUnicode(false);

                entity.Property(e => e.HrefV3).IsUnicode(false);

                entity.Property(e => e.TargetV3).IsUnicode(false);
            });

            modelBuilder.Entity<CMenuCopia>(entity =>
            {
                entity.Property(e => e.IdMenu).ValueGeneratedNever();

                entity.Property(e => e.Href).IsUnicode(false);

                entity.Property(e => e.HrefV3).IsUnicode(false);

                entity.Property(e => e.TargetV3).IsUnicode(false);
            });

            modelBuilder.Entity<CMinutos>(entity =>
            {
                entity.Property(e => e.NoMinuto).IsUnicode(false);
            });

            modelBuilder.Entity<CModelos>(entity =>
            {
                entity.HasIndex(e => new { e.IdMarca, e.Status })
                    .HasName("IX_MI_C_MODELOS_35_34");

                entity.HasIndex(e => new { e.IdModelo, e.Status })
                    .HasName("IX_MI_C_MODELOS_118_117");

                entity.HasIndex(e => new { e.IdModelo, e.IdMarca, e.Status })
                    .HasName("IX_MI_C_MODELOS_124_123");

                entity.HasIndex(e => new { e.IdModelo, e.Status, e.IdMarca })
                    .HasName("IX_MI_C_MODELOS_261_260");

                entity.HasIndex(e => new { e.Sku, e.IdModelo, e.Status })
                    .HasName("IX_C_MODELOS")
                    .IsUnique();

                entity.HasIndex(e => new { e.IdModelo, e.DescModelo, e.IdMarca, e.Status })
                    .HasName("IX_MI_C_MODELOS_53_52");

                entity.HasIndex(e => new { e.IdModelo, e.DescModelo, e.Status, e.Sku })
                    .HasName("IX_MI_C_MODELOS_171_170");

                entity.Property(e => e.DescModelo).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.DeviceType).IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory).IsUnicode(false);

                entity.Property(e => e.Sku).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdMonedaCostoNavigation)
                    .WithMany(p => p.CModelos)
                    .HasForeignKey(d => d.IdMonedaCosto)
                    .HasConstraintName("FK_C_MODELOS_C_MONEDAS");
            });

            modelBuilder.Entity<CMonedas>(entity =>
            {
                entity.Property(e => e.DescMoneda).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CMovInv>(entity =>
            {
                entity.Property(e => e.Corto).IsUnicode(false);

                entity.Property(e => e.DescMovInv).IsUnicode(false);

                entity.Property(e => e.Href).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CMovimientosInv>(entity =>
            {
                entity.HasKey(e => e.IdMovInventario)
                    .HasName("PK__C_MOVIMI__2898EE8B37C8C352");

                entity.Property(e => e.DescMovInventario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CNivelReparacion>(entity =>
            {
                entity.HasIndex(e => e.IdNivelReparacion)
                    .HasName("IX_C_NIVEL_REPARACION")
                    .IsUnique();

                entity.Property(e => e.DescNivelReparacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CNombreCurso>(entity =>
            {
                entity.HasKey(e => e.IdNombreCurso)
                    .HasName("PK_C_CURSO");

                entity.Property(e => e.NombreCurso).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CNombreJunta>(entity =>
            {
                entity.Property(e => e.NombreJunta).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CNotificacionesEmail>(entity =>
            {
                entity.HasKey(e => e.IdNotificacionesEmail)
                    .HasName("PK__C_NOTIFI__049DF4E05339656F");

                entity.Property(e => e.DescNotificacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Valor).IsUnicode(false);
            });

            modelBuilder.Entity<COperadores>(entity =>
            {
                entity.Property(e => e.DescOperador).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CPlazas>(entity =>
            {
                entity.Property(e => e.DescPlaza).IsUnicode(false);

                entity.HasOne(d => d.IdTipoPlazaNavigation)
                    .WithMany(p => p.CPlazas)
                    .HasForeignKey(d => d.IdTipoPlaza)
                    .HasConstraintName("FK_C_PLAZAS_C_TIPO_PLAZA");
            });

            modelBuilder.Entity<CPrioridades>(entity =>
            {
                entity.Property(e => e.DescPrioridades).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CProductoDhl>(entity =>
            {
                entity.HasKey(e => e.IdProductoDhl)
                    .HasName("PK__c_producto_dhl__7D102741");

                entity.Property(e => e.IdProductoDhl).ValueGeneratedNever();

                entity.Property(e => e.DescProductoDhl).IsUnicode(false);

                entity.Property(e => e.NomProductoDhl).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CProductos>(entity =>
            {
                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.ClassEdit).IsUnicode(false);

                entity.Property(e => e.DescProducto).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Image).IsUnicode(false);

                entity.Property(e => e.ImageEdit).IsUnicode(false);

                entity.Property(e => e.ImageInactive).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.CProductos)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .HasConstraintName("FK_C_PRODUCTOS_C_TIPO_PRODUCTO");
            });

            modelBuilder.Entity<CProductosNegocios>(entity =>
            {
                entity.HasKey(e => e.IdProductoNegocio)
                    .HasName("PK__C_PRODUC__14F134FAE99D68E4");

                entity.HasIndex(e => new { e.IdProductoNegocio, e.Status })
                    .HasName("IX_C_PRODUCTOS_NEGOCIOS");

                entity.Property(e => e.DescProductoNegocio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CProveedoresUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdProveedorUsuario)
                    .HasName("PK__C_PROVEE__EBE413EEBA61EF7D");

                entity.HasIndex(e => new { e.IdProveedorUsuario, e.DescProveedorUsuario })
                    .HasName("IX_C_PROVEEDORES_USUARIOS");

                entity.Property(e => e.DescProveedorUsuario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CProyectos>(entity =>
            {
                entity.HasKey(e => e.IdProyecto)
                    .HasName("PK_BD_PROYECTOS");

                entity.Property(e => e.DescProyecto).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CProyectosPmo>(entity =>
            {
                entity.HasIndex(e => new { e.IdCliente, e.IdUsuario })
                    .HasName("IX_C_PROYECTOS_PMO")
                    .IsUnique();
            });

            modelBuilder.Entity<CPuestos>(entity =>
            {
                entity.Property(e => e.DescPuesto).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CRazonDevolucion>(entity =>
            {
                entity.Property(e => e.DescRazonDevolucion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CRegiones>(entity =>
            {
                entity.HasKey(e => e.IdRegion)
                    .HasName("PK_C_ZONAS");

                entity.HasIndex(e => new { e.IdRegion, e.Status, e.DescRegion })
                    .HasName("IX_C_REGIONES");

                entity.Property(e => e.Color).IsUnicode(false);

                entity.Property(e => e.DescRegion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CReparaciones>(entity =>
            {
                entity.Property(e => e.DescReparacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CReportesRetipificados>(entity =>
            {
                entity.Property(e => e.DescReporteRetipificados).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CResponsables>(entity =>
            {
                entity.HasKey(e => e.IdResponsables)
                    .HasName("PK_C_RESPONSABLES_1");

                entity.Property(e => e.DescResponsable).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CResponsablesAgendados>(entity =>
            {
                entity.HasKey(e => e.IdResponsableAgendado)
                    .HasName("PK_C_RESPONSABLES");

                entity.Property(e => e.DescResponsableAgendado).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CSedeCurso>(entity =>
            {
                entity.Property(e => e.SedeCurso).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CSegmentos>(entity =>
            {
                entity.HasIndex(e => new { e.IdSegmento, e.Status, e.DescSegmento })
                    .HasName("IX_C_SEGMENTOS");

                entity.Property(e => e.DescSegmento).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CServicioMensajeria>(entity =>
            {
                entity.Property(e => e.DescServicioMensajeria).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.PaginaWeb).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CServicios>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PK_BD_SERVICIOS");

                entity.HasIndex(e => new { e.IdCliente, e.Status })
                    .HasName("IX_MI_C_SERVICIOS_124_123");

                entity.HasIndex(e => new { e.IdServicio, e.Status })
                    .HasName("IX_MI_C_SERVICIOS_2_1");

                entity.HasIndex(e => new { e.IdServicio, e.DescServicio, e.Status })
                    .HasName("IX_MI_C_SERVICIOS_88_87");

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.DescServicio).IsUnicode(false);

                entity.Property(e => e.IdCategoriaValidaDispositivos).IsUnicode(false);

                entity.Property(e => e.IsCausaSolucionRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCierrePda).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDowntime).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFallaEncontradaRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecFinIngenieroRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecIniIngenieroRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecLlegadaRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFecLlegadaTercerosRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFolioServicioRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIdModeloRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsInsumosRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIntensidadSenialRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIsBoletinRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIsSimRemplazadaRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIsSoporteClienteRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMotivoCobroRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNoEquipoRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNoInventarioRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNoSerieRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteSoporteClienteRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteTasRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboClienteRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboRechazoRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtorganteVoboTercerosRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrefacturacionAgendado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrefacturacionIsCobrable).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrefacturacionIsRetipificado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTasRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequestType).IsUnicode(false);

                entity.Property(e => e.RequisitosServicio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.CServicios)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK_C_SERVICIOS_C_MONEDAS");

                entity.HasOne(d => d.IdTipoPrecioNavigation)
                    .WithMany(p => p.CServicios)
                    .HasForeignKey(d => d.IdTipoPrecio)
                    .HasConstraintName("FK_C_SERVICIOS_C_TIPO_PRECIO");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.CServicios)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BD_SERVICIOS_C_TIPO_SERVICIO");
            });

            modelBuilder.Entity<CServiciosBancomer>(entity =>
            {
                entity.HasKey(e => new { e.IdServicio, e.Mov });
            });

            modelBuilder.Entity<CServiciosDobles>(entity =>
            {
                entity.HasKey(e => e.IdServicioDoble)
                    .HasName("PK__C_SERVIC__7E4206DD08E3A941");
            });

            modelBuilder.Entity<CSoftware>(entity =>
            {
                entity.HasKey(e => e.IdSoftware)
                    .HasName("PK_BD_SOFTWARE");

                entity.Property(e => e.DescSoftware).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CSoluciones>(entity =>
            {
                entity.Property(e => e.Clave).IsUnicode(false);

                entity.Property(e => e.DescSolucion).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CSpareParts>(entity =>
            {
                entity.Property(e => e.DescSparePart).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Sku).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoSparePartNavigation)
                    .WithMany(p => p.CSpareParts)
                    .HasForeignKey(d => d.IdTipoSparePart)
                    .HasConstraintName("FK_C_SPARE_PARTS_C_TIPO_SPARE_PART");
            });

            modelBuilder.Entity<CStatusAccesorio>(entity =>
            {
                entity.Property(e => e.DescStatusAccesorio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusAr>(entity =>
            {
                entity.HasIndex(e => e.DescStatusAr)
                    .HasName("IX_C_STATUS_AR");

                entity.HasIndex(e => new { e.IdStatusAr, e.DescStatusAr })
                    .HasName("IX_C_STATUS_AR_1");

                entity.HasIndex(e => new { e.IdStatusAr, e.Status, e.DescStatusAr })
                    .HasName("IX_C_STATUS_AR_2");

                entity.Property(e => e.DescStatusAr).IsUnicode(false);

                entity.Property(e => e.RequestStatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdTipoDowntimeTriggerNavigation)
                    .WithMany(p => p.CStatusAr)
                    .HasForeignKey(d => d.IdTipoDowntimeTrigger)
                    .HasConstraintName("FK_C_STATUS_AR_C_TIPO_DOWNTIME_TRIGGER");
            });

            modelBuilder.Entity<CStatusArEq>(entity =>
            {
                entity.Property(e => e.DescStatusArEq).IsUnicode(false);

                entity.HasOne(d => d.IdStatusArNavigation)
                    .WithMany(p => p.CStatusArEq)
                    .HasForeignKey(d => d.IdStatusAr)
                    .HasConstraintName("FK_C_STATUS_AR_EQ_C_STATUS_AR");
            });

            modelBuilder.Entity<CStatusCarga>(entity =>
            {
                entity.HasKey(e => e.IdStatusCarga)
                    .HasName("PK_C_STATUS_ARCHIVO");

                entity.Property(e => e.DescStatusCarga).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusCurso>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusCurso).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusDoctosPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdStatusDoctoPrefacturacion)
                    .HasName("PK_C_STATUS_DOCTOS_PREFACTURACION_OLD2");

                entity.Property(e => e.DescStatusDoctoPrefacturacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusEnvio>(entity =>
            {
                entity.Property(e => e.DescStatusEnvio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusInsumos>(entity =>
            {
                entity.Property(e => e.DescStatusInsumo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusItemsSolicitudAlmacen>(entity =>
            {
                entity.HasKey(e => e.IdStatusItemsSolicitudAlmacen)
                    .HasName("PK_C_STATUS_ITEM_SOLICITUD_ALMACEN");

                entity.Property(e => e.DescStatusItemsSolicitudAlmacen).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusJunta>(entity =>
            {
                entity.Property(e => e.ColorRgb).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusJunta).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdStatusOrdenCompra)
                    .HasName("PK__C_STATUS__72B86E1FAA32BA12");

                entity.Property(e => e.DescStatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusReasonCodes>(entity =>
            {
                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusElavon).IsUnicode(false);

                entity.Property(e => e.StatusReason).IsUnicode(false);

                entity.Property(e => e.StatusReasonCode).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusReparacion>(entity =>
            {
                entity.Property(e => e.DescStatusReparacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusReporteCierre>(entity =>
            {
                entity.Property(e => e.DescStatusReporteCierre).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudAlmacen>(entity =>
            {
                entity.Property(e => e.DescStatusSolicitudAlmacen).IsUnicode(false);

                entity.Property(e => e.IsFlujoAlmacen).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudDevolucion>(entity =>
            {
                entity.Property(e => e.DescStatusSolicitudDevolucion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudRecoleccion>(entity =>
            {
                entity.Property(e => e.DescStatusSolicitudRecoleccion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusSolicitudViaticos>(entity =>
            {
                entity.Property(e => e.DescStatusSolicitudViaticos).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusUnidad>(entity =>
            {
                entity.Property(e => e.AssignmentNo).IsUnicode(false);

                entity.Property(e => e.AssignmentNoDanada).IsUnicode(false);

                entity.Property(e => e.DescStatusUnidad).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusUsuario>(entity =>
            {
                entity.Property(e => e.DescStatusUsuario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CStatusValidacionPrefacturacion>(entity =>
            {
                entity.Property(e => e.DescStatusValidacionPrefacturacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CSubAlmacenes>(entity =>
            {
                entity.HasKey(e => e.IdCSubAlmacenes)
                    .HasName("PK__C_SUB_AL__10991DCE9D2AC00E");

                entity.Property(e => e.DescSubAlmacen).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdParentAlmacenNavigation)
                    .WithMany(p => p.CSubAlmacenes)
                    .HasForeignKey(d => d.IdParentAlmacen)
                    .HasConstraintName("FK__C_SUB_ALM__ID_PA__29B0ECBB");
            });

            modelBuilder.Entity<CSubrechazo>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_C_SUBRECHAZO");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Subrechazo).IsUnicode(false);
            });

            modelBuilder.Entity<CTecnicos>(entity =>
            {
                entity.Property(e => e.Materno).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Paterno).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTiempoMedicion>(entity =>
            {
                entity.Property(e => e.DescTiempoMedicion).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTiempoReferencia>(entity =>
            {
                entity.Property(e => e.DescTiempoReferencia).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTiempos>(entity =>
            {
                entity.Property(e => e.Descripcion).IsUnicode(false);
            });

            modelBuilder.Entity<CTimestamp>(entity =>
            {
                entity.Property(e => e.DescTimestamp).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Timestamp).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoAB>(entity =>
            {
                entity.HasKey(e => e.IdTipoAB)
                    .HasName("PK__C_TIPO_A__4B00D75F71A1E58A");

                entity.Property(e => e.DescTipoAB).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoArchivo>(entity =>
            {
                entity.Property(e => e.DescTipoArchivo).IsUnicode(false);

                entity.Property(e => e.Imagen).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoAuditoria>(entity =>
            {
                entity.Property(e => e.DescTipoAuditoria).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoCalculoUptime>(entity =>
            {
                entity.HasKey(e => e.IdTipoCalculoUptime)
                    .HasName("PK_C_TIPO_CALCULO_DOWNTME");

                entity.Property(e => e.DescTipoCalculoUptime).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoCobro>(entity =>
            {
                entity.Property(e => e.DescTipoCobro).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoCobroNegocio>(entity =>
            {
                entity.Property(e => e.DescTipoCobroNegocio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoDowntimeTrigger>(entity =>
            {
                entity.Property(e => e.DescTipoDowntimeTrigger).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoFalla>(entity =>
            {
                entity.Property(e => e.DescTipoFalla).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoInsumo>(entity =>
            {
                entity.Property(e => e.DescTipoInsumo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoInventario>(entity =>
            {
                entity.Property(e => e.DescTipoInventario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoItemOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdTipoItemOrdenCompra)
                    .HasName("PK__C_TIPO_I__EB726181FB5A492B");

                entity.Property(e => e.DescTipoItemOrdenCompra).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoItemSolicitudAlmacen>(entity =>
            {
                entity.Property(e => e.DescTipoItemSolicitudAlmacen).IsUnicode(false);

                entity.Property(e => e.IsUnidadGrupoClientes).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoLocalidad>(entity =>
            {
                entity.HasKey(e => e.IdTipoLocalidad)
                    .HasName("PK_C_LOCALIDAD");

                entity.Property(e => e.DescLocalidad).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPart>(entity =>
            {
                entity.Property(e => e.DescTipoPart).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPlaza>(entity =>
            {
                entity.Property(e => e.DescTipoPlaza).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPlazaCliente>(entity =>
            {
                entity.Property(e => e.DescTipoPlazaCliente).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPlazaNegocio>(entity =>
            {
                entity.Property(e => e.DescTipoPlazaNegocio).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoPrecio>(entity =>
            {
                entity.Property(e => e.DescTipoPrecio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoProducto>(entity =>
            {
                entity.Property(e => e.DescTipoProducto).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoResponsable>(entity =>
            {
                entity.HasKey(e => e.IdTipoResponsable)
                    .HasName("PK_C_TIPO_RESP");

                entity.Property(e => e.DescTipoResponsable).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoResponsablePrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoResponsablePrefacturacion)
                    .HasName("PK_C_RESPONSABLES_PREFACTURACION");

                entity.Property(e => e.DescTipoResponsablePrefacturacion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoServicio>(entity =>
            {
                entity.Property(e => e.DescTipoServicio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoServicioSolicitudAlmacen>(entity =>
            {
                entity.Property(e => e.DescTipoServicioSolicitudAlmacen).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoSolicitudAlmacen>(entity =>
            {
                entity.Property(e => e.DescTipoSolicitudAlmacen).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoSoporteTecnico>(entity =>
            {
                entity.Property(e => e.DescTipoSoporteTecnico).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoSparePart>(entity =>
            {
                entity.Property(e => e.DescTipoSparePart).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoUsuario>(entity =>
            {
                entity.HasIndex(e => e.DescTipoUsuario)
                    .HasName("IX_C_TIPO_USUARIO");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_C_TIPO_USUARIO_1");

                entity.Property(e => e.DescTipoUsuario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CTipoZonaOld>(entity =>
            {
                entity.HasKey(e => e.IdTipoZona)
                    .HasName("PK_C_TIPO_ZONA");

                entity.Property(e => e.DescTipoZona).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CUnidadMensajeria>(entity =>
            {
                entity.Property(e => e.DescUnidadMensajeria).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CUpdateTablasBb>(entity =>
            {
                entity.Property(e => e.DescTablaUpdate).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TablaUpdate).IsUnicode(false);
            });

            modelBuilder.Entity<CUrgenciaEnvio>(entity =>
            {
                entity.Property(e => e.DescUrgenciaEnvio).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CUrgenciaSolicitudAlmacen>(entity =>
            {
                entity.Property(e => e.DescUrgenciaSolicitudAlmacen).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CUsuarios>(entity =>
            {
                entity.HasIndex(e => e.Credencial)
                    .HasName("IX_MI_C_USUARIOS_3464_3463");

                entity.HasIndex(e => e.IdProveedor)
                    .HasName("IX_C_USUARIOS");

                entity.HasIndex(e => e.Nombre)
                    .HasName("IX_MI_C_USUARIOS_15_14");

                entity.HasIndex(e => e.Username)
                    .HasName("IX_MI_C_USUARIOS_46_45");

                entity.HasIndex(e => new { e.IdUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_28400_28399");

                entity.HasIndex(e => new { e.IdZona, e.Status })
                    .HasName("IX_MI_C_USUARIOS_10616_10615");

                entity.HasIndex(e => new { e.Username, e.Status })
                    .HasName("IX_MI_C_USUARIOS_75_74");

                entity.HasIndex(e => new { e.IdTipoUsuario, e.FecAccesoPda, e.IsPda })
                    .HasName("IX_MI_C_USUARIOS_2_1");

                entity.HasIndex(e => new { e.IdTipoUsuario, e.Status, e.IdProveedor })
                    .HasName("missing_index_4579_4578");

                entity.HasIndex(e => new { e.IdUsuario, e.Email, e.Status })
                    .HasName("IX_MI_C_USUARIOS_57_56");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_83_82");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Status })
                    .HasName("IX_MI_C_USUARIOS_5108_5107");

                entity.HasIndex(e => new { e.IdZona, e.Status, e.IdPuesto })
                    .HasName("IX_MI_C_USUARIOS_10677_10676");

                entity.HasIndex(e => new { e.Nombre, e.Paterno, e.Materno })
                    .HasName("IX_C_USUARIOS_1");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Email, e.Status })
                    .HasName("IX_MI_C_USUARIOS_1924_1923");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Status })
                    .HasName("IX_MI_C_USUARIOS_12087_12086");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.IdProveedor, e.Status })
                    .HasName("missing_index_4570393_4570392");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.IdTipoUsuario, e.Status })
                    .HasName("missing_index_4509886_4509885");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.IdTipoUsuario })
                    .HasName("IX_C_USUARIOS_ID_TIPO_USUARIO");

                entity.HasIndex(e => new { e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.Status, e.IdUsuario })
                    .HasName("IX_MI_C_USUARIOS_8782_8781");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.Status })
                    .HasName("IX_MI_C_USUARIOS_5114_5113");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_634_633");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.FecAccesoPda, e.IsPda })
                    .HasName("IX_MI_C_USUARIOS_12072_12071");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.IdZona, e.Status })
                    .HasName("IX_MI_C_USUARIOS_10556_10555");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.IdTipoUsuario, e.Status, e.IdProveedor })
                    .HasName("missing_index_4281247_4281246");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.IdTipoUsuario, e.Status, e.IsFollowerDispatch })
                    .HasName("IX_C_USUARIOS_ID_TIPO_USUARIO, STATUS, IS_FOLLOWER_DISPATCH");

                entity.HasIndex(e => new { e.Nombre, e.Paterno, e.Materno, e.Username, e.Email, e.Curp, e.Status })
                    .HasName("IX_MI_C_USUARIOS_8109_8108");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.IdZona, e.Status, e.IdPuesto })
                    .HasName("IX_MI_C_USUARIOS_25194_25193");

                entity.HasIndex(e => new { e.Nombre, e.Paterno, e.Materno, e.Username, e.Email, e.Curp, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_153999_153998");

                entity.HasIndex(e => new { e.Nombre, e.Paterno, e.Materno, e.Username, e.Email, e.Curp, e.IdTipoUsuario, e.Status, e.IdProveedor })
                    .HasName("missing_index_1881420_1881419");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.IsAutorizaVacaciones, e.DiasVacaciones, e.IsElavon, e.FecReingreso, e.IdArea, e.IdHorario, e.HrefFoto, e.Frase, e.IsEligeVacaciones, e.Celular, e.IdPuesto, e.FecIngreso, e.IdEdoNac, e.FecNac, e.FecBaja, e.Credencial, e.IsFollowerDispatch, e.IsDispatchProgramados, e.TelefonoOficina, e.TelefonoOficinaExt, e.TelefonoCasa, e.IdZona, e.IdUsuarioAlta, e.FecAlta, e.IdUsuarioStatus, e.FecStatus, e.FecExp, e.NoTelNextel, e.IdAlmacenOld, e.IsPda, e.FecAccesoPda, e.Curp, e.IdJefe, e.Username, e.Password, e.Email, e.Sexo, e.Telefono, e.NoIdNextel, e.IdTipoUsuario, e.Status })
                    .HasName("IX_MI_C_USUARIOS_154001_154000");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.Username, e.Password, e.Email, e.Sexo, e.Telefono, e.NoIdNextel, e.NoTelNextel, e.IdAlmacenOld, e.IsPda, e.FecAccesoPda, e.Curp, e.IdJefe, e.IdZona, e.IdUsuarioAlta, e.FecAlta, e.IdUsuarioStatus, e.FecStatus, e.FecExp, e.Credencial, e.IsFollowerDispatch, e.IsDispatchProgramados, e.TelefonoOficina, e.TelefonoOficinaExt, e.TelefonoCasa, e.Celular, e.IdPuesto, e.FecIngreso, e.IdEdoNac, e.FecNac, e.FecBaja, e.FecReingreso, e.IdArea, e.IdHorario, e.HrefFoto, e.Frase, e.IsEligeVacaciones, e.IsAutorizaVacaciones, e.DiasVacaciones, e.IsElavon, e.IsFecGarantiaChange, e.IsAllCliente, e.IdDirecciones, e.IsReporteDesviacion, e.IsEditaNegocios, e.IsExlsNegocios, e.IsAltaMasivaViaticos, e.IsEditarEspecificacionesServicio, e.IsDaniadaUsuario, e.IsConsultaUnidad, e.ExcelUltimoMov, e.ModificaMUnidad, e.IsRedireccionEnvio, e.IsAltaMasivaNegocios, e.IsCache, e.IsActualizacionMasivaCoordenadasNegocio, e.IsEditarAlmacen, e.IsReabrirAuditoria, e.IsModifiedAr, e.IsEmailServiceCharge, e.ExcelUsuarioCierre, e.IsStolenUnit, e.IsDeleteDrive, e.EmailServiceClose, e.IsStatusCambioAbiertas, e.ComentariosOki, e.IsPadronIngenieros, e.IsModificaMensajeria, e.IsModCUsuarios, e.IsAddReplicate, e.IsRecoverPassword, e.IsUpdatePosicionInventario, e.IsReporteLicenciasDhl, e.IdDatosFiscales, e.IsAdiministrarUsuarios, e.IsCallCenterContacto, e.IdTipoUsuario, e.IdProveedor, e.Status })
                    .HasName("missing_index_11962_11961");

                entity.HasIndex(e => new { e.IdUsuario, e.IdTipoUsuario, e.Nombre, e.Paterno, e.Materno, e.Username, e.Password, e.Email, e.Sexo, e.Telefono, e.NoIdNextel, e.NoTelNextel, e.IdAlmacenOld, e.IsPda, e.FecAccesoPda, e.Curp, e.IdJefe, e.IdZona, e.IdUsuarioAlta, e.FecAlta, e.IdUsuarioStatus, e.FecStatus, e.FecExp, e.Credencial, e.IsFollowerDispatch, e.IsDispatchProgramados, e.TelefonoOficina, e.TelefonoOficinaExt, e.TelefonoCasa, e.Celular, e.IdPuesto, e.FecIngreso, e.IdEdoNac, e.FecNac, e.FecBaja, e.FecReingreso, e.IdArea, e.IdHorario, e.HrefFoto, e.Frase, e.IsEligeVacaciones, e.IsAutorizaVacaciones, e.DiasVacaciones, e.IsElavon, e.IsFecGarantiaChange, e.IsAllCliente, e.IdDirecciones, e.IsReporteDesviacion, e.IsEditaNegocios, e.IsExlsNegocios, e.IsAltaMasivaViaticos, e.IsEditarEspecificacionesServicio, e.IsDaniadaUsuario, e.IsConsultaUnidad, e.ExcelUltimoMov, e.ModificaMUnidad, e.IsRedireccionEnvio, e.IsAltaMasivaNegocios, e.IdProveedor, e.IsCache, e.IsActualizacionMasivaCoordenadasNegocio, e.IsEditarAlmacen, e.IsReabrirAuditoria, e.IsModifiedAr, e.IsEmailServiceCharge, e.ExcelUsuarioCierre, e.IsStolenUnit, e.IsDeleteDrive, e.EmailServiceClose, e.IsStatusCambioAbiertas, e.ComentariosOki, e.IsPadronIngenieros, e.IsModificaMensajeria, e.IsModCUsuarios, e.IsAddReplicate, e.IsRecoverPassword, e.IsUpdatePosicionInventario, e.IsReporteLicenciasDhl, e.IdDatosFiscales, e.IsAdiministrarUsuarios, e.IsCallCenterContacto, e.IsCambioStatusUnidadReglaDisponibleUsado, e.Status })
                    .HasName("missing_index_3576836_3576835");

                entity.HasIndex(e => new { e.IdUsuario, e.Nombre, e.Paterno, e.Materno, e.Username, e.Password, e.Email, e.Sexo, e.Telefono, e.NoIdNextel, e.NoTelNextel, e.IdAlmacenOld, e.IsPda, e.FecAccesoPda, e.Curp, e.IdJefe, e.IdZona, e.IdUsuarioAlta, e.FecAlta, e.IdUsuarioStatus, e.FecStatus, e.FecExp, e.Credencial, e.IsFollowerDispatch, e.IsDispatchProgramados, e.TelefonoOficina, e.TelefonoOficinaExt, e.TelefonoCasa, e.Celular, e.IdPuesto, e.FecIngreso, e.IdEdoNac, e.FecNac, e.FecBaja, e.FecReingreso, e.IdArea, e.IdHorario, e.HrefFoto, e.Frase, e.IsEligeVacaciones, e.IsAutorizaVacaciones, e.DiasVacaciones, e.IsElavon, e.IsFecGarantiaChange, e.IsAllCliente, e.IdDirecciones, e.IsReporteDesviacion, e.IsEditaNegocios, e.IsExlsNegocios, e.IsAltaMasivaViaticos, e.IsEditarEspecificacionesServicio, e.IsDaniadaUsuario, e.IsConsultaUnidad, e.ExcelUltimoMov, e.ModificaMUnidad, e.IsRedireccionEnvio, e.IsAltaMasivaNegocios, e.IdProveedor, e.IsCache, e.IsActualizacionMasivaCoordenadasNegocio, e.IsEditarAlmacen, e.IsReabrirAuditoria, e.IsModifiedAr, e.IsEmailServiceCharge, e.ExcelUsuarioCierre, e.IsStolenUnit, e.IsDeleteDrive, e.EmailServiceClose, e.IsStatusCambioAbiertas, e.ComentariosOki, e.IsPadronIngenieros, e.IsModificaMensajeria, e.IsModCUsuarios, e.IsAddReplicate, e.IsRecoverPassword, e.IsUpdatePosicionInventario, e.IsReporteLicenciasDhl, e.IdDatosFiscales, e.IsAdiministrarUsuarios, e.IsCallCenterContacto, e.IsCambioStatusUnidadReglaDisponibleUsado, e.IdTipoUsuario, e.Status })
                    .HasName("missing_index_4443916_4443915");

                entity.Property(e => e.Celular).IsUnicode(false);

                entity.Property(e => e.Credencial).IsUnicode(false);

                entity.Property(e => e.Curp).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Frase).IsUnicode(false);

                entity.Property(e => e.HrefFoto).IsUnicode(false);

                entity.Property(e => e.Materno).IsUnicode(false);

                entity.Property(e => e.NoIdNextel).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Paterno).IsUnicode(false);

                entity.Property(e => e.Sexo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.TelefonoCasa).IsUnicode(false);

                entity.Property(e => e.TelefonoOficina).IsUnicode(false);

                entity.Property(e => e.TelefonoOficinaExt).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.CUsuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK_C_USUARIOS_C_TIPO_USUARIO");
            });

            modelBuilder.Entity<CUsuariosCorporativo>(entity =>
            {
                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_C_USUARIOS_CORPORATIVO");
            });

            modelBuilder.Entity<CVendedores>(entity =>
            {
                entity.HasKey(e => e.IdVendedor)
                    .HasName("PK__C_VENDED__4E11DBE6D6FA9F54");

                entity.Property(e => e.Ciudad).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.DescVendedor).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Rfc).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CViaticos>(entity =>
            {
                entity.Property(e => e.DescViatico).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CVistasEscalamiento>(entity =>
            {
                entity.Property(e => e.DescVistaEscalamiento).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CWeekDays>(entity =>
            {
                entity.Property(e => e.WeekDay).IsUnicode(false);
            });

            modelBuilder.Entity<CWeekhours>(entity =>
            {
                entity.Property(e => e.DescWeekhour).IsUnicode(false);

                entity.Property(e => e.EndTime).IsUnicode(false);

                entity.Property(e => e.StartTime).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CWincorEquivalenciasSgs>(entity =>
            {
                entity.HasKey(e => e.IdEquivalencia)
                    .HasName("PK__C_WINCOR__6AEAAC0100658DEB");

                entity.Property(e => e.DescStatusWincor).IsUnicode(false);

                entity.HasOne(d => d.IdStatusArNavigation)
                    .WithMany(p => p.CWincorEquivalenciasSgs)
                    .HasForeignKey(d => d.IdStatusAr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STATUS_AR_WINCOR_EQUIV");
            });

            modelBuilder.Entity<CZonaAtencionSantander>(entity =>
            {
                entity.Property(e => e.CentroServicio).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.Region).IsUnicode(false);

                entity.Property(e => e.Responsable).IsUnicode(false);
            });

            modelBuilder.Entity<CZonas>(entity =>
            {
                entity.HasKey(e => e.IdZona)
                    .HasName("PK_C_OFICINAS");

                entity.Property(e => e.CadenaF11).IsUnicode(false);

                entity.Property(e => e.DescZona).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.HasOne(d => d.IdRegionNavigation)
                    .WithMany(p => p.CZonas)
                    .HasForeignKey(d => d.IdRegion)
                    .HasConstraintName("FK_C_OFICINAS_C_REGIONES");
            });

            modelBuilder.Entity<CierresElavon>(entity =>
            {
                entity.HasKey(e => e.IdCierresElavon)
                    .HasName("PK__CIERRES___032023637A048D26");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.FechaCierre).IsUnicode(false);

                entity.Property(e => e.NombreUsuario).IsUnicode(false);

                entity.Property(e => e.Odtexterna).IsUnicode(false);

                entity.Property(e => e.StatusMov).IsUnicode(false);

                entity.Property(e => e.TipoUsuario).IsUnicode(false);
            });

            modelBuilder.Entity<ElavonInbox>(entity =>
            {
                entity.Property(e => e.Address1).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.Address3).IsUnicode(false);

                entity.Property(e => e.AttentionWindow).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Colony).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.ConnectionType).IsUnicode(false);

                entity.Property(e => e.Contact).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CountyDistrict).IsUnicode(false);

                entity.Property(e => e.DeviceType).IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory).IsUnicode(false);

                entity.Property(e => e.DueBy).IsUnicode(false);

                entity.Property(e => e.ExternalTid).IsUnicode(false);

                entity.Property(e => e.Mid).IsUnicode(false);

                entity.Property(e => e.Phone1).IsUnicode(false);

                entity.Property(e => e.Phone2).IsUnicode(false);

                entity.Property(e => e.PurchaseType).IsUnicode(false);

                entity.Property(e => e.RequestId).IsUnicode(false);

                entity.Property(e => e.RequestType).IsUnicode(false);

                entity.Property(e => e.Serial).IsUnicode(false);

                entity.Property(e => e.SimCardCarrier).IsUnicode(false);

                entity.Property(e => e.StateProvince).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Terminal3DigitNumber).IsUnicode(false);

                entity.Property(e => e.Tid).IsUnicode(false);

                entity.Property(e => e.Zip).IsUnicode(false);
            });

            modelBuilder.Entity<ElavonOutbox>(entity =>
            {
                entity.Property(e => e.AssignmentNo).IsUnicode(false);

                entity.Property(e => e.AssignmentNoFrom).IsUnicode(false);

                entity.Property(e => e.BookingDt).IsUnicode(false);

                entity.Property(e => e.Cabecera).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DeviceType).IsUnicode(false);

                entity.Property(e => e.DeviceTypeCategory).IsUnicode(false);

                entity.Property(e => e.Mid).IsUnicode(false);

                entity.Property(e => e.Profile).IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNo).IsUnicode(false);

                entity.Property(e => e.RequestId).IsUnicode(false);

                entity.Property(e => e.RequestStatus).IsUnicode(false);

                entity.Property(e => e.Serial).IsUnicode(false);

                entity.Property(e => e.ServiceReceivedBy).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusReason).IsUnicode(false);

                entity.Property(e => e.StatusReasonCode).IsUnicode(false);

                entity.Property(e => e.Tid).IsUnicode(false);
            });

            modelBuilder.Entity<Equipos>(entity =>
            {
                entity.Property(e => e.NoEquipo).IsUnicode(false);

                entity.Property(e => e.NoImei).IsUnicode(false);

                entity.Property(e => e.NoInventario).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.PosicionInventario).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<ErroresArPrefacturacion>(entity =>
            {
                entity.HasKey(e => e.IdArError)
                    .HasName("PK__ERRORES___CB458F4DBA59FB62");

                entity.Property(e => e.Error).IsUnicode(false);
            });

            modelBuilder.Entity<HistoricoElavon>(entity =>
            {
                entity.HasKey(e => e.IdHistorico)
                    .HasName("PK_HOSTORICO_ELAVON");
            });

            modelBuilder.Entity<HistoricoElavonPaso>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoElavonPaso)
                    .HasName("PK__HISTORIC__C29EF394B9908975");

                entity.HasIndex(e => e.Afiliacion)
                    .HasName("missing_index_3915_3914");

                entity.HasIndex(e => e.Odt)
                    .HasName("missing_index_3917_3916");

                entity.Property(e => e.ActReferencias).IsUnicode(false);

                entity.Property(e => e.Afiliacion).IsUnicode(false);

                entity.Property(e => e.AfiliacionAmex).IsUnicode(false);

                entity.Property(e => e.AfiliacionCierreAmex).IsUnicode(false);

                entity.Property(e => e.AtiendeComercio).IsUnicode(false);

                entity.Property(e => e.Base).IsUnicode(false);

                entity.Property(e => e.CableCorriente).IsUnicode(false);

                entity.Property(e => e.Cargador).IsUnicode(false);

                entity.Property(e => e.Ciudad).IsUnicode(false);

                entity.Property(e => e.Codigo).IsUnicode(false);

                entity.Property(e => e.Colonia).IsUnicode(false);

                entity.Property(e => e.Comercio).IsUnicode(false);

                entity.Property(e => e.Conectividad).IsUnicode(false);

                entity.Property(e => e.Contacto1).IsUnicode(false);

                entity.Property(e => e.CorreoEjecutio).IsUnicode(false);

                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.CriterioCambio).IsUnicode(false);

                entity.Property(e => e.Direccion).IsUnicode(false);

                entity.Property(e => e.Discover).IsUnicode(false);

                entity.Property(e => e.DomicilioAlterno).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.Estado).IsUnicode(false);

                entity.Property(e => e.EstatusServicio).IsUnicode(false);

                entity.Property(e => e.FechaAltaSistema).IsUnicode(false);

                entity.Property(e => e.FechaAtencionProveedor).IsUnicode(false);

                entity.Property(e => e.FechaCierreSistema).IsUnicode(false);

                entity.Property(e => e.FechaVencimiento).IsUnicode(false);

                entity.Property(e => e.HorasEncidas).IsUnicode(false);

                entity.Property(e => e.IdAmex).IsUnicode(false);

                entity.Property(e => e.IdCaja).IsUnicode(false);

                entity.Property(e => e.IdEquipo).IsUnicode(false);

                entity.Property(e => e.Modelo).IsUnicode(false);

                entity.Property(e => e.ModeloInstalado).IsUnicode(false);

                entity.Property(e => e.ModeloTerminalSale).IsUnicode(false);

                entity.Property(e => e.MotivoCancelacion).IsUnicode(false);

                entity.Property(e => e.MotivoRechazo).IsUnicode(false);

                entity.Property(e => e.Nivel).IsUnicode(false);

                entity.Property(e => e.NoSerieEntra).IsUnicode(false);

                entity.Property(e => e.NoSerieMantto).IsUnicode(false);

                entity.Property(e => e.NoSerieSale).IsUnicode(false);

                entity.Property(e => e.NoSimEntra).IsUnicode(false);

                entity.Property(e => e.NoSimSale).IsUnicode(false);

                entity.Property(e => e.Odt).IsUnicode(false);

                entity.Property(e => e.Producto).IsUnicode(false);

                entity.Property(e => e.Proveedor).IsUnicode(false);

                entity.Property(e => e.RazonSocial).IsUnicode(false);

                entity.Property(e => e.Rechazo).IsUnicode(false);

                entity.Property(e => e.Rfc).IsUnicode(false);

                entity.Property(e => e.RollosEntregados).IsUnicode(false);

                entity.Property(e => e.SubTipoServicio).IsUnicode(false);

                entity.Property(e => e.Tecnico).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);

                entity.Property(e => e.TelefonosCampo).IsUnicode(false);

                entity.Property(e => e.TidAmexCierre).IsUnicode(false);

                entity.Property(e => e.TiempoAtencion).IsUnicode(false);

                entity.Property(e => e.TieneAmex).IsUnicode(false);

                entity.Property(e => e.TipoAB).IsUnicode(false);

                entity.Property(e => e.TipoComercio).IsUnicode(false);

                entity.Property(e => e.TipoServicio).IsUnicode(false);

                entity.Property(e => e.VersionSw).IsUnicode(false);

                entity.Property(e => e.Zona).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBansefi>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBbva>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBbvaWincor>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBmxAtm>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosBmxpl>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosFujitsuBajio>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosFujitsuBanjercito>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosFujitsuHsbc>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosFujitsuInd>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosHsbc>(entity =>
            {
                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosHsbcFujitsu>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosHsbcWincor>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosSantander>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosSantanderWincor>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosSat>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosSoftel>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);
            });

            modelBuilder.Entity<NegociosTelefonica>(entity =>
            {
                entity.Property(e => e.Cp).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.Telefono).IsUnicode(false);
            });

            modelBuilder.Entity<ReporteHojaServicios>(entity =>
            {
                entity.HasKey(e => e.IdReporteHojaServicio)
                    .HasName("PK__REPORTE___938FB86D46B8DA9A");

                entity.Property(e => e.AbrevTecnico).IsUnicode(false);

                entity.Property(e => e.Accesorios).IsUnicode(false);

                entity.Property(e => e.Cliente).IsUnicode(false);

                entity.Property(e => e.Comentario).IsUnicode(false);

                entity.Property(e => e.Empresa).IsUnicode(false);

                entity.Property(e => e.EnviadoPor).IsUnicode(false);

                entity.Property(e => e.FallaReport).IsUnicode(false);

                entity.Property(e => e.FolioTelmex).IsUnicode(false);

                entity.Property(e => e.NoReporte).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.Observaciones).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.ReporteHojaServicios)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_BD_UNIDADES");
            });

            modelBuilder.Entity<SantanderOutbox>(entity =>
            {
                entity.Property(e => e.NameFile).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<SantanderOutboxCierre>(entity =>
            {
                entity.Property(e => e.Afiliacion).IsUnicode(false);

                entity.Property(e => e.Aplicacion).IsUnicode(false);

                entity.Property(e => e.Atendio).IsUnicode(false);

                entity.Property(e => e.Caja).IsUnicode(false);

                entity.Property(e => e.ComentariosSolucion).IsUnicode(false);

                entity.Property(e => e.Estatus).IsUnicode(false);

                entity.Property(e => e.IdResultado).IsUnicode(false);

                entity.Property(e => e.InsumosEntregados).IsUnicode(false);

                entity.Property(e => e.Odt).IsUnicode(false);

                entity.Property(e => e.SerieBaseInstalada).IsUnicode(false);

                entity.Property(e => e.SerieBaseRetirada).IsUnicode(false);

                entity.Property(e => e.SerieInstalada).IsUnicode(false);

                entity.Property(e => e.SerieRetirada).IsUnicode(false);

                entity.Property(e => e.SimInstalado).IsUnicode(false);

                entity.Property(e => e.SimRetirado).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<Sepomex>(entity =>
            {
                entity.HasIndex(e => e.DCp)
                    .HasName("IX_SEPOMEX_2");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_SEPOMEX")
                    .IsUnique();

                entity.HasIndex(e => new { e.DCp, e.DEstado })
                    .HasName("IX_SEPOMEX_3");

                entity.HasIndex(e => new { e.DCp, e.DMnpio })
                    .HasName("IX_SEPOMEX_4");

                entity.HasIndex(e => new { e.DCp, e.DEstado, e.DMnpio, e.DCiudad, e.DAsenta })
                    .HasName("IX_SEPOMEX_1");

                entity.HasIndex(e => new { e.Id, e.DAsenta, e.DMnpio, e.DCiudad, e.DCp, e.DEstado })
                    .HasName("missing_index_225908_225907");

                entity.HasIndex(e => new { e.Id, e.DAsenta, e.DMnpio, e.DCiudad, e.DCp, e.IdTipoLocalidad, e.DEstado })
                    .HasName("missing_index_208_207");

                entity.Property(e => e.DAsenta).IsUnicode(false);

                entity.Property(e => e.DCiudad).IsUnicode(false);

                entity.Property(e => e.DMnpio).IsUnicode(false);
            });

            modelBuilder.Entity<SepomexEstados>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<SepomexOld>(entity =>
            {
                entity.HasIndex(e => e.DCp)
                    .HasName("IX_SEPOMEX_d_CP");

                entity.HasIndex(e => new { e.Id, e.DAsenta, e.DMnpio, e.DCiudad, e.DCp, e.DEstado })
                    .HasName("IX_SEPOMEX_d_estado");

                entity.Property(e => e.DAsenta).IsUnicode(false);

                entity.Property(e => e.DCiudad).IsUnicode(false);

                entity.Property(e => e.DMnpio).IsUnicode(false);
            });

            modelBuilder.Entity<TempAfiliaciones>(entity =>
            {
                entity.Property(e => e.NoAfiliacion).IsUnicode(false);
            });

            modelBuilder.Entity<TempHorarios>(entity =>
            {
                entity.Property(e => e.NoAfiliacion).IsUnicode(false);
            });

            modelBuilder.Entity<TempUpdateNoInventario>(entity =>
            {
                entity.Property(e => e.NoInventario).IsUnicode(false);
            });

            modelBuilder.Entity<UnidadesBnmAtm>(entity =>
            {
                entity.Property(e => e.Modelo).IsUnicode(false);

                entity.Property(e => e.NoAfiliacion).IsUnicode(false);

                entity.Property(e => e.NoEquipo).IsUnicode(false);

                entity.Property(e => e.NoImei).IsUnicode(false);

                entity.Property(e => e.NoInventario).IsUnicode(false);

                entity.Property(e => e.NoSerie).IsUnicode(false);

                entity.Property(e => e.NoSim).IsUnicode(false);

                entity.Property(e => e.PosicionInv).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });
            modelBuilder.Query<SpGetPassword>();
            modelBuilder.Query<ODT>();
            modelBuilder.Query<OdtsYears>();
        }
    }
}

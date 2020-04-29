using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_USUARIOS")]
    public partial class CUsuarios
    {
        public CUsuarios()
        {
            BdAuditorias = new HashSet<BdAuditorias>();
            BdBitacoraModeloUnidad = new HashSet<BdBitacoraModeloUnidad>();
            BdBitacoraSolicitudDevolucion = new HashSet<BdBitacoraSolicitudDevolucion>();
            BdEnvioSims = new HashSet<BdEnvioSims>();
            BdEnvioUnidad = new HashSet<BdEnvioUnidad>();
            BdEnvios = new HashSet<BdEnvios>();
            BdInstalaciones = new HashSet<BdInstalaciones>();
            BdRetiros = new HashSet<BdRetiros>();
            BdSolicitudesAlmacenOldIdResponsableDestinoNavigation = new HashSet<BdSolicitudesAlmacenOld>();
            BdSolicitudesAlmacenOldIdUsuarioAltaNavigation = new HashSet<BdSolicitudesAlmacenOld>();
            BdSolicitudesAlmacenOldIdUsuarioConfirmNavigation = new HashSet<BdSolicitudesAlmacenOld>();
            BdSolicitudesDevolucionInsumos = new HashSet<BdSolicitudesDevolucionInsumos>();
            BdSolicitudesDevolucionModelo = new HashSet<BdSolicitudesDevolucionModelo>();
            BdSolicitudesDevolucionUnidad = new HashSet<BdSolicitudesDevolucionUnidad>();
            BdSustituciones = new HashSet<BdSustituciones>();
        }

        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("ID_TIPO_USUARIO")]
        public int? IdTipoUsuario { get; set; }
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("PATERNO")]
        [StringLength(50)]
        public string Paterno { get; set; }
        [Column("MATERNO")]
        [StringLength(50)]
        public string Materno { get; set; }
        [Column("USERNAME")]
        [StringLength(30)]
        public string Username { get; set; }
        [Column("PASSWORD")]
        [StringLength(200)]
        public string Password { get; set; }
        [Column("EMAIL")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("SEXO")]
        [StringLength(1)]
        public string Sexo { get; set; }
        [Column("TELEFONO")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("NO_ID_NEXTEL")]
        [StringLength(16)]
        public string NoIdNextel { get; set; }
        [Column("NO_TEL_NEXTEL")]
        [StringLength(20)]
        public string NoTelNextel { get; set; }
        [Column("ID_ALMACEN_OLD")]
        public int? IdAlmacenOld { get; set; }
        [Column("IS_PDA")]
        public int? IsPda { get; set; }
        [Column("FEC_ACCESO_PDA", TypeName = "smalldatetime")]
        public DateTime? FecAccesoPda { get; set; }
        [Column("CURP")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("ID_JEFE")]
        public int? IdJefe { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }
        [Column("FEC_EXP", TypeName = "smalldatetime")]
        public DateTime? FecExp { get; set; }
        [Column("CREDENCIAL")]
        [StringLength(64)]
        public string Credencial { get; set; }
        [Column("IS_FOLLOWER_DISPATCH")]
        public int? IsFollowerDispatch { get; set; }
        [Column("IS_DISPATCH_PROGRAMADOS")]
        public int? IsDispatchProgramados { get; set; }
        [Column("TELEFONO_OFICINA")]
        [StringLength(20)]
        public string TelefonoOficina { get; set; }
        [Column("TELEFONO_OFICINA_EXT")]
        [StringLength(4)]
        public string TelefonoOficinaExt { get; set; }
        [Column("TELEFONO_CASA")]
        [StringLength(20)]
        public string TelefonoCasa { get; set; }
        [Column("CELULAR")]
        [StringLength(20)]
        public string Celular { get; set; }
        [Column("ID_PUESTO")]
        public int? IdPuesto { get; set; }
        [Column("FEC_INGRESO", TypeName = "smalldatetime")]
        public DateTime? FecIngreso { get; set; }
        [Column("ID_EDO_NAC")]
        public int? IdEdoNac { get; set; }
        [Column("FEC_NAC", TypeName = "smalldatetime")]
        public DateTime? FecNac { get; set; }
        [Column("FEC_BAJA", TypeName = "smalldatetime")]
        public DateTime? FecBaja { get; set; }
        [Column("FEC_REINGRESO", TypeName = "smalldatetime")]
        public DateTime? FecReingreso { get; set; }
        [Column("ID_AREA")]
        public int? IdArea { get; set; }
        [Column("ID_HORARIO")]
        public int? IdHorario { get; set; }
        [Column("HREF_FOTO")]
        [StringLength(75)]
        public string HrefFoto { get; set; }
        [Column("FRASE")]
        [StringLength(250)]
        public string Frase { get; set; }
        [Column("IS_ELIGE_VACACIONES")]
        public int? IsEligeVacaciones { get; set; }
        [Column("IS_AUTORIZA_VACACIONES")]
        public int? IsAutorizaVacaciones { get; set; }
        [Column("DIAS_VACACIONES")]
        public int? DiasVacaciones { get; set; }
        [Column("IS_ELAVON")]
        public int? IsElavon { get; set; }
        [Column("IS_FEC_GARANTIA_CHANGE")]
        public int? IsFecGarantiaChange { get; set; }
        [Column("IS_ALL_CLIENTE")]
        public int? IsAllCliente { get; set; }
        [Column("ID_DIRECCIONES")]
        public int? IdDirecciones { get; set; }
        [Column("IS_REPORTE_DESVIACION")]
        public int? IsReporteDesviacion { get; set; }
        [Column("IS_EDITA_NEGOCIOS")]
        public int? IsEditaNegocios { get; set; }
        [Column("IS_EXLS_NEGOCIOS")]
        public int? IsExlsNegocios { get; set; }
        [Column("IS_ALTA_MASIVA_VIATICOS")]
        public int? IsAltaMasivaViaticos { get; set; }
        [Column("IS_EDITAR_ESPECIFICACIONES_SERVICIO")]
        public int? IsEditarEspecificacionesServicio { get; set; }
        [Column("IS_DANIADA_USUARIO")]
        public int? IsDaniadaUsuario { get; set; }
        [Column("IS_CONSULTA_UNIDAD")]
        public int? IsConsultaUnidad { get; set; }
        [Column("EXCEL_ULTIMO_MOV")]
        public int? ExcelUltimoMov { get; set; }
        [Column("MODIFICA_M_UNIDAD")]
        public int? ModificaMUnidad { get; set; }
        [Column("IS_REDIRECCION_ENVIO")]
        public int? IsRedireccionEnvio { get; set; }
        [Column("IS_ALTA_MASIVA_NEGOCIOS")]
        public int? IsAltaMasivaNegocios { get; set; }
        [Column("ID_PROVEEDOR")]
        public int? IdProveedor { get; set; }
        [Column("IS_CACHE")]
        public int? IsCache { get; set; }
        [Column("IS_ACTUALIZACION_MASIVA_COORDENADAS_NEGOCIO")]
        public int? IsActualizacionMasivaCoordenadasNegocio { get; set; }
        [Column("IS_EDITAR_ALMACEN")]
        public int? IsEditarAlmacen { get; set; }
        [Column("IS_REABRIR_AUDITORIA")]
        public int? IsReabrirAuditoria { get; set; }
        [Column("IS_MODIFIED_AR")]
        public int? IsModifiedAr { get; set; }
        [Column("IS_EMAIL_SERVICE_CHARGE")]
        public int? IsEmailServiceCharge { get; set; }
        [Column("EXCEL_USUARIO_CIERRE")]
        public int? ExcelUsuarioCierre { get; set; }
        [Column("IS_STOLEN_UNIT")]
        public int? IsStolenUnit { get; set; }
        [Column("IS_DELETE_DRIVE")]
        public int? IsDeleteDrive { get; set; }
        [Column("EMAIL_SERVICE_CLOSE")]
        public int? EmailServiceClose { get; set; }
        [Column("is_status_cambio_abiertas")]
        public int? IsStatusCambioAbiertas { get; set; }
        [Column("COMENTARIOS_OKI")]
        public int? ComentariosOki { get; set; }
        [Column("IS_PADRON_INGENIEROS")]
        public int? IsPadronIngenieros { get; set; }
        [Column("IS_MODIFICA_MENSAJERIA")]
        public int? IsModificaMensajeria { get; set; }
        [Column("is_mod_c_usuarios")]
        public int? IsModCUsuarios { get; set; }
        [Column("IS_ADD_REPLICATE")]
        public int? IsAddReplicate { get; set; }
        [Column("IS_RECOVER_PASSWORD")]
        public int? IsRecoverPassword { get; set; }
        [Column("IS_UPDATE_POSICION_INVENTARIO")]
        public int? IsUpdatePosicionInventario { get; set; }
        [Column("IS_REPORTE_LICENCIAS_DHL")]
        public int? IsReporteLicenciasDhl { get; set; }
        [Column("ID_DATOS_FISCALES")]
        public int? IdDatosFiscales { get; set; }
        [Column("IS_ADIMINISTRAR_USUARIOS")]
        public int? IsAdiministrarUsuarios { get; set; }
        [Column("IS_CALL_CENTER_CONTACTO")]
        public int? IsCallCenterContacto { get; set; }
        [Column("IS_CAMBIO_STATUS_UNIDAD_REGLA_DISPONIBLE_USADO")]
        public int? IsCambioStatusUnidadReglaDisponibleUsado { get; set; }

        [ForeignKey("IdTipoUsuario")]
        [InverseProperty("CUsuarios")]
        public virtual CTipoUsuario IdTipoUsuarioNavigation { get; set; }
        [InverseProperty("IdUsuarioAltaNavigation")]
        public virtual ICollection<BdAuditorias> BdAuditorias { get; set; }
        [InverseProperty("IdUsuarioAltaNavigation")]
        public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidad { get; set; }
        [InverseProperty("IdUsuarioAltaNavigation")]
        public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucion { get; set; }
        [InverseProperty("IdUsuarioRecepcionNavigation")]
        public virtual ICollection<BdEnvioSims> BdEnvioSims { get; set; }
        [InverseProperty("IdUsuarioRecepcionNavigation")]
        public virtual ICollection<BdEnvioUnidad> BdEnvioUnidad { get; set; }
        [InverseProperty("IdChoferNavigation")]
        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
        [InverseProperty("IdTecnicoNavigation")]
        public virtual ICollection<BdInstalaciones> BdInstalaciones { get; set; }
        [InverseProperty("IdTecnicoNavigation")]
        public virtual ICollection<BdRetiros> BdRetiros { get; set; }
        [InverseProperty("IdResponsableDestinoNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOldIdResponsableDestinoNavigation { get; set; }
        [InverseProperty("IdUsuarioAltaNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOldIdUsuarioAltaNavigation { get; set; }
        [InverseProperty("IdUsuarioConfirmNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOldIdUsuarioConfirmNavigation { get; set; }
        [InverseProperty("IdUsuarioAltaNavigation")]
        public virtual ICollection<BdSolicitudesDevolucionInsumos> BdSolicitudesDevolucionInsumos { get; set; }
        [InverseProperty("IdUsuarioAltaNavigation")]
        public virtual ICollection<BdSolicitudesDevolucionModelo> BdSolicitudesDevolucionModelo { get; set; }
        [InverseProperty("IdUsuarioAltaNavigation")]
        public virtual ICollection<BdSolicitudesDevolucionUnidad> BdSolicitudesDevolucionUnidad { get; set; }
        [InverseProperty("IdTecnicoNavigation")]
        public virtual ICollection<BdSustituciones> BdSustituciones { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
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

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string NoIdNextel { get; set; }
        public string NoTelNextel { get; set; }
        public int? IdAlmacenOld { get; set; }
        public int? IsPda { get; set; }
        public DateTime? FecAccesoPda { get; set; }
        public string Curp { get; set; }
        public int? IdJefe { get; set; }
        public int? IdZona { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioStatus { get; set; }
        public DateTime? FecStatus { get; set; }
        public DateTime? FecExp { get; set; }
        public string Credencial { get; set; }
        public int? IsFollowerDispatch { get; set; }
        public int? IsDispatchProgramados { get; set; }
        public string TelefonoOficina { get; set; }
        public string TelefonoOficinaExt { get; set; }
        public string TelefonoCasa { get; set; }
        public string Celular { get; set; }
        public int? IdPuesto { get; set; }
        public DateTime? FecIngreso { get; set; }
        public int? IdEdoNac { get; set; }
        public DateTime? FecNac { get; set; }
        public DateTime? FecBaja { get; set; }
        public DateTime? FecReingreso { get; set; }
        public int? IdArea { get; set; }
        public int? IdHorario { get; set; }
        public string HrefFoto { get; set; }
        public string Frase { get; set; }
        public int? IsEligeVacaciones { get; set; }
        public int? IsAutorizaVacaciones { get; set; }
        public int? DiasVacaciones { get; set; }
        public int? IsElavon { get; set; }
        public int? IsFecGarantiaChange { get; set; }
        public int? IsAllCliente { get; set; }
        public int? IdDirecciones { get; set; }
        public int? IsReporteDesviacion { get; set; }
        public int? IsEditaNegocios { get; set; }
        public int? IsExlsNegocios { get; set; }
        public int? IsAltaMasivaViaticos { get; set; }
        public int? IsEditarEspecificacionesServicio { get; set; }
        public int? IsDaniadaUsuario { get; set; }
        public int? IsConsultaUnidad { get; set; }
        public int? ExcelUltimoMov { get; set; }
        public int? ModificaMUnidad { get; set; }
        public int? IsRedireccionEnvio { get; set; }
        public int? IsAltaMasivaNegocios { get; set; }
        public int? IdProveedor { get; set; }
        public int? IsCache { get; set; }
        public int? IsActualizacionMasivaCoordenadasNegocio { get; set; }
        public int? IsEditarAlmacen { get; set; }
        public int? IsReabrirAuditoria { get; set; }
        public int? IsModifiedAr { get; set; }
        public int? IsEmailServiceCharge { get; set; }
        public int? ExcelUsuarioCierre { get; set; }
        public int? IsStolenUnit { get; set; }
        public int? IsDeleteDrive { get; set; }
        public int? EmailServiceClose { get; set; }
        public int? IsStatusCambioAbiertas { get; set; }
        public int? ComentariosOki { get; set; }
        public int? IsPadronIngenieros { get; set; }
        public int? IsModificaMensajeria { get; set; }
        public int? IsModCUsuarios { get; set; }
        public int? IsAddReplicate { get; set; }
        public int? IsRecoverPassword { get; set; }
        public int? IsUpdatePosicionInventario { get; set; }
        public int? IsReporteLicenciasDhl { get; set; }
        public int? IdDatosFiscales { get; set; }
        public int? IsAdiministrarUsuarios { get; set; }
        public int? IsCallCenterContacto { get; set; }

        public virtual CTipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<BdAuditorias> BdAuditorias { get; set; }
        public virtual ICollection<BdBitacoraModeloUnidad> BdBitacoraModeloUnidad { get; set; }
        public virtual ICollection<BdBitacoraSolicitudDevolucion> BdBitacoraSolicitudDevolucion { get; set; }
        public virtual ICollection<BdEnvioSims> BdEnvioSims { get; set; }
        public virtual ICollection<BdEnvioUnidad> BdEnvioUnidad { get; set; }
        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
        public virtual ICollection<BdInstalaciones> BdInstalaciones { get; set; }
        public virtual ICollection<BdRetiros> BdRetiros { get; set; }
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOldIdResponsableDestinoNavigation { get; set; }
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOldIdUsuarioAltaNavigation { get; set; }
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOldIdUsuarioConfirmNavigation { get; set; }
        public virtual ICollection<BdSolicitudesDevolucionInsumos> BdSolicitudesDevolucionInsumos { get; set; }
        public virtual ICollection<BdSolicitudesDevolucionModelo> BdSolicitudesDevolucionModelo { get; set; }
        public virtual ICollection<BdSolicitudesDevolucionUnidad> BdSolicitudesDevolucionUnidad { get; set; }
        public virtual ICollection<BdSustituciones> BdSustituciones { get; set; }
    }
}

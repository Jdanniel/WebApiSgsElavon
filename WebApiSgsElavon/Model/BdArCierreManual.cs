using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_CIERRE_MANUAL")]
    public partial class BdArCierreManual
    {
        [Key]
        [Column("ID_CIERRE_MANUAL")]
        public int IdCierreManual { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("NO_SERIE_INSTALACION")]
        [StringLength(30)]
        public string NoSerieInstalacion { get; set; }
        [Column("ID_CONECTIVIDAD_INSTALACION")]
        public int? IdConectividadInstalacion { get; set; }
        [Column("ID_APLICATIVO_INSTALACION")]
        public int? IdAplicativoInstalacion { get; set; }
        [Column("VERSION_INSTALACION")]
        [StringLength(20)]
        public string VersionInstalacion { get; set; }
        [Column("ARCHIVO_TERMINAL_INSTALACION")]
        [StringLength(100)]
        public string ArchivoTerminalInstalacion { get; set; }
        [Column("SE_DEJA_MISMO_SIM")]
        public int? SeDejaMismoSim { get; set; }
        [Column("SIM_EXISTENTE")]
        [StringLength(20)]
        public string SimExistente { get; set; }
        [Column("SIM_INSTALACION")]
        [StringLength(20)]
        public string SimInstalacion { get; set; }
        [Column("ID_CARRIER_INSTALACION")]
        public int? IdCarrierInstalacion { get; set; }
        [Column("ARCHIVO_SIM_INSTALACION")]
        [StringLength(100)]
        public string ArchivoSimInstalacion { get; set; }
        [Column("ID_MARCA_RETIRO")]
        public int? IdMarcaRetiro { get; set; }
        [Column("ID_MODELO_RETIRO")]
        public int? IdModeloRetiro { get; set; }
        [Column("NO_SERIE_RETIRO")]
        [StringLength(30)]
        public string NoSerieRetiro { get; set; }
        [Column("ID_APLICATIVO_RETIRO")]
        public int? IdAplicativoRetiro { get; set; }
        [Column("ID_CONECTIVIDAD_RETIRO")]
        public int? IdConectividadRetiro { get; set; }
        [Column("VERSION_RETIRO")]
        [StringLength(20)]
        public string VersionRetiro { get; set; }
        [Column("ARCHIVO_TERMINAL_RETIRO")]
        [StringLength(100)]
        public string ArchivoTerminalRetiro { get; set; }
        [Column("NO_SE_RETIRA_SIM")]
        public int? NoSeRetiraSim { get; set; }
        [Column("SIM_SIN_RETIRAR")]
        [StringLength(20)]
        public string SimSinRetirar { get; set; }
        [Column("SIM_RETIRO")]
        [StringLength(20)]
        public string SimRetiro { get; set; }
        [Column("ID_CARRIER_RET")]
        public int? IdCarrierRet { get; set; }
        [Column("ARCHIVO_SIM_RETIRADO")]
        [StringLength(100)]
        public string ArchivoSimRetirado { get; set; }
        [Column("FECHA_CIERRE", TypeName = "datetime")]
        public DateTime? FechaCierre { get; set; }
        [Column("ATIENDE")]
        [StringLength(100)]
        public string Atiende { get; set; }
        [Column("OTORGANTE_VOBO")]
        [StringLength(100)]
        public string OtorganteVobo { get; set; }
        [Column("ID_TIPO_ATENCION")]
        public int? IdTipoAtencion { get; set; }
        [Column("ID_CRITERIO_CAMBIO")]
        public int? IdCriterioCambio { get; set; }
        [Column("ROLLOS_INSTALADOS")]
        public int? RollosInstalados { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("DISCOVER")]
        [StringLength(2)]
        public string Discover { get; set; }
        [Column("IS_AMEX")]
        [StringLength(2)]
        public string IsAmex { get; set; }
        [Column("CONCLUSIONES_AMEX")]
        [StringLength(100)]
        public string ConclusionesAmex { get; set; }
        [Column("ID_AMEX")]
        public int? IdAmex { get; set; }
        [Column("AFILIACION_AMEX")]
        public int? AfiliacionAmex { get; set; }
        [Column("COMENTARIOS_SERVICIO")]
        [StringLength(2000)]
        public string ComentariosServicio { get; set; }
        [Column("ID_SERIE_CAMBIO_CONECT")]
        public int? IdSerieCambioConect { get; set; }
        [Column("ID_MARCA_CAMBIO_CONECT")]
        public int? IdMarcaCambioConect { get; set; }
        [Column("ID_MODELO_CAMBIO_CONECT")]
        public int? IdModeloCambioConect { get; set; }
        [Column("ID_CONECTIVIDAD_CAMBIO_CONECT")]
        public int? IdConectividadCambioConect { get; set; }
        [Column("VERSION_CAMBIO_CONECT")]
        [StringLength(20)]
        public string VersionCambioConect { get; set; }
        [Column("ID_APLICATIVO_CAMBIO_CONECT")]
        public int? IdAplicativoCambioConect { get; set; }
        [Column("NO_SERIE_CAMBIO_CONECT_")]
        [StringLength(30)]
        public string NoSerieCambioConect { get; set; }
        [Column("RETIRO_SIM_CAMBIO_CONECT")]
        [StringLength(2)]
        public string RetiroSimCambioConect { get; set; }
        [Column("SIM_CAMBIO_CONECT")]
        [StringLength(20)]
        public string SimCambioConect { get; set; }
        [Column("ID_CARRIER_CAMBIO_CONECT")]
        public int? IdCarrierCambioConect { get; set; }
        [Column("ARCHIVO_CAMBIO_CONECT")]
        [StringLength(100)]
        public string ArchivoCambioConect { get; set; }
        [Column("ID_CONECTIVIDAD_CAMBIO_CONECT_NUEVA")]
        public int? IdConectividadCambioConectNueva { get; set; }
        [Column("ID_CONECTIVIDAD_CAMBIO_CONECT_NUEVA_EXISTE")]
        public int? IdConectividadCambioConectNuevaExiste { get; set; }
        [Column("ESTATUS")]
        [StringLength(12)]
        public string Estatus { get; set; }
        [Column("TIPO_MOVIMIENTO")]
        [StringLength(30)]
        public string TipoMovimiento { get; set; }
        [Column("CAJA")]
        public int? Caja { get; set; }
        [Column("USUARIO_ID")]
        public int? UsuarioId { get; set; }
        [Column("BATERIA")]
        [StringLength(2)]
        public string Bateria { get; set; }
        [Column("ELIMINADOR")]
        [StringLength(2)]
        public string Eliminador { get; set; }
        [Column("TAPA")]
        [StringLength(2)]
        public string Tapa { get; set; }
        [Column("CABLE_AC")]
        [StringLength(2)]
        public string CableAc { get; set; }
        [Column("BASE")]
        [StringLength(2)]
        public string Base { get; set; }
        [Column("BATERIA_RET")]
        [StringLength(2)]
        public string BateriaRet { get; set; }
        [Column("ELIMINADOR_RET")]
        [StringLength(2)]
        public string EliminadorRet { get; set; }
        [Column("TAPA_RET")]
        [StringLength(2)]
        public string TapaRet { get; set; }
        [Column("CABLE_AC_RET")]
        [StringLength(2)]
        public string CableAcRet { get; set; }
        [Column("BASE_RET")]
        [StringLength(2)]
        public string BaseRet { get; set; }
        [Column("ID_CIERRE_MASIVO")]
        public int? IdCierreMasivo { get; set; }
        [Column("ORIGEN")]
        [StringLength(3)]
        public string Origen { get; set; }
    }
}

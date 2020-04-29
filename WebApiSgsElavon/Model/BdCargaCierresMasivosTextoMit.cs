using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGA_CIERRES_MASIVOS_TEXTO_MIT")]
    public partial class BdCargaCierresMasivosTextoMit
    {
        [Key]
        [Column("ID_CIERRE_MASIVO")]
        public int IdCierreMasivo { get; set; }
        [Required]
        [Column("ID_PROCESO")]
        [StringLength(50)]
        public string IdProceso { get; set; }
        [Column("ESTATUS_PROCESO")]
        [StringLength(15)]
        public string EstatusProceso { get; set; }
        [Required]
        [Column("FILE_NAME")]
        [StringLength(255)]
        public string FileName { get; set; }
        [Required]
        [Column("RUTA")]
        [StringLength(255)]
        public string Ruta { get; set; }
        [Column("FECHA_CARGA", TypeName = "datetime")]
        public DateTime? FechaCarga { get; set; }
        [Column("ID_USUARIO_CARGA")]
        public int? IdUsuarioCarga { get; set; }
        [Required]
        [Column("ODT")]
        [StringLength(50)]
        public string Odt { get; set; }
        [Column("TIPO")]
        [StringLength(20)]
        public string Tipo { get; set; }
        [Required]
        [Column("DAY_CIERRE")]
        [StringLength(10)]
        public string DayCierre { get; set; }
        [Required]
        [Column("MONTH_CIERRE")]
        [StringLength(10)]
        public string MonthCierre { get; set; }
        [Required]
        [Column("YEAR_CIERRE")]
        [StringLength(10)]
        public string YearCierre { get; set; }
        [Required]
        [Column("HOUR_CIERRE")]
        [StringLength(10)]
        public string HourCierre { get; set; }
        [Required]
        [Column("MINUTE_CIERRE")]
        [StringLength(10)]
        public string MinuteCierre { get; set; }
        [Required]
        [Column("ATIENDE")]
        [StringLength(100)]
        public string Atiende { get; set; }
        [Required]
        [Column("OTORGA_VOBO")]
        [StringLength(100)]
        public string OtorgaVobo { get; set; }
        [Required]
        [Column("TIPO_ATENCION")]
        [StringLength(100)]
        public string TipoAtencion { get; set; }
        [Required]
        [Column("TECNICO")]
        [StringLength(100)]
        public string Tecnico { get; set; }
        [Required]
        [Column("ROLLOS_INSTALADOS")]
        [StringLength(10)]
        public string RollosInstalados { get; set; }
        [Required]
        [Column("DISCOVER")]
        [StringLength(2)]
        public string Discover { get; set; }
        [Required]
        [Column("CAJA")]
        [StringLength(10)]
        public string Caja { get; set; }
        [Required]
        [Column("COMENTARIOS")]
        public string Comentarios { get; set; }
        [Column("ESTATUS_ODT")]
        public int EstatusOdt { get; set; }
        [Column("ID_CANCELACION")]
        [StringLength(200)]
        public string IdCancelacion { get; set; }
        [Column("ID_RECHAZO")]
        [StringLength(200)]
        public string IdRechazo { get; set; }
        [Column("ID_SUB_RECHAZO")]
        [StringLength(200)]
        public string IdSubRechazo { get; set; }
        [Column("ID_CRITERIO_CAMBIO")]
        [StringLength(100)]
        public string IdCriterioCambio { get; set; }
        [Column("NO_SERIE_INSTALACION")]
        [StringLength(100)]
        public string NoSerieInstalacion { get; set; }
        [Column("ID_CONECTIVIDAD_INSTALACION")]
        [StringLength(200)]
        public string IdConectividadInstalacion { get; set; }
        [Column("ID_APLICATIVO_INSTALACION")]
        [StringLength(200)]
        public string IdAplicativoInstalacion { get; set; }
        [Column("VERSION_INSTALACION")]
        [StringLength(15)]
        public string VersionInstalacion { get; set; }
        [Column("SE_DEJA_MISMO_SIM")]
        [StringLength(20)]
        public string SeDejaMismoSim { get; set; }
        [Column("SIM_INSTALACION")]
        [StringLength(21)]
        public string SimInstalacion { get; set; }
        [Column("BATERIA_INSTALACION")]
        [StringLength(2)]
        public string BateriaInstalacion { get; set; }
        [Column("ELIMINADOR_INSTALACION")]
        [StringLength(2)]
        public string EliminadorInstalacion { get; set; }
        [Column("TAPA_INSTALACION")]
        [StringLength(2)]
        public string TapaInstalacion { get; set; }
        [Column("CABLE_AC_INSTALACION")]
        [StringLength(2)]
        public string CableAcInstalacion { get; set; }
        [Column("BASE_INSTALACION")]
        [StringLength(2)]
        public string BaseInstalacion { get; set; }
        [Column("ES_AMEX")]
        [StringLength(2)]
        public string EsAmex { get; set; }
        [Column("ID_AMEX")]
        [StringLength(20)]
        public string IdAmex { get; set; }
        [Column("AFILIACION_AMEX")]
        [StringLength(20)]
        public string AfiliacionAmex { get; set; }
        [Column("CONCLUSIONES_AMEX")]
        [StringLength(300)]
        public string ConclusionesAmex { get; set; }
        [Column("NO_SERIE_RETIRO")]
        [StringLength(50)]
        public string NoSerieRetiro { get; set; }
        [Column("ID_MARCA_RETIRO")]
        [StringLength(100)]
        public string IdMarcaRetiro { get; set; }
        [Column("ID_MODELO_RETIRO")]
        [StringLength(100)]
        public string IdModeloRetiro { get; set; }
        [Column("ID_APLICATIVO_RETIRO")]
        [StringLength(100)]
        public string IdAplicativoRetiro { get; set; }
        [Column("ID_CONECTIIDAD_RETIRO")]
        [StringLength(100)]
        public string IdConectiidadRetiro { get; set; }
        [Column("VERSION_RETIRO")]
        [StringLength(15)]
        public string VersionRetiro { get; set; }
        [Column("NO_SE_RETIRA_SIM")]
        [StringLength(2)]
        public string NoSeRetiraSim { get; set; }
        [Column("SIM_RETIRO")]
        [StringLength(20)]
        public string SimRetiro { get; set; }
        [Column("BATERIA_RETIRO")]
        [StringLength(2)]
        public string BateriaRetiro { get; set; }
        [Column("ELIMINADOR_RETIRO")]
        [StringLength(2)]
        public string EliminadorRetiro { get; set; }
        [Column("TAPA_RETIRO")]
        [StringLength(2)]
        public string TapaRetiro { get; set; }
        [Column("CABLE_AC_RETIRO")]
        [StringLength(2)]
        public string CableAcRetiro { get; set; }
        [Column("BASE_RETIRO")]
        [StringLength(2)]
        public string BaseRetiro { get; set; }
        [Column("MENSAJE_ERROR")]
        public string MensajeError { get; set; }
        [Column("SI_REQ_PROMO")]
        [StringLength(2)]
        public string SiReqPromo { get; set; }
        [Column("SE_BAJO_APP")]
        [StringLength(2)]
        public string SeBajoApp { get; set; }
        [Column("COMERCIO_NOTIFICADO")]
        [StringLength(2)]
        public string ComercioNotificado { get; set; }
        [Column("TELEFONO_1")]
        [StringLength(10)]
        public string Telefono1 { get; set; }
        [Column("TELEFONO_2")]
        [StringLength(10)]
        public string Telefono2 { get; set; }
    }
}

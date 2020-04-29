using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("HISTORICO_ELAVON")]
    public partial class HistoricoElavon
    {
        [Column("ID_HISTORICO")]
        public int IdHistorico { get; set; }
        [Required]
        [Column("ODT")]
        [StringLength(100)]
        public string Odt { get; set; }
        [Column("DISCOVER")]
        [StringLength(10)]
        public string Discover { get; set; }
        [Column("AFILIACION")]
        [StringLength(20)]
        public string Afiliacion { get; set; }
        [Column("COMERCIO")]
        [StringLength(255)]
        public string Comercio { get; set; }
        [Column("DIRECCION")]
        [StringLength(150)]
        public string Direccion { get; set; }
        [Column("COLONIA")]
        [StringLength(150)]
        public string Colonia { get; set; }
        [Column("CIUDAD")]
        [StringLength(100)]
        public string Ciudad { get; set; }
        [Column("ESTADO")]
        [StringLength(50)]
        public string Estado { get; set; }
        [Required]
        [Column("FECHA_ALTA")]
        [StringLength(25)]
        public string FechaAlta { get; set; }
        [Column("FECHA_VENCIMIENTO")]
        [StringLength(25)]
        public string FechaVencimiento { get; set; }
        [Column("DESCRIPCION", TypeName = "text")]
        public string Descripcion { get; set; }
        [Column("OBSERVACIONES", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("TELEFONO")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("TIPO_COMERCIO")]
        [StringLength(30)]
        public string TipoComercio { get; set; }
        [Column("NIVEL")]
        [StringLength(30)]
        public string Nivel { get; set; }
        [Column("TIPO_SERVICIO")]
        [StringLength(100)]
        public string TipoServicio { get; set; }
        [Column("SUB_TIPO_SERVICIO")]
        [StringLength(100)]
        public string SubTipoServicio { get; set; }
        [Column("CRITERIO_CAMBIO")]
        [StringLength(50)]
        public string CriterioCambio { get; set; }
        [Column("TECNICO")]
        [StringLength(100)]
        public string Tecnico { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(30)]
        public string Proveedor { get; set; }
        [Column("ESTATUS_SERVICIO")]
        [StringLength(20)]
        public string EstatusServicio { get; set; }
        [Column("FECHA_ATENCION_PROVEEDOR")]
        [StringLength(25)]
        public string FechaAtencionProveedor { get; set; }
        [Column("FECHA_CIERRE_SISTEMA")]
        [StringLength(25)]
        public string FechaCierreSistema { get; set; }
        [Column("FECHA_ALTA_SISTEMA")]
        [StringLength(25)]
        public string FechaAltaSistema { get; set; }
        [Column("CP")]
        [StringLength(10)]
        public string Cp { get; set; }
        [Column("CONCLUSIONES", TypeName = "text")]
        public string Conclusiones { get; set; }
        [Column("CONECTIVIDAD")]
        [StringLength(30)]
        public string Conectividad { get; set; }
        [Column("MODELO")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Column("ID_EQUIPO")]
        [StringLength(15)]
        public string IdEquipo { get; set; }
        [Column("ID_CAJA")]
        [StringLength(100)]
        public string IdCaja { get; set; }
        [Column("RFC")]
        [StringLength(20)]
        public string Rfc { get; set; }
        [Column("RAZON_SOCIAL")]
        [StringLength(155)]
        public string RazonSocial { get; set; }
        [Column("HORAS_ENCIDAS")]
        [StringLength(10)]
        public string HorasEncidas { get; set; }
        [Column("TIEMPO_ATENCION")]
        [StringLength(10)]
        public string TiempoAtencion { get; set; }
        [Column("SLA_FIJO")]
        public int? SlaFijo { get; set; }
        [Column("TELEFONOS_CAMPO")]
        [StringLength(60)]
        public string TelefonosCampo { get; set; }
        [Column("AFILIACION_AMEX")]
        [StringLength(50)]
        public string AfiliacionAmex { get; set; }
        [Column("ID_AMEX")]
        [StringLength(50)]
        public string IdAmex { get; set; }
        [Column("PRODUCTO")]
        [StringLength(100)]
        public string Producto { get; set; }
        [Column("MOTIVO_CANCELACION")]
        [StringLength(100)]
        public string MotivoCancelacion { get; set; }
        [Column("MOTIVO_RECHAZO")]
        [StringLength(150)]
        public string MotivoRechazo { get; set; }
        [Column("EMAIL")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("ROLLO_INSTALAR")]
        public int? RolloInstalar { get; set; }
        [Column("NO_SERIE_ENTRA")]
        [StringLength(50)]
        public string NoSerieEntra { get; set; }
        [Column("NO_SERIE_SALE")]
        [StringLength(50)]
        public string NoSerieSale { get; set; }
        [Column("NO_SERIE_MANTTO")]
        [StringLength(50)]
        public string NoSerieMantto { get; set; }
        [Column("NO_SIM_SALE")]
        [StringLength(50)]
        public string NoSimSale { get; set; }
        [Column("NO_SIM_ENTRA")]
        [StringLength(50)]
        public string NoSimEntra { get; set; }
        [Column("VERSION_SW")]
        [StringLength(80)]
        public string VersionSw { get; set; }
        [Column("CARGADOR")]
        [StringLength(10)]
        public string Cargador { get; set; }
        [Column("BASE")]
        [StringLength(10)]
        public string Base { get; set; }
        [Column("ROLLOS_ENTREGADOS")]
        [StringLength(10)]
        public string RollosEntregados { get; set; }
        [Column("CABLE_CORRIENTE")]
        [StringLength(10)]
        public string CableCorriente { get; set; }
        [Column("ZONA")]
        [StringLength(30)]
        public string Zona { get; set; }
        [Column("MODELO_INSTALADO")]
        [StringLength(100)]
        public string ModeloInstalado { get; set; }
        [Column("MODELO_TERMINAL_SALE")]
        [StringLength(100)]
        public string ModeloTerminalSale { get; set; }
        [Column("CORREO_EJECUTIO")]
        [StringLength(100)]
        public string CorreoEjecutio { get; set; }
        [Column("RECHAZO")]
        [StringLength(100)]
        public string Rechazo { get; set; }
        [Column("CONTACTO_1")]
        [StringLength(100)]
        public string Contacto1 { get; set; }
        [Column("ATIENDE_COMERCIO")]
        [StringLength(100)]
        public string AtiendeComercio { get; set; }
        [Column("TID_AMEX_CIERRE")]
        [StringLength(50)]
        public string TidAmexCierre { get; set; }
        [Column("AFILIACION_CIERRE_AMEX")]
        [StringLength(50)]
        public string AfiliacionCierreAmex { get; set; }
        [Column("CODIGO")]
        [StringLength(50)]
        public string Codigo { get; set; }
        [Column("TIENE_AMEX")]
        [StringLength(10)]
        public string TieneAmex { get; set; }
        [Column("ACT_REFERENCIAS")]
        [StringLength(100)]
        public string ActReferencias { get; set; }
        [Column("TIPO_A_B")]
        [StringLength(10)]
        public string TipoAB { get; set; }
        [Column("DOMICILIO_ALTERNO")]
        [StringLength(255)]
        public string DomicilioAlterno { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CLIENTES")]
    public partial class CClientes
    {
        public CClientes()
        {
            BdDevoluciones = new HashSet<BdDevoluciones>();
            BdGruposClientes = new HashSet<BdGruposClientes>();
            BdInstalaciones = new HashSet<BdInstalaciones>();
            BdModeloPrecio = new HashSet<BdModeloPrecio>();
            BdModeloSku = new HashSet<BdModeloSku>();
            BdNegocioHorasMes = new HashSet<BdNegocioHorasMes>();
            BdNegociosAlta = new HashSet<BdNegociosAlta>();
            BdReporteCierre = new HashSet<BdReporteCierre>();
            BdReporteCierreAr = new HashSet<BdReporteCierreAr>();
            BdSparePartPrecio = new HashSet<BdSparePartPrecio>();
        }

        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("DESC_CLIENTE")]
        [StringLength(50)]
        public string DescCliente { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("POR_RECHAZO", TypeName = "numeric(18, 2)")]
        public decimal? PorRechazo { get; set; }
        [Column("IS_REPARACIONES")]
        public int? IsReparaciones { get; set; }
        [Column("IS_ID_REQ")]
        public int? IsIdReq { get; set; }
        [Column("IS_LAB")]
        public int? IsLab { get; set; }
        [Column("IS_AR_UPDATES_NEGOCIO")]
        public int? IsArUpdatesNegocio { get; set; }
        [Column("IS_NUMERIC_NO_AFILIACION")]
        public int? IsNumericNoAfiliacion { get; set; }
        [Column("IS_NUMERIC_NO_AR")]
        public int? IsNumericNoAr { get; set; }
        [Column("IS_REPORTE_AR")]
        public int? IsReporteAr { get; set; }
        [Column("IS_VISITA_COBRABLE")]
        public int? IsVisitaCobrable { get; set; }
        [Column("IS_SINGLE_MOV_INV")]
        public int? IsSingleMovInv { get; set; }
        [Column("IS_UNIDAD_ATENDIDA_REQUIRED")]
        public int? IsUnidadAtendidaRequired { get; set; }
        [Column("IS_UPTIME")]
        public int? IsUptime { get; set; }
        [Column("POR_UPTIME", TypeName = "numeric(18, 2)")]
        public decimal? PorUptime { get; set; }
        [Column("ID_TIPO_CALCULO_UPTIME")]
        public int? IdTipoCalculoUptime { get; set; }
        [Column("IS_WINCOR")]
        public int? IsWincor { get; set; }
        [Column("IS_INTERFAZ_SANTANDER")]
        public int? IsInterfazSantander { get; set; }
        [Column("CADENA_WINCOR")]
        [StringLength(50)]
        public string CadenaWincor { get; set; }
        [Column("DOC_TIR")]
        [StringLength(50)]
        public string DocTir { get; set; }
        [Column("IS_RETIPIFICADOS")]
        public int? IsRetipificados { get; set; }
        [Column("IS_PREFACTURACION")]
        public int? IsPrefacturacion { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("ID_ACCESS")]
        public int? IdAccess { get; set; }
        [Column("CENTRO_COSTOS")]
        [StringLength(50)]
        public string CentroCostos { get; set; }
        [Column("CHAR_CODIGO_INTERVENCION")]
        [StringLength(1)]
        public string CharCodigoIntervencion { get; set; }
        [Column("IS_PENDIENTE_PARTE")]
        public int? IsPendienteParte { get; set; }
        [Column("IS_FACTURACION_AUTOMATICA")]
        public int? IsFacturacionAutomatica { get; set; }
        [Column("IS_SEGMENTO_DELIMITADOR")]
        public int? IsSegmentoDelimitador { get; set; }
        [Column("IS_CIERRE_MASIVO")]
        public int? IsCierreMasivo { get; set; }
        [Column("IS_ASIGNACION_MASIVA")]
        public int? IsAsignacionMasiva { get; set; }
        [Column("IS_AR_UNICO")]
        public int? IsArUnico { get; set; }
        [Column("IS_3_X_1")]
        public int? Is3X1 { get; set; }
        [Column("IS_TIME_NEEDED")]
        public int? IsTimeNeeded { get; set; }
        [Column("IS_VALIDA_TIR")]
        public int? IsValidaTir { get; set; }
        [Column("IS_ELAVON")]
        public int? IsElavon { get; set; }
        [Column("IS_ASIGNACION_AUTO")]
        public int? IsAsignacionAuto { get; set; }
        [Column("IS_FACTURACION_IGUALA")]
        public int? IsFacturacionIguala { get; set; }
        [Column("IS_PRECIO_DOBLE")]
        public int? IsPrecioDoble { get; set; }
        [Column("IS_ONE_UNIDAD")]
        public int? IsOneUnidad { get; set; }
        [Column("IS_FEC_GARANTIA_CHANGE")]
        public int? IsFecGarantiaChange { get; set; }
        [Column("IS_RETORNO_ACCESORIOS")]
        public int? IsRetornoAccesorios { get; set; }
        [Column("IS_SUSTITUCION_NO_NEEDED")]
        public int? IsSustitucionNoNeeded { get; set; }
        [Column("IS_PAGO_IGUALA")]
        public int? IsPagoIguala { get; set; }
        [Column("IS_PAGO_EVENTO")]
        public int? IsPagoEvento { get; set; }
        [Column("NO_POLITICA_VIATICOS")]
        public int? NoPoliticaViaticos { get; set; }
        [Column("IS_WINCOR_TIEMPO")]
        public int? IsWincorTiempo { get; set; }
        [Column("IS_SEND_HISTORY")]
        public int? IsSendHistory { get; set; }
        [Column("IS_MODIFIED_AR")]
        public int? IsModifiedAr { get; set; }
        [Column("IS_EMAIL_SERVICE_CHARGE")]
        public int? IsEmailServiceCharge { get; set; }
        [Column("is_mod_fec_cita")]
        public int? IsModFecCita { get; set; }
        [Column("IS_ADD_REPLICATE")]
        public int? IsAddReplicate { get; set; }
        [Column("IS_FEC_INICIO_DEFAULT")]
        public int? IsFecInicioDefault { get; set; }

        [ForeignKey("IdTipoCalculoUptime")]
        [InverseProperty("CClientes")]
        public virtual CTipoCalculoUptime IdTipoCalculoUptimeNavigation { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdDevoluciones> BdDevoluciones { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdGruposClientes> BdGruposClientes { get; set; }
        [InverseProperty("IdClienteIniNavigation")]
        public virtual ICollection<BdInstalaciones> BdInstalaciones { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdModeloPrecio> BdModeloPrecio { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdModeloSku> BdModeloSku { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdNegocioHorasMes> BdNegocioHorasMes { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdNegociosAlta> BdNegociosAlta { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdReporteCierre> BdReporteCierre { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdReporteCierreAr> BdReporteCierreAr { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<BdSparePartPrecio> BdSparePartPrecio { get; set; }
    }
}
